﻿using BattleshipMultiplayer.API.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer.API
{
    public interface GameListener
    {
        public void PlayerActionPerformed(GameEvent ev);
    }
}
