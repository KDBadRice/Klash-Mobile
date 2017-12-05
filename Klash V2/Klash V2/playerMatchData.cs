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
    class playerMatchData
    {
        private string role;
        private string champion;
        private int summonerId;
        private int killCount;
        private int deathCount;
        private int assistCount;
        public playerMatchData(string nRole, string nChampion, int nSummonerId, int nKillcount, int nDeathCount, int nAssistCount)
        {
            role = nRole;
            champion = nChampion;
            summonerId = nSummonerId;
            killCount = nKillcount;
            deathCount = nDeathCount;
            assistCount = nAssistCount;
        }
        public string getRole()
        {
            return role;
        }

        public string getChampion()
        {
            return champion;
        }

        public int getSummonerId()
        {
            return summonerId;
        }

        public int getKillCount()
        {
            return killCount;
        }

        public int getDeathCount()
        {
            return deathCount;
        }

        public int getAssistCount()
        {
            return assistCount;
        }
    }
}
