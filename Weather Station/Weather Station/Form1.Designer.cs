namespace Weather_Station
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
            this.gbUpdateMeasurements = new System.Windows.Forms.GroupBox();
            this.lbCurrentReadings = new System.Windows.Forms.ListBox();
            this.lbAverageReadings = new System.Windows.Forms.ListBox();
            this.lbForecast = new System.Windows.Forms.ListBox();
            this.lCurrentReadings = new System.Windows.Forms.Label();
            this.lAverageReadings = new System.Windows.Forms.Label();
            this.lForecast = new System.Windows.Forms.Label();
            this.bUpdateMeasurements = new System.Windows.Forms.Button();
            this.nTemperature = new System.Windows.Forms.NumericUpDown();
            this.nHumidity = new System.Windows.Forms.NumericUpDown();
            this.nBPressure = new System.Windows.Forms.NumericUpDown();
            this.lTemperature = new System.Windows.Forms.Label();
            this.lHumidity = new System.Windows.Forms.Label();
            this.lBPressure = new System.Windows.Forms.Label();
            this.gbUpdateMeasurements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUpdateMeasurements
            // 
            this.gbUpdateMeasurements.Controls.Add(this.lBPressure);
            this.gbUpdateMeasurements.Controls.Add(this.lHumidity);
            this.gbUpdateMeasurements.Controls.Add(this.lTemperature);
            this.gbUpdateMeasurements.Controls.Add(this.nBPressure);
            this.gbUpdateMeasurements.Controls.Add(this.nHumidity);
            this.gbUpdateMeasurements.Controls.Add(this.nTemperature);
            this.gbUpdateMeasurements.Controls.Add(this.bUpdateMeasurements);
            this.gbUpdateMeasurements.Location = new System.Drawing.Point(13, 13);
            this.gbUpdateMeasurements.Name = "gbUpdateMeasurements";
            this.gbUpdateMeasurements.Size = new System.Drawing.Size(245, 396);
            this.gbUpdateMeasurements.TabIndex = 0;
            this.gbUpdateMeasurements.TabStop = false;
            this.gbUpdateMeasurements.Text = "Update Measurements";
            // 
            // lbCurrentReadings
            // 
            this.lbCurrentReadings.FormattingEnabled = true;
            this.lbCurrentReadings.Location = new System.Drawing.Point(282, 32);
            this.lbCurrentReadings.Name = "lbCurrentReadings";
            this.lbCurrentReadings.Size = new System.Drawing.Size(412, 108);
            this.lbCurrentReadings.TabIndex = 1;
            // 
            // lbAverageReadings
            // 
            this.lbAverageReadings.FormattingEnabled = true;
            this.lbAverageReadings.Location = new System.Drawing.Point(282, 168);
            this.lbAverageReadings.Name = "lbAverageReadings";
            this.lbAverageReadings.Size = new System.Drawing.Size(412, 108);
            this.lbAverageReadings.TabIndex = 2;
            // 
            // lbForecast
            // 
            this.lbForecast.FormattingEnabled = true;
            this.lbForecast.Location = new System.Drawing.Point(282, 301);
            this.lbForecast.Name = "lbForecast";
            this.lbForecast.Size = new System.Drawing.Size(412, 108);
            this.lbForecast.TabIndex = 3;
            // 
            // lCurrentReadings
            // 
            this.lCurrentReadings.AutoSize = true;
            this.lCurrentReadings.Location = new System.Drawing.Point(282, 13);
            this.lCurrentReadings.Name = "lCurrentReadings";
            this.lCurrentReadings.Size = new System.Drawing.Size(89, 13);
            this.lCurrentReadings.TabIndex = 4;
            this.lCurrentReadings.Text = "Current Readings";
            // 
            // lAverageReadings
            // 
            this.lAverageReadings.AutoSize = true;
            this.lAverageReadings.Location = new System.Drawing.Point(282, 149);
            this.lAverageReadings.Name = "lAverageReadings";
            this.lAverageReadings.Size = new System.Drawing.Size(95, 13);
            this.lAverageReadings.TabIndex = 5;
            this.lAverageReadings.Text = "Average Readings";
            // 
            // lForecast
            // 
            this.lForecast.AutoSize = true;
            this.lForecast.Location = new System.Drawing.Point(282, 282);
            this.lForecast.Name = "lForecast";
            this.lForecast.Size = new System.Drawing.Size(48, 13);
            this.lForecast.TabIndex = 6;
            this.lForecast.Text = "Forecast";
            // 
            // bUpdateMeasurements
            // 
            this.bUpdateMeasurements.Location = new System.Drawing.Point(24, 36);
            this.bUpdateMeasurements.Name = "bUpdateMeasurements";
            this.bUpdateMeasurements.Size = new System.Drawing.Size(198, 44);
            this.bUpdateMeasurements.TabIndex = 0;
            this.bUpdateMeasurements.Text = "Update Measurements";
            this.bUpdateMeasurements.UseVisualStyleBackColor = true;
            // 
            // nTemperature
            // 
            this.nTemperature.Location = new System.Drawing.Point(24, 155);
            this.nTemperature.Name = "nTemperature";
            this.nTemperature.Size = new System.Drawing.Size(198, 20);
            this.nTemperature.TabIndex = 1;
            // 
            // nHumidity
            // 
            this.nHumidity.Location = new System.Drawing.Point(24, 243);
            this.nHumidity.Name = "nHumidity";
            this.nHumidity.Size = new System.Drawing.Size(198, 20);
            this.nHumidity.TabIndex = 2;
            // 
            // nBPressure
            // 
            this.nBPressure.Location = new System.Drawing.Point(24, 339);
            this.nBPressure.Name = "nBPressure";
            this.nBPressure.Size = new System.Drawing.Size(198, 20);
            this.nBPressure.TabIndex = 3;
            // 
            // lTemperature
            // 
            this.lTemperature.AutoSize = true;
            this.lTemperature.Location = new System.Drawing.Point(24, 135);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(83, 13);
            this.lTemperature.TabIndex = 4;
            this.lTemperature.Text = "Temperature (C)";
            // 
            // lHumidity
            // 
            this.lHumidity.AutoSize = true;
            this.lHumidity.Location = new System.Drawing.Point(24, 224);
            this.lHumidity.Name = "lHumidity";
            this.lHumidity.Size = new System.Drawing.Size(64, 13);
            this.lHumidity.TabIndex = 5;
            this.lHumidity.Text = "Humidity (%)";
            // 
            // lBPressure
            // 
            this.lBPressure.AutoSize = true;
            this.lBPressure.Location = new System.Drawing.Point(24, 320);
            this.lBPressure.Name = "lBPressure";
            this.lBPressure.Size = new System.Drawing.Size(125, 13);
            this.lBPressure.TabIndex = 6;
            this.lBPressure.Text = "Barometric Pressure (mB)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 426);
            this.Controls.Add(this.lForecast);
            this.Controls.Add(this.lAverageReadings);
            this.Controls.Add(this.lCurrentReadings);
            this.Controls.Add(this.lbForecast);
            this.Controls.Add(this.lbAverageReadings);
            this.Controls.Add(this.lbCurrentReadings);
            this.Controls.Add(this.gbUpdateMeasurements);
            this.Name = "Form1";
            this.Text = "Weather Station";
            this.gbUpdateMeasurements.ResumeLayout(false);
            this.gbUpdateMeasurements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBPressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdateMeasurements;
        private System.Windows.Forms.Label lBPressure;
        private System.Windows.Forms.Label lHumidity;
        private System.Windows.Forms.Label lTemperature;
        private System.Windows.Forms.NumericUpDown nBPressure;
        private System.Windows.Forms.NumericUpDown nHumidity;
        private System.Windows.Forms.NumericUpDown nTemperature;
        private System.Windows.Forms.Button bUpdateMeasurements;
        private System.Windows.Forms.ListBox lbCurrentReadings;
        private System.Windows.Forms.ListBox lbAverageReadings;
        private System.Windows.Forms.ListBox lbForecast;
        private System.Windows.Forms.Label lCurrentReadings;
        private System.Windows.Forms.Label lAverageReadings;
        private System.Windows.Forms.Label lForecast;
    }
}

