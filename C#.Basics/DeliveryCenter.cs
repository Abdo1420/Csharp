using System;
using System.Collections.Generic;
using System.Text;


namespace C_.Basics
{
    public class DeliveryCenter
    {
        #region atributs
        private string CenterName;
        private Shipment[] array;
        #endregion

        #region constractor
        public DeliveryCenter()
        {
            CenterName = "Unknown Center";
            array = new Shipment[20];
        }
        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            array = new Shipment[20];
        } 
        #endregion

        #region indixer
        public Shipment this[int position]
        {
            get
            {
                if (position < array.Length && position >= 0)
                    return array[position];
                else
                    return default;

            }
            set
            {
                if (position < array.Length && position > 0)
                {
                    array[position] = value;
                }
            }
        } 
        public  Shipment this[string trackingCode]
        {
            get
            {
                for(int i = 0; i <array.Length; i++)
                {
                    if (trackingCode == array[i].TrackingCode)
                        return array[i];
                    
                  
                }
                return null;
            }
        }
        #endregion

        #region methods
        public bool AddShipment(Shipment newShipment)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == default && newShipment != default)
                {
                    array[i] = newShipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode) 
        { 
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].TrackingCode == trackingCode)
                {
                    array[i] = null;
                    return true;
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            
            for (int i = 0; i < array.Length; i++)
            {
               if(array[i] != null)
                {
                    array[i].PrintShipment();
                   
                }
            }
        }
        public void PrintCenterInfo()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"Center Name: {CenterName}");
            Console.WriteLine("==========================================");
        }
        #endregion
    }
}
