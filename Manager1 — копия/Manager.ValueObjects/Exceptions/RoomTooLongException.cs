using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class RoomTooLongException : ArgumentException
    {
        public string Room { get; }
        public int MaxLength { get; }

        public RoomTooLongException(string room, int maxLength)
            : base($"Room number '{room}' exceeds the maximum allowed length of {maxLength}.")
        {
            Room = room;
            MaxLength = maxLength;
        }
    }

}
