using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public class DogSound : ISound<Animals>
    {
        
       

        public void setSound(Animals item)
        {
            Console.WriteLine($"Sound = {item.Sound}");
        }
    }
}
