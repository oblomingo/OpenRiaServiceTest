using System.Linq;
using System.Windows.Controls;
using System.Windows.Navigation;
using BusinessApplicationTest.Web;
using OpenRiaServices.Controls;

namespace BusinessApplicationTest.Views
{
    /// <summary>
    /// Home page for the application.
    /// </summary>
    public partial class Home : Page
    {
        /// <summary>
        /// Creates a new <see cref="Home"/> instance.
        /// </summary>
        public Home()
        {
            InitializeComponent();
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            var source = new DomainDataSource
                         {
                             DomainContext = new VaultDomainContext(),
                             QueryName = "GetVaults",
                             AutoLoad = true,
                         };
            source.LoadedData += DataSourceLoadedData;
            source.Load();
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void DataSourceLoadedData(object sender, LoadedDataEventArgs e)
        {
            var domainDataSource = sender as DomainDataSource;
            if (domainDataSource != null) 
                DataGrid.ItemsSource = domainDataSource.DataView.Cast<Vault>().ToList();
            ;
        }
    }
}