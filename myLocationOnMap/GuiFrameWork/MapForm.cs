using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET.WindowsForms;

namespace GuiFrameWork
{
    public partial class MapForm : Form
    {
        #region Properties

        #region Buttons
        public Button SearchBtn
        {
            get { return search_btn; }
        }

        public Button MyLocationBtn
        {
            get { return myLocation_Btn; }
        }
        #endregion

        #region Labels

        public Label StreatLabel
        {
            get { return streatLabel; }
        }

        public Label CityLabel
        {
            get { return cityLabel; }
        }

        public Label StateLabel
        {
            get { return stateLabel; }
        }

        public Label ZipLabel
        {
            get { return zipLabel; }
        }
        #endregion
        
        #region TextBoxs

        public TextBox StreatTextBox
        {
            get { return streatTextBox; }
        }

        public TextBox CityTextBox
        {
            get { return cityTextBox; }
        }

        public TextBox StateTextBox
        {
            get { return stateTextBox; }
        }

        public TextBox ZipTextBox
        {
            get { return zipTextBox; }
        }

        public SplitContainer SplitContainer1
        {
            get { return splitContainer1 ; }
        }

        public GMapControl MapGmap
        {
            get { return mapGmap; }
        }


        #endregion

        #endregion

        public MapForm()
        {
            InitializeComponent();
        }
    }
}
