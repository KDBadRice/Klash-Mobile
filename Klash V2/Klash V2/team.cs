using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Klash_V2
{
    class team
    {
        private int teamID;
        private int winCount;
        private int lossCount;
        private player[] playerArray = new player[6];

        public void addWin()
        {
            winCount++; //add data base win increase
        }
        public void addLoss()
        {
            lossCount++; //add database loss increase
        }
        public void setWinCount(int newWinCount)  //custom set win count via tourney admin
        {
            winCount = newWinCount;
        }
        public void setLossCount(int newLossCount) //custom set loss count via tourney admin
        {
            lossCount = newLossCount;
        }
    }

}