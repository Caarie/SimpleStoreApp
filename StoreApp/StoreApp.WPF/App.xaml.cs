using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StoreApp.EntityFramework;
using System.Windows;

namespace StoreApp.WPF
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((context, services) =>
                {
                    string ConnectionString = context.Configuration.GetConnectionString("sqlite");
                    services.AddDbContext<StoreDbContext>(c => c.UseSqlite(ConnectionString));
                    services.AddSingleton<StoreDbContextFactory>(new StoreDbContextFactory(ConnectionString));
                });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            StoreDbContextFactory ContextFactory = _host.Services.GetRequiredService<StoreDbContextFactory>();
            using (StoreDbContext context = ContextFactory.CreateDbContext())
            {
                context.Database.Migrate();
            }

            Window window = new MainWindow();
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}