using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class Driver
    {
        #region Property
       public string? Name { get; set; }
        public DeliveryCenter? AssignedCenter { get; set; }
        #endregion
        #region constractor
        public  Driver(string name)
        {
            this.Name = name;
        }
        #endregion

    }
}
