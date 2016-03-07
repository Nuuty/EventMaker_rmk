using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker_rmk.Model;

namespace EventMaker_rmk.ViewModel
{
    class EventViewModel
    {
        private DateTimeOffset _date;
        private TimeSpan _time;
        public EventCatalogSingleton Catalog { get; } = EventCatalogSingleton.Instance;
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Place { get; set; }

        public DateTimeOffset Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public EventViewModel(int id, string name, string description, string place, DateTimeOffset date, TimeSpan time)
        {
            Id = id;
            Name = name;
            Description = description;
            Place = place;
            Date = date;
            Time = time;
            DateTime dt = System.DateTime.Now;

            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }
    }
}
