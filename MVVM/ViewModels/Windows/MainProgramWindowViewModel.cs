using MVVM.Models.Personal_data;
using MVVM.ViewModels.Base;

namespace MVVM.ViewModels.Windows
{
    class MainProgramWindowViewModel : ViewModelBase
    {
        #region Начальная страница : UserDataModel.page

        private object _StartPageRoles = UserDataModel.page;

        /// <summary>Login</summary>
        public object StartPageRoles
        {
            get => _StartPageRoles;
            set => Set(ref _StartPageRoles, value);
        }

        #endregion

        #region Заголовок окна : Title

        private string _Title = "\"ООО Партнер\"";

        /// <summary>Login</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion
    }
}
