using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        Vehicle[] _vehicles = new Car[] { };
        Truck[] _trucks = new Truck[] { };
        Car[] _cars = new Car[] { };
        public int CarLimit { get; set; }

        public int TruckLimit { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                if (_cars.Length < CarLimit)
                {

                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = (Car)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Car limiti asilib");
                }
            }
            if (vehicle is Truck)
            {
                if (_trucks.Length < TruckLimit)
                {

                    Array.Resize(ref _trucks, _trucks.Length + 1);
                    _trucks[_trucks.Length - 1] = (Truck)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Truck limiti asilib");
                }
            }
        }
        public void ShowAllVehicles()
        {

            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] is Car)
                {
                    var car = (Car)_vehicles[i];
                    Console.WriteLine($"Sernişin tutumu:{car.PassangerCapacity} Marka:{car.Marka}  Modeli:{car.Model} Ili:{car.Year}");
                }
                else if (_vehicles[i] is Truck)
                {
                    var truck = (Truck)_vehicles[i];

                    Console.WriteLine($"Yük daşıma qabilyeti:{truck.CarryingCapacity}ton  Marka:{truck.Marka}  Modeli:{truck.Model} Ili:{truck.Year} ");
                }
            }
        }





    }
}
