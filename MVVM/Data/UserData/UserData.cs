using MVVM.Models.Personal_data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Data.UserData
{
    class UserData
    {
        public UserData(string Login, string Password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Diplom"].ConnectionString;
            SqlConnection ThisConnection = new SqlConnection(connectionString);
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            thisCommand.CommandText = "select [image],[id_user],[access_lavel],[surname],[name],[patronymic] from [user] where [login]='" + Login + "' and [password]='" + Password + "'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            thisReader.Read();
            if (thisReader.HasRows)
            {
                UserDataModel.access_lavel = thisReader["access_lavel"].ToString();
                UserDataModel.surname = thisReader["surname"].ToString();
                UserDataModel.name = thisReader["name"].ToString();
                UserDataModel.patronymic = thisReader["patronymic"].ToString();
                UserDataModel.id_user = Convert.ToInt32(thisReader["id_user"].ToString());
                UserDataModel.image = thisReader["image"];
            }
            thisReader.Close();
            ThisConnection.Close();
        }
    }
}
