using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace GuiFrameWork
{
    public struct LocationData
    {
        public string latitude;
        public string longitude;
    }


    public class LocationService : GeoCoordinateWatcher
    {
        private GeoCoordinateWatcher watcher;

        public LocationData StartLocationWatcher()
        {
            LocationData ld = new LocationData();

            // The watcher variable was previously declared as type GeoCoordinateWatcher.
            if (watcher == null)
            {
                watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            }

            watcher.MovementThreshold = 20; // Use MovementThreshold to ignore noise in the signal.

            watcher.StatusChanged += (o, args) =>
            {
                switch (args.Status)
                {
                    case GeoPositionStatus.Ready:
                        // Use the Position property of the GeoCoordinateWatcher object to get the current location.
                        GeoCoordinate co = watcher.Position.Location;

                        ld.latitude = co.Latitude.ToString("0.00");
                        ld.longitude = co.Longitude.ToString("0.00");

                        //Stop the Location Service to conserve battery power.

                        watcher.Stop();
                        break;
                }
            };

            watcher.Start();
            return ld; //need to return this to the calling method, with latitude and longitude data taken from GeoCoordinateWatcher
        }
    }
}
