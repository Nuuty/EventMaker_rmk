using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker_rmk.Model
{
    class MyEvent
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Place { get; set; }
        public DateTime DateTime { get; set; }
        private static int _idcounter;

        public MyEvent(string name, string description, string place, DateTime dateTime)
        {
            Id = ++_idcounter;
            Name = name;
            Description = description;
            Place = place;
            DateTime = dateTime;
        }

        protected bool Equals(MyEvent other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MyEvent) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Place: {Place}, DateTime: {DateTime}";
        }
    }
}
