using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public struct DeliveryCenter
    {
        #region atributs
        private Shipment[] array;
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
                return default;
            }
        }
        #endregion
        public bool AddShipment(Shipment newShipment)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].TrackingCode == default)
                {
                    array[i] = newShipment;
                    return true;
                }
            }
            return false;
        }
    }
}
