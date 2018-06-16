using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GuiFrameWork
{
    public class MapModel
    {
        #region Members
        private static MapForm m_control;
        private LocationData m_currentLoction;
        
        #endregion


        #region Ctor
        public MapModel()
        {
            try
            {
                m_control = new MapForm();

                if (m_control != null)
                {
                    RegisterToEvents();
                    OnMyLocationClick(null, null);
                    m_control.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                
                System.Diagnostics.Debug.WriteLine("Form load failed");
                System.Diagnostics.Debug.WriteLine(string.Format("EX: "+ ex.Message));

            }
        }
        #endregion

        #region Methodes

        private void RegisterToEvents()
        {
            m_control.SearchBtn.Click += OnSearchClick;
            m_control.MyLocationBtn.Click += OnMyLocationClick;
        }

        private void initMap()
        {
            try
            {
                m_control.MapGmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            }
            catch (Exception ex)
            {

            }

        }

        private void SetMapToDefaultZoom ()
        {
            m_control.MapGmap.Zoom = 16;
        }

        private void OnMyLocationClick(object sender, EventArgs e)
        {
            try
            {
                initMap();
                SetMapToDefaultZoom();
                m_control.MapGmap.Position = new GMap.NET.PointLatLng(32.07984, 34.824838);
                m_control.MapGmap.ReloadMap();
            }
            catch (Exception ex )
            {

            }

        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            try
            {

                initMap();
                SetMapToDefaultZoom();
                LocationService gps = new LocationService();
                m_currentLoction = gps.StartLocationWatcher();

                StringBuilder myAddress = new StringBuilder();

                if (m_control.StreatTextBox.Text.ToString() != string.Empty)
                {
                    myAddress.Append(m_control.StreatTextBox.Text.ToString() + ",");
                }

                if (m_control.CityTextBox.Text.ToString() != string.Empty)
                {
                    myAddress.Append(m_control.CityTextBox.Text.ToString() + ",");
                }

                if (m_control.StateTextBox.Text.ToString() != string.Empty)
                {
                    myAddress.Append(m_control.StateTextBox.Text.ToString() + ",");
                }

                string myRequest = string.Format(m_control.CityTextBox.Text.ToString() + "," + m_control.StateTextBox.Text.ToString());
                m_control.MapGmap.SetPositionByKeywords(myAddress.ToString());

                //m_control.MapGmap.ReloadMap();
            }
            catch (Exception ex )
            {

            }


        }
        #endregion

        #region Methodes 
        #endregion

    }
}
