using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Interfaces
{
    using ViewModel;
   public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
