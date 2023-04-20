﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Resource.Views
{
    public interface IHomeView
    {
        event EventHandler<EventArgs> ShowEmployeesView;
        event EventHandler<EventArgs> ShowVacationView;
        event EventHandler<EventArgs> ShowPayrollView;

        void Show();
        void Close();

    }
}
