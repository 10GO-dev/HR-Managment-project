using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H_Resource.Views;

namespace H_Resource.Presenters
{
    public class MainContainerPresenter
    {
        private readonly IMainContainer mainContainer;

        public MainContainerPresenter(IMainContainer mainContainer)
        {
            this.mainContainer = mainContainer;
            this.mainContainer.ShowHomeView += ShowHomeView;
            Application.Run((Form)this.mainContainer);
        }

        private void ShowHomeView(object? sender, EventArgs e)
        {
            IHomeView view = HomeView.GetInstance((MainContainer)mainContainer);
            mainContainer.AddView((Form)view);
            this.mainContainer.ShowHomeView -= ShowHomeView;
            new HomePresenter(view);
        }
    }
}
