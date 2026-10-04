using System.Numerics;
using static System.Console;
namespace C_.Basics
{
    public struct DeliveryAddress
    {

        #region fields and Conistractor
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion
        #region Methods
        public void GetFullAddress()
        {
            WriteLine ($"{BuildingNumber},{Street},in {City}");
        }
        #endregion

    }
}
