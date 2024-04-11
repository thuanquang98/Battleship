using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.API.Events
{
    public abstract class GameEvent
    {
        public abstract string ToString();
    }

    public class CommandEvent: GameEvent
    {
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    public class CoordinateEvent : GameEvent
    {

        private readonly string coordinate;
        public CoordinateEvent(string coordinate)
        {
            this.coordinate = coordinate;
        }
        public override string ToString()
        {
            return "Sent Coordinate: " + coordinate;
        }
    }

    public class StopEvent : GameEvent
    {
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
