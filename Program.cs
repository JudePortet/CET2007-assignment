using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CET2007_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    //class created for instancing rooms that are available (or not available depending)
    public class Room
    {
        private string roomDetails { get; set; }
        private int capacity { get; set; }
        private string[] equipment { get; set; }
        private string roomType { get; set; }

        public Room(string roomDetails, int capacity, string[] equipment, string roomType)
        {
            this.roomDetails = roomDetails;
            this.capacity = capacity;
            this.equipment = equipment;
            this.roomType = roomType;
        }

    }

    //class created for instancing staff members
    public class Staff
    {
        private int staffID { get; set; }
        private string name { get; set; }
        private string department { get; set; }

        public Staff(int staffID, string name, string department)
        {
            this.staffID = staffID;
            this.name = name;
            this.department = department;
        }

    }

    //class created for instancing bookings of the rooms by a staff member at a set time
    public class Booking
    {
        private Room room { get; set; }
        private Staff staffMember { get; set; }
        private DateTime date { get; set; }
        private DateTime startTime { get; set; }
        private DateTime endTime { get; set; }


        public Booking(Room room, Staff staffMember, DateTime date, DateTime startTime, DateTime endTime)
        {
            this.room = room;
            this.staffMember = staffMember;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }

    //class created for adding a teacher to a teaching session
    public class TeachingSession
    {
        private string module { get; set; }
        private int studentCount { get; set; }
        private string[] equipmentRequired { get; set; }

        public TeachingSession(string module, int studentCount, string[] equipmentRequired)
        {
            this.module = module;
            this.studentCount = studentCount;
            this.equipmentRequired = equipmentRequired;
        }

    }
}
