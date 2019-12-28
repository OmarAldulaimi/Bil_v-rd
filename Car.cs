using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_vård
{
    class Car
    {
        private int id;
        private string carModel;
        private string regNbr;
        private string friText;
       

        public Car() { }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }

        public string RegNbr
        {
            get { return regNbr; }
            set { regNbr = value; }
        }
        public string FriText
        {
            get { return friText; }
            set { friText = value; }
        }
    }
}
