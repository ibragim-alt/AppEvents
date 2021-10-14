using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvents
{
    class Helper
    {
        public static EventContainer s_modelEventsContainer;

        public static EventContainer GetContext()
        {
            if (s_modelEventsContainer==null)
            {
                s_modelEventsContainer = new EventContainer();
            }
            return s_modelEventsContainer;

        }
    }
}
