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
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion
        #region methods
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
        #endregion
    }
}
