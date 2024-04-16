using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

    public class Vehicle
    {
        private static int _id;

        public int Id { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }
        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 0)
                {
                    _year = value;
                }
            }
        }

        public Vehicle()
        {
            _id++;
            Id = _id;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Idisi:{Id} Marka: {Marka} - Model:  {Model} - Il : {Year}");
        }
    }
}