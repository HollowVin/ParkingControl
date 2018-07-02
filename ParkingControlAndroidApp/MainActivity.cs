using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Data;

namespace ParkingControlAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Spinner parkingSpotsSpinner = FindViewById<Spinner>(Resource.Id.spinner1);

            var ServiceClient = new ParkingSpotsWebReference.ParkingSpotsService();
            DataSet ParkingSpots = ServiceClient.GetAllValues();
            DataRowCollection Rows = ParkingSpots.Tables[0].Rows;
            string[] parkingSpotNames = new string[Rows.Count];

            for (int i = 0; i < Rows.Count; i++)
            {
                parkingSpotNames[i] = Rows[i].ItemArray[1].ToString();
                parkingSpotNames[i] += " - " + Rows[i].ItemArray[2].ToString();
                parkingSpotNames[i] += " - " + Rows[i].ItemArray[3].ToString();
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, parkingSpotNames);
            parkingSpotsSpinner.Adapter = adapter;
        }
    }
}

