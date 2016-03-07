using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker_rmk.Model
{
    class EventCatalogSingleton
    {
        private static readonly EventCatalogSingleton _instance = new EventCatalogSingleton();
        
        public ObservableCollection<MyEvent> EventListe { get; set; }
        public static EventCatalogSingleton Instance
        {
            get
            {
                return _instance;
            }
        }
        public EventCatalogSingleton()
        {
            EventListe = new ObservableCollection<MyEvent>()
            {
                new MyEvent("Event1","description1","place1",new DateTime(2016,07,03,14,30,00)),
                new MyEvent("Event2", "description2", "place2", new DateTime(2016, 07, 03, 14, 30, 00)),
                new MyEvent("Event3", "description3", "place3", new DateTime(2016, 07, 03, 14, 30, 00))
            }
            ;
        }

        public void AddEvent(MyEvent myEventAdd)
        {
            EventListe.Add(myEventAdd);
        }
    }
}
