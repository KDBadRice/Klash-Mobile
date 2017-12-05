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
    class match
    {
        private int gameNum; //linked to riot API match data
        private int tourneyNum; //linked to tournament specific object for reference in app
        private playerMatchData[] blueTeam;
        private playerMatchData[] redTeam;

        public match(int nGamenum, int nTourneyNum)
        {
            gameNum = nGamenum;
            tourneyNum = nTourneyNum;
            blueTeam = new playerMatchData[5];
            redTeam = new playerMatchData[5];
        }
    }
}