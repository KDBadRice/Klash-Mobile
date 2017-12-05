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
    class tourney
    {
        private int tourneynumber;
        private int adminNum;//admins will have the ability to create tourneys, which will be allocated via permissions
        private int playerCount;
        string tourneyName;
        public tourney(int playerCount, string tourneyName)
        {
            tourneyName = this.tourneyName;
            playerCount = this.playerCount;
        }
        public int getTourney()
        {
            return tourneynumber;
        }

        public void startTourney()
        { }

        public void endTourney()
        { }

        public void addWinToTeam(int nteamNum)
        { }

        public void addLossToTeam(int nteamNum)
        { }

        public void changeWin(int nteamNum, int newCount)
        { }

        public void changeLoss(int nteamNum, int newCount)
        { }

    }
}