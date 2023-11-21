using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExercicio
{
    internal class Rooms
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }

        public Rooms(string name, string email, int roomnumber)
        {
            Name = name;
            Email = email;
            RoomNumber = roomnumber;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }

}
