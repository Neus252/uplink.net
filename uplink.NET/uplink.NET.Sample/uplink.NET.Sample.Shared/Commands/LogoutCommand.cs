﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using uplink.NET.Sample.Shared.Interfaces;
using uplink.NET.Sample.Shared.Pages;
using uplink.NET.Sample.Shared.Services;
using uplink.NET.Sample.Shared.ViewModels;

namespace uplink.NET.Sample.Shared.Commands
{
    public class LogoutCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private ILoginService _loginService;

        public LogoutCommand(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _loginService.Logout();

            var frame = (Windows.UI.Xaml.Controls.Frame)Windows.UI.Xaml.Window.Current.Content;
            frame.Navigate(typeof(LogInPage));
        }
    }
}
