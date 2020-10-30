using System;
using System.Collections.Generic;
using System.Text;

namespace Year2Sem1Week4Ex1
{
    class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }

        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }

        }


        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }

        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }

        }
    }
}
