using MVVM.Models.Personal_data;
using MVVM.ViewModels.Base;
using MVVM.Views.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels.Views.MainPages
{
    class MainPageManagerViewModel : ViewModelBase
    {

        #region Инициализация данныйх из UserDataModel : UserDataModel

        #region Имя : UserDataModel.name

        private string _name = UserDataModel.name;

        /// <summary>Login</summary>
        public string name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        #endregion

        #region Фамилия : UserDataModel.surname

        private string _surname = UserDataModel.surname;

        /// <summary>Login</summary>
        public string surname
        {
            get => _surname;
            set => Set(ref _surname, value);
        }

        #endregion

        #region Должность : UserDataModel.access_lavel

        private string _access_lavel = UserDataModel.access_lavel;

        /// <summary>Login</summary>
        public string access_lavel
        {
            get => _access_lavel;
            set => Set(ref _access_lavel, value);
        }

        #endregion

        #region Изображение : UserDataModel.image

        private object _image = UserDataModel.image;

        /// <summary>Login</summary>
        public object image
        {
            get => _image;
            set => Set(ref _image, value);
        }

        #endregion

        #endregion

        #region Открытая страница : PageOpenThis

        private object _PageOpenThis = new MainPageView();

        /// <summary>Login</summary>
        public object PageOpenThis
        {
            get => _PageOpenThis;
            set => Set(ref _PageOpenThis, value);
        }

        #endregion

    }
}
