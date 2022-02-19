using MVVM.Models.MainPage;
using MVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModels.Views
{
    class MainPageViewModel : ViewModelBase
    {
        public DataView News { get; }
        public MainPageViewModel()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Diplom"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("select [heading],[news] from [News]", connection);
                adapter.Fill(dt);
            }
            News = dt.DefaultView;
        }
    }
}
