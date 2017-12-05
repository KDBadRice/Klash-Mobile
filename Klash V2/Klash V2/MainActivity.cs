using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Klash_V2
{
    [Activity(Label = "Klash_V2", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private Button loginBut;
        private EditText username;
        private EditText password;
        private Button guestLogin;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            findViews();

            loginBut.Click += delegate
            {
                //Get entered username & password
                string usr = username.Text;
                string pass = password.Text;

                //Get list of valid user-pass pairs
                string[,] users = getValidUsers();

                if (credentialsAreValid(usr, pass, users))
                {
                    submit(usr);
                }
                else
                {
                    //Tell the user that the login didn't work
                    var dialog = new AlertDialog.Builder(this);
                    dialog.SetTitle("Invalid Login");
                    dialog.SetMessage("The username-password pair you provided is invalid");
                    dialog.Show();
                }
            };

            guestLogin.Click += delegate
            {
                //Skips validation, submits w/ guest username
                submit("Guest@test.com");
            };

        }

        private bool credentialsAreValid(string usr, string pass, string[,] list)
        {
            bool result = false;

            for (int x = 0; x < list.GetLength(0); x += 1)
            {
                if (list[x, 0].Equals(usr) && list[x, 1].Equals(pass))   //If usr-pass pair matches...
                {
                    result = true;
                }
            }

            return result;
        }

        private string[,] getValidUsers()
        {
            //Initialize 2D string array w/ [x,0]=usr & [x,1]=pass
            string[,] list = new string[6, 2];

            //Begin hard code
            int i = 0;
            while (i < 6)
            {
                //list[1, 0] = String.Concat("user1");
                list[i, 0] = String.Concat("user", i.ToString());
                list[i, 1] = String.Concat("pass", i.ToString());

                i++;
            }
            //End hard code

            return list;
        }

        private void submit(string user)
        {
            var getMenuActivity = new Android.Content.Intent(this, typeof(menuActivity));
            //extras here
            char[] delimiterChar = { '@' };
            string[] usernameDelim = user.Split(delimiterChar);
            getMenuActivity.PutExtra("username", usernameDelim[0]);
            Console.WriteLine(usernameDelim);
            StartActivity(getMenuActivity);
        }

        //find views:
        private void findViews()
        {
            loginBut = FindViewById<Button>(Resource.Id.loginBut);
            username = FindViewById<EditText>(Resource.Id.username);
            password = FindViewById<EditText>(Resource.Id.password);
            guestLogin = FindViewById<Button>(Resource.Id.testLogin);
            
        }

        // Set our view from the "main" layout resource
        // SetContentView (Resource.Layout.Main);
    }
}


