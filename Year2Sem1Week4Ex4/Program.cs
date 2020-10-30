using System;

namespace Year2Sem1Week4Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1, lunch2, lunch3, lunch4, lunch5; //im not sure about this
            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Entree = "Burger";
            lunch1.Side = "Fries";
            lunch1.Drink = "Coke";

            lunch2.Entree = "Burger";
            lunch2.Side = "Fries";
            lunch2.Drink = "Coke";

            lunch3.Entree = "Burger";
            lunch3.Side = "Fries";
            lunch3.Drink = "Coke";

            lunch4.Entree = "Burger";
            lunch4.Side = "Fries";
            lunch4.Drink = "Coke";

            lunch5.Entree = "Burger";
            lunch5.Side = "Fries";
            lunch5.Drink = "Coke";



            Display(lunch1,lunch2,lunch5); //Lunch[] lunches takes in all these // lunch1 contains entree side drink (remember)





        }
        static void Display(params Lunch[] lunches) //if i wanna display only 3 sets of lunches it displays 3 if i wanna display 5 it displays 5, its basically flexible, the params thing is
        {
            Console.WriteLine("{0,-24}{1,-12}{2,-10}","Entree", "Sides", "Drink");

            foreach (Lunch lunch in lunches) //lunches contains lunch1 lunch2 and lunch 5 remember and for each lunch1.. lunch2 ets display each of lunches1.. 2.. values //for each element in the array display all of the elements values // in whatever format it says// easy
            {
                Console.WriteLine("{0,-24}{1,-12}{2,-10}", lunch.Entree, lunch.Side, lunch.Drink); //lunch1.Entree ... etc (foreach)
            }
        }
        
    }
    public class Lunch
    {
        public string Entree { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }
    }
}
