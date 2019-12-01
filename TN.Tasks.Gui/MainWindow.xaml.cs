using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using RN.Tasks.Core;
using RN.Tasks.Domain.DAL;

namespace TN.Tasks.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DbContextOptions<RnContext> GetMemoryDbContextOptions(string connectionString, string migrationAssembly)
        {
            return new DbContextOptionsBuilder<RnContext>()
                .UseSqlServer(connectionString,
                    b => b.MigrationsAssembly(migrationAssembly))
                .Options;
        }

        public MainWindow()
        {
            InitializeComponent();

            var settings = AppSettings.Get();

            var context =
                new RnContext(GetMemoryDbContextOptions(settings.ConnectionString, RnContext.MigrationAssembly));

            var tasks = context.Tasks.ToList();
        }
    }
}
