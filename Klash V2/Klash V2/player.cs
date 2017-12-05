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
    class player
    {
        private int playerID;
        private Boolean confirm;
        private string summonerName;
        private Array summonerNameList;



        public int getPlayerID()  // Method: Get player name
        {
            return playerID;
        }
        public void setPlayerID(string updatedName)
        {
            summonerName = updatedName;
        }

        public string getPlayerName()
        {
            return summonerName;
        }

        public void setPlayerName(string newPlayerName)
        {
            //build in validation
            //add verificication
            if (newPlayerName != summonerName)
            {
                //add to array
            }
            summonerName = newPlayerName;

        }


        public void confirmPlayer()
        {
            confirm = true;
        }

    }
}