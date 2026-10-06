using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class Shipment
    {
        

        #region filds
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        #endregion

        #region propretis
        public string? Destination(DeliveryAddress deliveryAddress)
        {
            return $"{deliveryAddress.BuildingNumber},{deliveryAddress.Street},{deliveryAddress.City}";

        } 
        public  string  TrackingCode
        {
            get
            {
                return trackingCode ;
            }
           private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("the trackingCode is null or empty");
                else
                    trackingCode = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("the description is null or empty");
                else
                    description = value;
            }
        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value > 0 ?   value :  0;
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
           private set
            {
                deliveryFee = value > 0 ?  value : 0;
            }
        }
        public virtual decimal EstimatedCost
        {
            get
            {
                return  DeliveryFee + (Weight * 5);
            }
        }

        #endregion
        #region constractors
        
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Description = description;
        }
        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, default) { }

        #endregion

        #region methods
        public decimal UpdateDeliveryFee(decimal newFee)
        {
            return DeliveryFee = newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            Console.WriteLine("-----------------------------");
            
        }
        #endregion

    }
}
