using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho
{
    class CombateRank
    {
        private FighterPosition _first, _next, _Aux;
        private int size;
        public int getSize { get { return this.size; } }

        public CombateRank()
        {
            this.size = 0;
            this._first = new FighterPosition();
            this._first.fighterUpdate = null;
            this._first.NextFighterUpdate = null;
            _next = _first;
        }

        public bool combateRankEmpty() {
            return _next == _first;
        }

        public void push(object fighter) 
        {
            FighterPosition fighterPosition = new FighterPosition();
            fighterPosition.fighterUpdate = fighter;
            
            if(_next == _first)
            {
                _first = fighterPosition;
            }
            else
            {
                _next = fighterPosition;
            }

            _next = fighterPosition;

        }

    }
}
