using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class car
    {
        public string Name
        { get; set; }

        public string Color
        { get; set; }

        public string Model
        { get; set; }

        public string Variant
        { get; set; }

        public string Details
        { get; set; }

        public string getCarDescription(string carname)
        {
            string desc = "0";
            if (carname == "Toyota")
            {
                desc = "Tito Car";
            }
            if (carname == "Mitsubishi")
            {
                desc = "Sad Boy Car";
            }

            return desc; 
        }


    }
}
