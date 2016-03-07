using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using EventMaker_rmk.Converter;
using EventMaker_rmk.Model;
using EventMaker_rmk.View;
using EventMaker_rmk.ViewModel;

namespace EventMaker_rmk.Handler
{
    class EventHandler
    {
        public EventViewModel EventVM { get; set; }

        public EventHandler(EventViewModel eventVm)
        {
            EventVM = eventVm;
        }

        public void CreateEvent()
        {
            var date = DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventVM.Date, EventVM.Time);
            EventVM.Catalog.AddEvent(new MyEvent(EventVM.Name,EventVM.Description,EventVM.Place,date));
            ((Frame)Window.Current.Content).Navigate(typeof(View.CreateEventPage));
        }
    }
}
