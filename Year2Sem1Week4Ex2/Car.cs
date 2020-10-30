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
            get { return engineSize; } //easy //if i dont understad code in future im just stupid af
            set { engineSize = value; }

        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"{Make}"); //why is it capital in ur code and when i put it in lower here it still works? //anyways why do we declare 2 strings with lower and upper cases

        }

        public override string ToString() //this is called when needed basically XD
        {
            return
                string.Format(Make);
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine(CurrentSpeed);
        }

    }
}
