using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elevator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int floor;
            Random a = new Random();
            int currentFloor = a.Next() % 20;
            Console.WriteLine("Floor " + currentFloor);
            Console.WriteLine("Enter your choice:");
            floor = Convert.ToInt32(Console.ReadLine());
            
            while (floor != currentFloor)
            {
                if(floor > currentFloor)
                { 
                    currentFloor++;
                }
                else
                {
                    currentFloor--;
                }
                
            }
            Console.WriteLine("You arrived floor " + currentFloor);
            Console.ReadKey();
        }
       
    }
}
