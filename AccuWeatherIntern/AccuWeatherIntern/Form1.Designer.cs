namespace AccuWeatherIntern
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.WindowsLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.CityCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelCityCode = new System.Windows.Forms.Panel();
            this.PanelLocation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TemperatureCRadioButton = new System.Windows.Forms.RadioButton();
            this.TemperatureFRadioButton = new System.Windows.Forms.RadioButton();
            this.PanelTemperature = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.HoursDropDown = new System.Windows.Forms.ComboBox();
            this.DaysComboBox = new System.Windows.Forms.ComboBox();
            this.GetForecastButton = new System.Windows.Forms.Button();
            this.HoursRadioButton = new System.Windows.Forms.RadioButton();
            this.DaysDropDown = new System.Windows.Forms.RadioButton();
            this.PanelForecast = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PanelCityCode.SuspendLayout();
            this.PanelLocation.SuspendLayout();
            this.PanelTemperature.SuspendLayout();
            this.PanelForecast.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // WindowsLocationRadioButton
            // 
            this.WindowsLocationRadioButton.AutoSize = true;
            this.WindowsLocationRadioButton.Checked = true;
            this.WindowsLocationRadioButton.Location = new System.Drawing.Point(16, 15);
            this.WindowsLocationRadioButton.Name = "WindowsLocationRadioButton";
            this.WindowsLocationRadioButton.Size = new System.Drawing.Size(85, 21);
            this.WindowsLocationRadioButton.TabIndex = 1;
            this.WindowsLocationRadioButton.TabStop = true;
            this.WindowsLocationRadioButton.Text = "Windows";
            this.WindowsLocationRadioButton.UseVisualStyleBackColor = true;
            this.WindowsLocationRadioButton.CheckedChanged += new System.EventHandler(this.windowsLocationRadioButton_CheckedChanged);
            // 
            // CustomLocationRadioButton
            // 
            this.CustomLocationRadioButton.AutoSize = true;
            this.CustomLocationRadioButton.Location = new System.Drawing.Point(122, 14);
            this.CustomLocationRadioButton.Name = "CustomLocationRadioButton";
            this.CustomLocationRadioButton.Size = new System.Drawing.Size(76, 21);
            this.CustomLocationRadioButton.TabIndex = 2;
            this.CustomLocationRadioButton.Text = "Custom";
            this.CustomLocationRadioButton.UseVisualStyleBackColor = true;
            // 
            // CityCodeTextBox
            // 
            this.CityCodeTextBox.Location = new System.Drawing.Point(197, 14);
            this.CityCodeTextBox.Name = "CityCodeTextBox";
            this.CityCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.CityCodeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accu Weater City Code:";
            // 
            // PanelCityCode
            // 
            this.PanelCityCode.Controls.Add(this.label2);
            this.PanelCityCode.Controls.Add(this.CityCodeTextBox);
            this.PanelCityCode.Location = new System.Drawing.Point(291, 12);
            this.PanelCityCode.Name = "PanelCityCode";
            this.PanelCityCode.Size = new System.Drawing.Size(319, 56);
            this.PanelCityCode.TabIndex = 5;
            this.PanelCityCode.Visible = false;
            // 
            // PanelLocation
            // 
            this.PanelLocation.Controls.Add(this.WindowsLocationRadioButton);
            this.PanelLocation.Controls.Add(this.CustomLocationRadioButton);
            this.PanelLocation.Location = new System.Drawing.Point(84, 12);
            this.PanelLocation.Name = "PanelLocation";
            this.PanelLocation.Size = new System.Drawing.Size(201, 56);
            this.PanelLocation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "System of Measyrement:";
            // 
            // TemperatureCRadioButton
            // 
            this.TemperatureCRadioButton.AutoSize = true;
            this.TemperatureCRadioButton.Checked = true;
            this.TemperatureCRadioButton.Location = new System.Drawing.Point(3, 23);
            this.TemperatureCRadioButton.Name = "TemperatureCRadioButton";
            this.TemperatureCRadioButton.Size = new System.Drawing.Size(38, 21);
            this.TemperatureCRadioButton.TabIndex = 8;
            this.TemperatureCRadioButton.TabStop = true;
            this.TemperatureCRadioButton.Text = "C";
            this.TemperatureCRadioButton.UseVisualStyleBackColor = true;
            // 
            // TemperatureFRadioButton
            // 
            this.TemperatureFRadioButton.AutoSize = true;
            this.TemperatureFRadioButton.Location = new System.Drawing.Point(47, 23);
            this.TemperatureFRadioButton.Name = "TemperatureFRadioButton";
            this.TemperatureFRadioButton.Size = new System.Drawing.Size(37, 21);
            this.TemperatureFRadioButton.TabIndex = 9;
            this.TemperatureFRadioButton.TabStop = true;
            this.TemperatureFRadioButton.Text = "F";
            this.TemperatureFRadioButton.UseVisualStyleBackColor = true;
            // 
            // PanelTemperature
            // 
            this.PanelTemperature.Controls.Add(this.TemperatureCRadioButton);
            this.PanelTemperature.Controls.Add(this.TemperatureFRadioButton);
            this.PanelTemperature.Location = new System.Drawing.Point(194, 91);
            this.PanelTemperature.Name = "PanelTemperature";
            this.PanelTemperature.Size = new System.Drawing.Size(101, 43);
            this.PanelTemperature.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Forecast:";
            // 
            // HoursDropDown
            // 
            this.HoursDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursDropDown.FormattingEnabled = true;
            this.HoursDropDown.Location = new System.Drawing.Point(100, 209);
            this.HoursDropDown.Name = "HoursDropDown";
            this.HoursDropDown.Size = new System.Drawing.Size(121, 24);
            this.HoursDropDown.TabIndex = 12;
            // 
            // DaysComboBox
            // 
            this.DaysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaysComboBox.FormattingEnabled = true;
            this.DaysComboBox.Location = new System.Drawing.Point(241, 209);
            this.DaysComboBox.Name = "DaysComboBox";
            this.DaysComboBox.Size = new System.Drawing.Size(121, 24);
            this.DaysComboBox.TabIndex = 13;
            this.DaysComboBox.Visible = false;
            // 
            // GetForecastButton
            // 
            this.GetForecastButton.Location = new System.Drawing.Point(422, 203);
            this.GetForecastButton.Name = "GetForecastButton";
            this.GetForecastButton.Size = new System.Drawing.Size(131, 35);
            this.GetForecastButton.TabIndex = 14;
            this.GetForecastButton.Text = "Get Forecast";
            this.GetForecastButton.UseVisualStyleBackColor = true;
            this.GetForecastButton.Click += new System.EventHandler(this.getForecastButton_Click);
            // 
            // HoursRadioButton
            // 
            this.HoursRadioButton.AutoSize = true;
            this.HoursRadioButton.Checked = true;
            this.HoursRadioButton.Location = new System.Drawing.Point(0, 20);
            this.HoursRadioButton.Name = "HoursRadioButton";
            this.HoursRadioButton.Size = new System.Drawing.Size(70, 21);
            this.HoursRadioButton.TabIndex = 15;
            this.HoursRadioButton.TabStop = true;
            this.HoursRadioButton.Text = "Hourly";
            this.HoursRadioButton.UseVisualStyleBackColor = true;
            this.HoursRadioButton.CheckedChanged += new System.EventHandler(this.hoursRadioButton_CheckedChanged);
            // 
            // DaysDropDown
            // 
            this.DaysDropDown.AutoSize = true;
            this.DaysDropDown.Location = new System.Drawing.Point(141, 19);
            this.DaysDropDown.Name = "DaysDropDown";
            this.DaysDropDown.Size = new System.Drawing.Size(60, 21);
            this.DaysDropDown.TabIndex = 16;
            this.DaysDropDown.TabStop = true;
            this.DaysDropDown.Text = "Daily";
            this.DaysDropDown.UseVisualStyleBackColor = true;
            // 
            // PanelForecast
            // 
            this.PanelForecast.Controls.Add(this.HoursRadioButton);
            this.PanelForecast.Controls.Add(this.DaysDropDown);
            this.PanelForecast.Location = new System.Drawing.Point(100, 153);
            this.PanelForecast.Name = "PanelForecast";
            this.PanelForecast.Size = new System.Drawing.Size(269, 50);
            this.PanelForecast.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 275);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 190);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(551, 275);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(517, 190);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 505);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PanelForecast);
            this.Controls.Add(this.GetForecastButton);
            this.Controls.Add(this.DaysComboBox);
            this.Controls.Add(this.HoursDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PanelTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelLocation);
            this.Controls.Add(this.PanelCityCode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AccuWeatherIntern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelCityCode.ResumeLayout(false);
            this.PanelCityCode.PerformLayout();
            this.PanelLocation.ResumeLayout(false);
            this.PanelLocation.PerformLayout();
            this.PanelTemperature.ResumeLayout(false);
            this.PanelTemperature.PerformLayout();
            this.PanelForecast.ResumeLayout(false);
            this.PanelForecast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton WindowsLocationRadioButton;
        private System.Windows.Forms.RadioButton CustomLocationRadioButton;
        private System.Windows.Forms.TextBox CityCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelCityCode;
        private System.Windows.Forms.Panel PanelLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton TemperatureCRadioButton;
        private System.Windows.Forms.RadioButton TemperatureFRadioButton;
        private System.Windows.Forms.Panel PanelTemperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HoursDropDown;
        private System.Windows.Forms.ComboBox DaysComboBox;
        private System.Windows.Forms.Button GetForecastButton;
        private System.Windows.Forms.RadioButton HoursRadioButton;
        private System.Windows.Forms.RadioButton DaysDropDown;
        private System.Windows.Forms.Panel PanelForecast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

