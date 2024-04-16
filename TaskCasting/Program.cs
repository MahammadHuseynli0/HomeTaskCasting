using Core.Models;

namespace TaskCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Marka = "Toyota";
            car1.Model = "Prado";
            car1.Year = 2018;
            car1.PassangerCapacity = 7;

            Car car2 = new Car();
            car2.Marka = "Mercedes";
            car2.Model = "Maybach";
            car2.Year = 2023;
            car2.PassangerCapacity = 7;



            Truck truck1 = new Truck();
            truck1.Marka = "Ford";
            truck1.Model = "Ranger";
            truck1.Year = 2020;
            truck1.CarryingCapacity = 1327;

            Truck truck2 = new Truck();
            truck2.Marka = "Toyota";
            truck2.Model = "Tundra";
            truck2.Year = 2022;
            truck2.CarryingCapacity = 900;

            Truck truck3 = new Truck();
            truck3.Marka = "Chevlorate";
            truck3.Model = "Colorado";
            truck3.Year = 2023;
            truck3.CarryingCapacity = 800;

            Truck truck4 = new Truck();
            truck4.Marka = "Hundai";
            truck4.Model = "SantaCruz";
            truck4.Year = 2023;
            truck4.CarryingCapacity = 700;

            RentCar rentcar = new RentCar();
            rentcar.CarLimit = 3;
            rentcar.TruckLimit = 2;

            rentcar.AddVehicle(car1);
            rentcar.AddVehicle(car2);
            rentcar.AddVehicle(truck1);
            rentcar.AddVehicle(truck2);
            rentcar.AddVehicle(truck3);
            rentcar.AddVehicle(truck4);


            car1.ShowInfo();
            car2.ShowInfo();
            truck1.ShowInfo();
            truck2.ShowInfo();
            truck3.ShowInfo();
            truck4.ShowInfo();


            rentcar.ShowAllVehicles();






            




        }
    }
}
