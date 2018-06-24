using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Data;
using System;

namespace ParkingControlAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        DataRowCollection Rows;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Spinner parkingSpotsSpinner = FindViewById<Spinner>(Resource.Id.spinner1);
            parkingSpotsSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

            var ServiceClient = new ParkingSpotsWebReference.ParkingSpotsService();
            DataSet ParkingSpots = ServiceClient.GetAllValues();
            Rows = ParkingSpots.Tables[0].Rows;
            string[] parkingSpotNames = new string[Rows.Count];

            for (int i = 0; i < Rows.Count; i++)
            {
                parkingSpotNames[i] = Rows[i].ItemArray[1].ToString();
                parkingSpotNames[i] += " - " + Rows[i].ItemArray[3].ToString();
                parkingSpotNames[i] += " - " + Rows[i].ItemArray[2].ToString();
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, parkingSpotNames);
            parkingSpotsSpinner.Adapter = adapter;
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            TextView quarterHourValue = FindViewById<TextView>(Resource.Id.quarterHourValue);
            quarterHourValue.Text = "$" + Rows[e.Position].ItemArray[4].ToString();

            TextView halfHourValue = FindViewById<TextView>(Resource.Id.halfHourValue);
            halfHourValue.Text = "$" + Rows[e.Position].ItemArray[5].ToString();

            TextView hourValue = FindViewById<TextView>(Resource.Id.hourValue);
            hourValue.Text = "$" + Rows[e.Position].ItemArray[6].ToString();

            TextView openDaysValue = FindViewById<TextView>(Resource.Id.openDaysValue);
            openDaysValue.Text = "De " + Rows[e.Position].ItemArray[7].ToString() + " a " + Rows[e.Position].ItemArray[8].ToString();

            TextView openHoursValue = FindViewById<TextView>(Resource.Id.openHoursValue);
            openHoursValue.Text = "De " + Rows[e.Position].ItemArray[9].ToString() + " a " + Rows[e.Position].ItemArray[10].ToString();
        }
    }
}

