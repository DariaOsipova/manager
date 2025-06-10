using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class RoomInvalidCharactersException : FormatException
    {
        public string Room { get; }

        public RoomInvalidCharactersException(string room)
            : base($"Room number '{room}' contains invalid characters. Only letters, digits, and '-' are allowed.")
        {
            Room = room;
        }
    }

}
