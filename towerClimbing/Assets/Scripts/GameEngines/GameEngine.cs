using Assets.Scripts.DataBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.GameEngines
{
    public class GameEngine
    {
        public static Level Level
        {
            get; private set;
        }


        public static void SetLevel(Level level)
        {
            Level = level;
        }
    }
}
