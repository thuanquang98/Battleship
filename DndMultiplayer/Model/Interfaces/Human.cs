﻿using BattleshipMultiplayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipMultiplayer
{
    public interface Human
    {
        public void SetAnswer();
        public void GameOver();
    }
}
