using System;
namespace Solving_Ackley_Function_using_HillClimbing_Method__C__
{

    public class Program
    {
        static Random rand = new Random();

        /** function zir 2 voroody(coordinate) x,y ra gerefte va fasele an ba noghte
         global minimum ke x,y=(0,0) ast ra return mikonad [function returns 0 at (0,0) point (global minimum)] **/

        static double Ackley(double x, double y)
        {
            double a = -20 * Math.Exp(-0.2 * Math.Sqrt(0.5 * (x * x + y * y)));
            double b = -Math.Exp(0.5 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y)));
            return a + b + Math.E + 20;
        }

        static void Main()
        {
            double x = rand.NextDouble() - 0.5;
            double y = rand.NextDouble() - 0.5; //generating a random point
            double BehtarinMeghdar = Ackley(x, y); //measuring the distance using the Ackley Function


            int TedadCheck = 0; //check counter

            for( ;TedadCheck<100 ;TedadCheck++)
            {
                double stepsize = rand.NextDouble(); //generating a random stepsize each time
                double newx = x * stepsize; 
                double newy = y * stepsize; //generating a new random point by using the random stepsize
                //you can also use + instead of * in above lines , but the answer will be greater due to limited exploration

                double newvalue = Ackley(newx, newy); //measuring the distance of new generated point using Ackley Function

                if (newvalue < BehtarinMeghdar) //checking if the new point is closer to global minimum and replacing it if true

                {
                    x = newx;
                    y = newy;
                    BehtarinMeghdar = newvalue; 
                }
            }

            int Xcoordinate = Convert.ToInt32(x);
            int Ycoordinate = Convert.ToInt32(y);
            int BestValueInt = Convert.ToInt32(BehtarinMeghdar);
            
            //Alireza Timas

            Console.WriteLine($"Noghte Global Minimum Ackley Function:({Xcoordinate},{Ycoordinate})"); //global minimum coordiantes
            Console.WriteLine($"Behtarin Value Daryafti az Ackley:{BehtarinMeghdar} ≈ {BestValueInt}");
            Console.WriteLine($"Tedad Check noghat Hamsaye:{TedadCheck}");
            Console.ReadKey();
        }

    }

}
