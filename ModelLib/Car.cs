using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Car
    {
        public string Model
        {
            get => model;
            set => model = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public string RegNo
        {
            get => regNo;
            set => regNo = value;
        }

        private string model;
        private string color;
        private string regNo;


        public override string ToString()
        {
            return "Model: " + model + " Color: " + color + " Reg.No: " + regNo;
        }
    }
}
