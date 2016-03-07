using System;
using System.Windows.Input;
using Eventmaker.Common;
using EventMaker_rmk.Model;
using EventHandler = EventMaker_rmk.Handler.EventHandler;

namespace EventMaker_rmk.ViewModel
{
    class EventViewModel
    {
        private DateTimeOffset _date;
        private TimeSpan _time;
        private ICommand _createEventCommand;
        public EventCatalogSingleton Catalog { get; } = EventCatalogSingleton.Instance;
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Place { get; set; }
        public Handler.EventHandler EventHandler { get; set; }
        public ICommand CreateEventCommand
        {
            get
            {
                return _createEventCommand ??
                (_createEventCommand = new RelayCommand(EventHandler.CreateEvent));
            }

        }
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

        public EventViewModel()
        {
            EventHandler = new Handler.EventHandler(this);
            DateTime dt = System.DateTime.Now;

            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
        }
    }
}
