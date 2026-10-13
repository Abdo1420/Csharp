using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public abstract partial class Shipment
    {
        #region filds
        public static int TotalShipmentsCreated;
        public string TrackinCodeStutus;

        #endregion
        #region methods
        
        public abstract Shipment CopyShipment();
        //عند اسناد نسخة من الاوبجيكت الاصلي فان النسخة ستحمل نفس عنوان الاوبجيكت الاصلي واي  تغير في القيم بينهم سينعكس علي الاوبجيكت الاخر 
        //اما اذا اخذنا نسخة فعلية من الاوبجيكت فان كل اوبجيكت سينفصل عن الاخر ويكون مستقبل بقيمه بحيث اي تغير في القيم لا ينعكس في الاوبجيكت الاخر
        public abstract Shipment ShallowCopy();
        public abstract Shipment DeepCopy();
        public static string GetTotalShipmentsCreated()
        {
            return $"Total Shipments Created : {TotalShipmentsCreated}";
        }
        public partial void OnTrackingStatusChanged(string newStatus)
        {
            TrackinCodeStutus = newStatus;
            Console.WriteLine($"Tracking status changed to {TrackinCodeStutus}");
        }
        #endregion
    }
}
