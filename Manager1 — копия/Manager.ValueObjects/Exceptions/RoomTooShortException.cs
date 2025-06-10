using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class RoomTooShortException : ArgumentException
    {
        public string Room { get; }
        public int MinLength { get; }

        public RoomTooShortException(string room, int minLength)
            : base($"Room number '{room}' is shorter than the minimum required length of {minLength}.")
        {
            Room = room;
            MinLength = minLength;
        }
    }

}
