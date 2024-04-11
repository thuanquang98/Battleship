﻿using BattleshipMultiplayer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    public interface IPlayable
    {
        public void PlayMove();
        public void SetInfo(IController game);
    }
}
