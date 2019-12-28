using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_vård
{
    class Controller
    {
        private List<Car> carList;
        


    public Controller()
    {
            this.carList = new List<Car>();
            this.carList.Add(new Car() { Id = 1, CarModel = "KIA", RegNbr = "FHO236", FriText = "Helrekond" });
            foreach (Car car in carList)
            {
                Console.WriteLine($"Car: {car.FriText}");
            }

        }
    
}
}
