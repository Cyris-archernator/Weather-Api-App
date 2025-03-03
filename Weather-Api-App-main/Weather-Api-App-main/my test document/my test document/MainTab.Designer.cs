namespace my_test_document
{
    partial class MainTab
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTab));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnreview = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tempreture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WindSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(650, 444);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(73, 34);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnreview
            // 
            this.btnreview.Location = new System.Drawing.Point(12, 349);
            this.btnreview.Name = "btnreview";
            this.btnreview.Size = new System.Drawing.Size(179, 34);
            this.btnreview.TabIndex = 9;
            this.btnreview.Text = "Review";
            this.btnreview.UseVisualStyleBackColor = true;
            this.btnreview.Click += new System.EventHandler(this.btnreview_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 323);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(179, 20);
            this.txtLocation.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Location";
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day,
            this.Time,
            this.Tempreture,
            this.WindSpeed,
            this.Rain});
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 59);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(550, 240);
            this.list.TabIndex = 12;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Tempreture
            // 
            this.Tempreture.Text = "Tempreture";
            this.Tempreture.Width = 74;
            // 
            // WindSpeed
            // 
            this.WindSpeed.Text = "Wind speed";
            this.WindSpeed.Width = 71;
            // 
            // Rain
            // 
            this.Rain.Text = "Rain chance";
            this.Rain.Width = 76;
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(735, 490);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnreview);
            this.Controls.Add(this.btnLogOut);
            this.Name = "MainTab";
            this.Text = "MainTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnreview;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Tempreture;
        private System.Windows.Forms.ColumnHeader WindSpeed;
        private System.Windows.Forms.ColumnHeader Rain;
    }
}