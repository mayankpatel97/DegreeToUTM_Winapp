namespace navik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_lat = new System.Windows.Forms.TextBox();
            this.textBox_lon = new System.Windows.Forms.TextBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.textBox_easting = new System.Windows.Forms.TextBox();
            this.textBox_northing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_zoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_zoneLetter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_lat
            // 
            this.textBox_lat.Location = new System.Drawing.Point(85, 52);
            this.textBox_lat.Name = "textBox_lat";
            this.textBox_lat.Size = new System.Drawing.Size(179, 27);
            this.textBox_lat.TabIndex = 0;
            this.textBox_lat.TextChanged += new System.EventHandler(this.textBox_lat_TextChanged);
            // 
            // textBox_lon
            // 
            this.textBox_lon.Location = new System.Drawing.Point(85, 106);
            this.textBox_lon.Name = "textBox_lon";
            this.textBox_lon.Size = new System.Drawing.Size(179, 27);
            this.textBox_lon.TabIndex = 1;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(85, 230);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(94, 29);
            this.button_convert.TabIndex = 2;
            this.button_convert.Text = "convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // textBox_easting
            // 
            this.textBox_easting.Location = new System.Drawing.Point(486, 52);
            this.textBox_easting.Name = "textBox_easting";
            this.textBox_easting.Size = new System.Drawing.Size(179, 27);
            this.textBox_easting.TabIndex = 3;
            this.textBox_easting.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_northing
            // 
            this.textBox_northing.Location = new System.Drawing.Point(486, 106);
            this.textBox_northing.Name = "textBox_northing";
            this.textBox_northing.Size = new System.Drawing.Size(179, 27);
            this.textBox_northing.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Easting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Northing";
            // 
            // textBox_zoneNumber
            // 
            this.textBox_zoneNumber.Location = new System.Drawing.Point(486, 168);
            this.textBox_zoneNumber.Name = "textBox_zoneNumber";
            this.textBox_zoneNumber.Size = new System.Drawing.Size(63, 27);
            this.textBox_zoneNumber.TabIndex = 9;
            this.textBox_zoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zone";
            // 
            // textBox_zoneLetter
            // 
            this.textBox_zoneLetter.Location = new System.Drawing.Point(555, 168);
            this.textBox_zoneLetter.Name = "textBox_zoneLetter";
            this.textBox_zoneLetter.Size = new System.Drawing.Size(63, 27);
            this.textBox_zoneLetter.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_zoneLetter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_zoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_northing);
            this.Controls.Add(this.textBox_easting);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.textBox_lon);
            this.Controls.Add(this.textBox_lat);
            this.Name = "Form1";
            this.Text = "UTM Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_lat;
        private TextBox textBox_lon;
        private Button button_convert;
        private TextBox textBox_easting;
        private TextBox textBox_northing;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_zoneNumber;
        private Label label5;
        private TextBox textBox_zoneLetter;
        private Button button1;
    }
}