using MVVM.ViewModels.Base;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MVVM.ViewModels.Views
{
    class MainPageViewModel : ViewModelBase
    {
        public DataView News { get; }
        public DataView ImportantInformation { get; }
        public MainPageViewModel()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Diplom"].ConnectionString;
            DataTable DataTableBaseNewsPresenter = new DataTable();
            DataTable DataTableBaseImportantInformationPresenter = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter NewsAdapter = new SqlDataAdapter();
                SqlDataAdapter ImportantInformationAdapter = new SqlDataAdapter();
                NewsAdapter.SelectCommand = new SqlCommand("select Top(6) [id_news],[date_publication],[heading],[news] from [News] ORDER BY [id_news] desc", connection);
                NewsAdapter.Fill(DataTableBaseNewsPresenter);
                ImportantInformationAdapter.SelectCommand = new SqlCommand("select Top(6) [id_important_information],[date_publication],[heading],[important_information] from [Important_information] ORDER BY [id_important_information] desc", connection);
                ImportantInformationAdapter.Fill(DataTableBaseImportantInformationPresenter);
            }
            News = DataTableBaseNewsPresenter.DefaultView;
            ImportantInformation = DataTableBaseImportantInformationPresenter.DefaultView;
        }
    }
}
