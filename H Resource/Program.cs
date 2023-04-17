
using H_Resource._Repositories;
using H_Resource.Presenters;
using H_Resource.Views;
using H_Resource.Models;
using System.Configuration;

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
            IMainContainer view = MainContainer.GetInstance();
            _ = new MainContainerPresenter(view);
            Application.Run((Form)view);
        }
    }
}   