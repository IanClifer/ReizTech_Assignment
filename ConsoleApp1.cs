using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hours (0-11): ");      //This part read the user's input and use int.Parse
            int hours = int.Parse(Console.ReadLine());  //to convert it to an integer.

            Console.Write("Enter minutes (0-59): ");        //Same as the above but for minutes.
            int minutes = int.Parse(Console.ReadLine());    //Both need to start from 0 because the clock start from 0.

            double minuteAngle = minutes * 6;                   //This part took me a while. It's my first time messing with shapes in programming.
            double hourAngle = (hours + (minutes / 60)) * 30;   //But this is exciting enough to not use google and use only my brain to figure this out.
                                                                //I had to divide 360 (circle) into 60 (the minutes) to find the exact angles per minute.
                                                                //Same for the hours. Had to divide by 30. I needed to divide the minutes into 60 and add it to hours.
                                                                //That way I can find the exact position of the hour arm since the arm moves constantly too while the minute arm moves.
                                                                //So if it's 3:30 this formula will give me 3.5 which is the exact position of the hour arm at that point in time.

            double angle = Math.Abs(minuteAngle - hourAngle);   //This is the first time I used this Math.Abs method. I learned (through google) that this can be used
                                                                //to return the positive value of any number you feed to its parameter.

            if (angle > 180)            //So there are two angles that can be calculated.
            {                           //This make sure to always calculate the lesser angle.
                angle = 360 - angle;
            }

            Console.Write("The angle is: " + angle);    //Output the result.
        }
    }
}
