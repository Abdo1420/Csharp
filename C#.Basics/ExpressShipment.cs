using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;
        #region proprtis
        public decimal ExtraFee { get; set; }=0;
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }

        #endregion
        #region constractor
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, decimal extraFee) : base(trackingCode, description, weight, deliveryFee,default)
        {
            ExtraFee = extraFee;
        }
        #endregion
        #region methods
        public override void PrintShipment()
        {
            Console.WriteLine("-----------------------------");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
        #endregion
    }
}
