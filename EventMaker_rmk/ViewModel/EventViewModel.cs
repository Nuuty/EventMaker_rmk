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
        public EventCatalogSingleton Catalog { get; } = EventCatalogSingleton.Instance;
    }
}
