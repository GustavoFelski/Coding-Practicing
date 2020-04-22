using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho
{
    public class FighterPosition
    {
        private object fighter;
        public object fighterUpdate {
            get { return fighter; }
            set { fighter = value; } 
        }
        private FighterPosition _NextFighter;

        public object NextFighterUpdate { 
            get { return NextFighterUpdate; } 
            set { NextFighterUpdate = value; }
        }

    }
}
