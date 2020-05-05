using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho
{
    class CombateRank
    {
        private List<object> rank = new List<object>();

        private void CreatingCombateRank()
        {


        }


        #region using Pedlock logic
        //private FighterPosition _first, _next, _Aux;
        //private int size;
        //public int getSize { get { return this.size; } }

        //public CombateRank()
        //{
        //    this.size = 0;
        //    this._first = new FighterPosition();
        //    this._first.fighterUpdate = null;
        //    this._first.NextFighterUpdate = _first;
        //    _next = _first;
        //}

        //public bool combateRankEmpty() {
        //    return _next == _first;
        //}
        #endregion
        public void push(object fighter) 
        {
            #region using pedlock logic
            //FighterPosition fighterPosition = new FighterPosition();
            //fighterPosition.fighterUpdate = fighter;

            ////Add first on list
            //if (combateRankEmpty())
            //{
            //    _first = fighterPosition;

            //}
            ////add next on list
            //else
            //{
            //    _next = fighterPosition;
            //}
            //_next.NextFighterUpdate = _first;
            //this.size++;
            #endregion
        }

    }
}
