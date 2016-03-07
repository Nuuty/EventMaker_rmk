using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker_rmk.Model
{
    class Event
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Place { get; set; }
        public DateTime DateTime { get; set; }
        private static int _idcounter;

        public Event(string name, string description, string place, DateTime dateTime)
        {
            Id = ++_idcounter;
            Name = name;
            Description = description;
            Place = place;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Place: {Place}, DateTime: {DateTime}";
        }
    }
}
