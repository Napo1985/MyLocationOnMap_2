namespace GuiFrameWork
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private delegate void InitializeComponentHandle ();
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.myLocation_Btn = new System.Windows.Forms.Button();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streatLabel = new System.Windows.Forms.Label();
            this.streatTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.mapGmap = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.myLocation_Btn);
            this.splitContainer1.Panel1.Controls.Add(this.zipLabel);
            this.splitContainer1.Panel1.Controls.Add(this.stateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.streatLabel);
            this.splitContainer1.Panel1.Controls.Add(this.streatTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.zipTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.stateTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.cityTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.search_btn);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapGmap);
            this.splitContainer1.Size = new System.Drawing.Size(1275, 569);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 2;
            // 
            // myLocation_Btn
            // 
            this.myLocation_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLocation_Btn.Image = global::GuiFrameWork.Properties.Resources.myLocationPic;
            this.myLocation_Btn.Location = new System.Drawing.Point(221, 357);
            this.myLocation_Btn.Name = "myLocation_Btn";
            this.myLocation_Btn.Size = new System.Drawing.Size(193, 188);
            this.myLocation_Btn.TabIndex = 10;
            this.myLocation_Btn.Text = "My location";
            this.myLocation_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.myLocation_Btn.UseVisualStyleBackColor = true;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(31, 196);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(45, 25);
            this.zipLabel.TabIndex = 9;
            this.zipLabel.Text = "ZIP";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(27, 136);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(63, 25);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(26, 78);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(50, 25);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City";
            // 
            // streatLabel
            // 
            this.streatLabel.AutoSize = true;
            this.streatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streatLabel.Location = new System.Drawing.Point(27, 29);
            this.streatLabel.Name = "streatLabel";
            this.streatLabel.Size = new System.Drawing.Size(63, 24);
            this.streatLabel.TabIndex = 6;
            this.streatLabel.Text = "Streat";
            // 
            // streatTextBox
            // 
            this.streatTextBox.Location = new System.Drawing.Point(115, 29);
            this.streatTextBox.Name = "streatTextBox";
            this.streatTextBox.Size = new System.Drawing.Size(100, 30);
            this.streatTextBox.TabIndex = 5;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(115, 196);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 30);
            this.zipTextBox.TabIndex = 4;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(115, 133);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 30);
            this.stateTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(115, 78);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 30);
            this.cityTextBox.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Image = global::GuiFrameWork.Properties.Resources.SearchBtnPic;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_btn.Location = new System.Drawing.Point(3, 357);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(212, 188);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // mapGmap
            // 
            this.mapGmap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mapGmap.Bearing = 0F;
            this.mapGmap.CanDragMap = true;
            this.mapGmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapGmap.GrayScaleMode = false;
            this.mapGmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapGmap.LevelsKeepInMemmory = 5;
            this.mapGmap.Location = new System.Drawing.Point(3, 3);
            this.mapGmap.MarkersEnabled = true;
            this.mapGmap.MaxZoom = 18;
            this.mapGmap.MinZoom = 2;
            this.mapGmap.MouseWheelZoomEnabled = true;
            this.mapGmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapGmap.Name = "mapGmap";
            this.mapGmap.NegativeMode = false;
            this.mapGmap.PolygonsEnabled = true;
            this.mapGmap.RetryLoadTile = 0;
            this.mapGmap.RoutesEnabled = true;
            this.mapGmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapGmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapGmap.ShowTileGridLines = false;
            this.mapGmap.Size = new System.Drawing.Size(841, 563);
            this.mapGmap.TabIndex = 0;
            this.mapGmap.Zoom = 18D;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 569);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MapForm";
            this.Text = "MapGmap";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streatLabel;
        private System.Windows.Forms.TextBox streatTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private GMap.NET.WindowsForms.GMapControl mapGmap;
        private System.Windows.Forms.Button myLocation_Btn;
    }
}