﻿using System.Net;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using ProgrammSystem.Web.Commands;
using ProgramSystem.Bll.Services.Interfaces;

namespace ProgrammSystem.Web.vm
{
    public class AutorizationViewModel: ViewModelBase
    {
        private readonly IUserService _userService;

        #region Fields
        private string? login;
        private SecureString? password;
        #endregion

        #region Properties

        public string? Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }
        public SecureString? Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Commands
        public AsyncCommand AuthorizationCommand { get; set; }
        #endregion

        public AutorizationViewModel(IUserService userService)
        {
            Login = "researcher/admin";
            //Password = "researcher";
            _userService = userService;
            AuthorizationCommand = new AsyncCommand(AuthorizationAsync, CanAuthorization);
        }

        #region Methods
        private async Task AuthorizationAsync()
        {
            var user = _userService.GetAccountByLoginPassword(Login, new NetworkCredential("", Password).Password);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else if (user.Role == "admin")
            {
                MessageBox.Show("Вход под админом\n Пользователь " + user.Login);
            }
            else if (user.Role == "researcher")
            {
                MessageBox.Show("Вход под исследователем\n Пользователь " + user.Login);
            }
        }

        private bool CanAuthorization() => !string.IsNullOrEmpty(Login) && Password != null;

        #endregion

    }
}
