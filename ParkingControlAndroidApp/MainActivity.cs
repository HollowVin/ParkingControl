using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Data;
using System;
using System.Web.Services.Description;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android;
using System.Collections.Generic;

namespace ParkingControlAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback
    {
        DataRowCollection rows;
        GoogleMap map;
        Dictionary<string, Marker> markers;

        public void OnMapReady(GoogleMap googleMap)
        {
            map = googleMap;
            ChangeLocationToCuenca();
            AddParkingSpotMarkers();
            map.UiSettings.MapToolbarEnabled = true;
        }

        private void ChangeLocationToCuenca()
        {
            if (map != null)
            {
                LatLng cuencaLocation = new LatLng(-2.8922671, -79.0244017);
                CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
                builder.Target(cuencaLocation);
                builder.Zoom(13);
                CameraPosition cameraPosition = builder.Build();
                CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);

                map.MoveCamera(cameraUpdate);
            }
        }

        private void AddParkingSpotMarkers()
        {
            foreach (DataRow row in rows)
            {
                MarkerOptions markerOptions = new MarkerOptions();
                double latitude = Convert.ToDouble(row.ItemArray[12].ToString());
                double longitude = Convert.ToDouble(row.ItemArray[13].ToString());
                markerOptions.SetPosition(new LatLng(latitude, longitude));
                markerOptions.SetTitle("Parqueadero " + row.ItemArray[1].ToString());

                Marker marker = map.AddMarker(markerOptions);
                markers.Add(row.ItemArray[0].ToString(), marker);
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            markers =  new Dictionary<string, Marker>();

            Spinner parkingSpotsSpinner = FindViewById<Spinner>(Resource.Id.spinner1);
            parkingSpotsSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Spinner_ItemSelected);

            var ServiceClient = new ParkingSpotsReference.ParkingSpotsService();
            DataSet ParkingSpots = ServiceClient.GetAllValues();

            MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFrag.GetMapAsync(this);

            rows = ParkingSpots.Tables[0].Rows;
            string[] parkingSpotNames = new string[rows.Count];

            for (int i = 0; i < rows.Count; i++)
            {
                parkingSpotNames[i] = rows[i].ItemArray[1].ToString();
                parkingSpotNames[i] += " - " + rows[i].ItemArray[3].ToString();
                parkingSpotNames[i] += " - " + rows[i].ItemArray[2].ToString();
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, parkingSpotNames);
            parkingSpotsSpinner.Adapter = adapter;
        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            TextView quarterHourValue = FindViewById<TextView>(Resource.Id.quarterHourValue);
            quarterHourValue.Text = "$" + rows[e.Position].ItemArray[4].ToString();

            TextView halfHourValue = FindViewById<TextView>(Resource.Id.halfHourValue);
            halfHourValue.Text = "$" + rows[e.Position].ItemArray[5].ToString();

            TextView hourValue = FindViewById<TextView>(Resource.Id.hourValue);
            hourValue.Text = "$" + rows[e.Position].ItemArray[6].ToString();

            TextView openDaysValue = FindViewById<TextView>(Resource.Id.openDaysValue);
            openDaysValue.Text = "De " + rows[e.Position].ItemArray[7].ToString() + " a " + rows[e.Position].ItemArray[8].ToString();

            TextView openHoursValue = FindViewById<TextView>(Resource.Id.openHoursValue);
            openHoursValue.Text = "De " + rows[e.Position].ItemArray[9].ToString() + " a " + rows[e.Position].ItemArray[10].ToString();

            Marker currentMarker = markers[rows[e.Position].ItemArray[0].ToString()];
            currentMarker.ShowInfoWindow();
            map.AnimateCamera(CameraUpdateFactory.NewLatLng(currentMarker.Position));
        }
    }
}

