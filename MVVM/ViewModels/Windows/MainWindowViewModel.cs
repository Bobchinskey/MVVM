using MVVM.Data.Procedures;
using MVVM.Data.UserData;
using MVVM.Infrastructure.Commands;
using MVVM.Models.Personal_data;
using MVVM.ViewModels.Base;
using MVVM.Views.Views.MainPages;
using MVVM.Views.Windows;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVM.ViewModels.Windows
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Данные Авторизации

        #region Login : TextBox

        private string _Login = "";

        /// <summary>Login</summary>
        public string Login
        {
            get => _Login;
            set => Set(ref _Login, value);
        }

        #endregion

        #region Password : PasswordBox

        private SecureString _SecurePassword;

        /// <summary>Password : PasswordBox</summary>
        public SecureString SecurePassword
        {
            get => _SecurePassword;
            set => Set(ref _SecurePassword, value);
        }
        public object DataContext { get; private set; }

        #endregion

        #endregion

        /*------------------------------------------------------------------------------------------------*/

        #region Команды

        public ICommand AuthorizationModuleCommand { get; }

        private bool CanAuthorizationModuleExecute(object p) => true;

        private void OnAuthorizationModuleExecuted(object p)
        {
            var passwordBox = p as PasswordBox;
            var password = passwordBox.Password;
            if (Login != "")
            {
                if (password != "")
                {
                    UserData userData = new UserData(Login,password);
                    if (UserDataModel.id_user != default(int))
                    {
                        MessageBox.Show(UserDataModel.name + " " + UserDataModel.surname + "\nДобро пожаловать в программу 'ООО Партнер'\nУдачного рабочего дня!","Авторизация", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        password = null;
                        HistoryUserInputBackUpProcedure mHistoryUserInputBackUpProcedure = new HistoryUserInputBackUpProcedure(UserDataModel.id_user);
                        if (UserDataModel.access_lavel == "Администратор")
                            UserDataModel.page = new MainPageAdminView();
                        MainProgramWindow mainProgramWindow = new MainProgramWindow();
                        mainProgramWindow.Show();
                        foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
                        {
                            if (window.DataContext == this)
                            {
                                window.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Введенный логин или пароль, неверный");
                }
                else
                    MessageBox.Show("Введите пароль");
            }
            else
                MessageBox.Show("Введите логин");
        }

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            AuthorizationModuleCommand = new LamdaCommand(OnAuthorizationModuleExecuted, CanAuthorizationModuleExecute);

            #endregion
        }
    }
}
