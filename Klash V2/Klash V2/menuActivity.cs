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
    [Activity(Label = "menuActivity")]
    public class menuActivity : Activity
    {
        private Button playerButton;
        private Button curLeagueButton;
        private Button scheduleButton;
        private Button teamButton;
        private dataConfig riotDataPull;
        private long playerID;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.menuActivity);

            riotDataPull = new dataConfig("123");
            playerID = riotDataPull.checkPlayer();
            findViews();

            playerButton.Click += delegate
            {
                playerRequest(1);
              
            };
            curLeagueButton.Click += delegate
            {
                leagueRequest(1);
            };
            scheduleButton.Click += delegate
            {
                scheduleRequest(1);
            };
            teamButton.Click += delegate
            {
                teamRequest(1);
            };
            // Create your application here
        }
        private void playerRequest(long playerId)
        {
            var getPlayerViewActivity = new Android.Content.Intent(this, typeof(playerViewActivity));
            getPlayerViewActivity.PutExtra("playerId", playerId);
            Console.WriteLine("player request");
            StartActivity(getPlayerViewActivity);
        }
        private void leagueRequest(int leagueId)
        {
            var getTourneyDataActivity = new Android.Content.Intent(this, typeof(tourneyDataActivity));
            getTourneyDataActivity.PutExtra("username", leagueId);
            Console.WriteLine("Current league request");
            StartActivity(getTourneyDataActivity);
        }
        private void scheduleRequest(int scheduleId)
        {
            var getScheduleActivity = new Android.Content.Intent(this, typeof(scheduleActivity));
            getScheduleActivity.PutExtra("username", scheduleId);
            Console.WriteLine("Schedule request");
            StartActivity(getScheduleActivity);
        }

        private void teamRequest(int teamId)
        {
            var getTeamActivity = new Android.Content.Intent(this, typeof(teamActivity));
            getTeamActivity.PutExtra("username", teamId);
            Console.WriteLine("Team Data request");
            StartActivity(getTeamActivity);
        }
        private void findViews()
        {
            playerButton = FindViewById<Button>(Resource.Id.playerData);
            teamButton = FindViewById<Button>(Resource.Id.teamData);
            scheduleButton = FindViewById<Button>(Resource.Id.scheduleButton);
            curLeagueButton = FindViewById<Button>(Resource.Id.tourneyData);

        }
    }
}