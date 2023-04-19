
using H_Resource._Repositories;
using H_Resource.Presenters;
using H_Resource.Views;
using H_Resource.Models;
using System.Configuration;
using Accessibility;

namespace H_Resource
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //LoginView login = new LoginView();
            //login.ShowDialog();
            //if(login.DialogResult == DialogResult.OK)
            //{
            //    IMainContainer view = MainContainer.GetInstance();
            //    _ = new MainContainerPresenter(view);
            //}
            IMainContainer view = MainContainer.GetInstance();
            _ = new MainContainerPresenter(view);
        }
    }
}   