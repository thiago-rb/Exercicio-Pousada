using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rooms will be rented? ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            Rooms[] vect = new Rooms[10];
            for (int i = 0; i < numberOfStudents; i++)
            {
                int rent = i + 1;
                Console.WriteLine();
                Console.WriteLine("Rent " + rent);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("email: ");
                string email = Console.ReadLine();
                Console.Write("Choose a room (1-10): ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();


                if (roomNumber < 1 || roomNumber > 10)
                {
                    Console.WriteLine("Invalid room number. Please choose a room between 1 and 10.");
                    i--;
                }
                else if (vect[roomNumber] != null)
                {
                    Console.WriteLine("Room " + roomNumber + " is already occupied. Please choose another room.");
                    i--;
                }
                else
                {
                    vect[roomNumber] = new Rooms(name, email, roomNumber);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            }
        }
    }
}
