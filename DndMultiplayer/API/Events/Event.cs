using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.API.Events
{
    public abstract class Event
    {
        private readonly string _message;
        private readonly string _type;

        public Event(string message, string type)
        {
            _message = message;
            _type = type;
        }
    }

    public class InputEvent: Event
    {

    }

    public class InitializeEvent: Event
    {

    }
}
