namespace Weather.UI.Forms
{
    partial class MainForm
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
            this.Wind_Label = new System.Windows.Forms.Label();
            this.Humidity_Label = new System.Windows.Forms.Label();
            this.Visibility_Label = new System.Windows.Forms.Label();
            this.Presure_Label = new System.Windows.Forms.Label();
            this.WindSpeed_Label = new System.Windows.Forms.Label();
            this.HumidityPercentage_Label = new System.Windows.Forms.Label();
            this.VisibilityDistance_Label = new System.Windows.Forms.Label();
            this.PressurePower_Label = new System.Windows.Forms.Label();
            this.WeatherIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentTemperature_Label = new System.Windows.Forms.Label();
            this.CurrenWeatherType_Label = new System.Windows.Forms.Label();
            this.FeelsLike_Label = new System.Windows.Forms.Label();
            this.FeelsLikePercentage_Label = new System.Windows.Forms.Label();
            this.Lowest_Label = new System.Windows.Forms.Label();
            this.LowestTemperature_Label = new System.Windows.Forms.Label();
            this.Highest_Label = new System.Windows.Forms.Label();
            this.HighestTemperature_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Wind_Label
            // 
            this.Wind_Label.AutoSize = true;
            this.Wind_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wind_Label.Location = new System.Drawing.Point(157, 9);
            this.Wind_Label.Name = "Wind_Label";
            this.Wind_Label.Size = new System.Drawing.Size(50, 18);
            this.Wind_Label.TabIndex = 0;
            this.Wind_Label.Text = "Wind: ";
            // 
            // Humidity_Label
            // 
            this.Humidity_Label.AutoSize = true;
            this.Humidity_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity_Label.Location = new System.Drawing.Point(317, 9);
            this.Humidity_Label.Name = "Humidity_Label";
            this.Humidity_Label.Size = new System.Drawing.Size(76, 18);
            this.Humidity_Label.TabIndex = 0;
            this.Humidity_Label.Text = "Humidity: ";
            // 
            // Visibility_Label
            // 
            this.Visibility_Label.AutoSize = true;
            this.Visibility_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visibility_Label.Location = new System.Drawing.Point(503, 9);
            this.Visibility_Label.Name = "Visibility_Label";
            this.Visibility_Label.Size = new System.Drawing.Size(68, 18);
            this.Visibility_Label.TabIndex = 0;
            this.Visibility_Label.Text = "Visibility:";
            // 
            // Presure_Label
            // 
            this.Presure_Label.AutoSize = true;
            this.Presure_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presure_Label.Location = new System.Drawing.Point(681, 9);
            this.Presure_Label.Name = "Presure_Label";
            this.Presure_Label.Size = new System.Drawing.Size(65, 18);
            this.Presure_Label.TabIndex = 0;
            this.Presure_Label.Text = "Pressure:";
            // 
            // WindSpeed_Label
            // 
            this.WindSpeed_Label.AutoSize = true;
            this.WindSpeed_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeed_Label.Location = new System.Drawing.Point(203, 9);
            this.WindSpeed_Label.Name = "WindSpeed_Label";
            this.WindSpeed_Label.Size = new System.Drawing.Size(43, 18);
            this.WindSpeed_Label.TabIndex = 1;
            this.WindSpeed_Label.Text = "0 mph";
            // 
            // HumidityPercentage_Label
            // 
            this.HumidityPercentage_Label.AutoSize = true;
            this.HumidityPercentage_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityPercentage_Label.Location = new System.Drawing.Point(399, 9);
            this.HumidityPercentage_Label.Name = "HumidityPercentage_Label";
            this.HumidityPercentage_Label.Size = new System.Drawing.Size(26, 18);
            this.HumidityPercentage_Label.TabIndex = 1;
            this.HumidityPercentage_Label.Text = "0%";
            // 
            // VisibilityDistance_Label
            // 
            this.VisibilityDistance_Label.AutoSize = true;
            this.VisibilityDistance_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisibilityDistance_Label.Location = new System.Drawing.Point(577, 9);
            this.VisibilityDistance_Label.Name = "VisibilityDistance_Label";
            this.VisibilityDistance_Label.Size = new System.Drawing.Size(32, 18);
            this.VisibilityDistance_Label.TabIndex = 1;
            this.VisibilityDistance_Label.Text = "0 mi";
            // 
            // PressurePower_Label
            // 
            this.PressurePower_Label.AutoSize = true;
            this.PressurePower_Label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressurePower_Label.Location = new System.Drawing.Point(752, 9);
            this.PressurePower_Label.Name = "PressurePower_Label";
            this.PressurePower_Label.Size = new System.Drawing.Size(36, 18);
            this.PressurePower_Label.TabIndex = 1;
            this.PressurePower_Label.Text = "0 mb";
            // 
            // WeatherIcon_PictureBox
            // 
            this.WeatherIcon_PictureBox.Location = new System.Drawing.Point(221, 123);
            this.WeatherIcon_PictureBox.Name = "WeatherIcon_PictureBox";
            this.WeatherIcon_PictureBox.Size = new System.Drawing.Size(100, 100);
            this.WeatherIcon_PictureBox.TabIndex = 2;
            this.WeatherIcon_PictureBox.TabStop = false;
            // 
            // CurrentTemperature_Label
            // 
            this.CurrentTemperature_Label.AutoSize = true;
            this.CurrentTemperature_Label.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTemperature_Label.Location = new System.Drawing.Point(327, 123);
            this.CurrentTemperature_Label.Name = "CurrentTemperature_Label";
            this.CurrentTemperature_Label.Size = new System.Drawing.Size(92, 62);
            this.CurrentTemperature_Label.TabIndex = 3;
            this.CurrentTemperature_Label.Text = "0 F";
            // 
            // CurrenWeatherType_Label
            // 
            this.CurrenWeatherType_Label.AutoSize = true;
            this.CurrenWeatherType_Label.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrenWeatherType_Label.Location = new System.Drawing.Point(425, 123);
            this.CurrenWeatherType_Label.Name = "CurrenWeatherType_Label";
            this.CurrenWeatherType_Label.Size = new System.Drawing.Size(328, 62);
            this.CurrenWeatherType_Label.TabIndex = 3;
            this.CurrenWeatherType_Label.Text = "Weather Type";
            // 
            // FeelsLike_Label
            // 
            this.FeelsLike_Label.AutoSize = true;
            this.FeelsLike_Label.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeelsLike_Label.Location = new System.Drawing.Point(327, 198);
            this.FeelsLike_Label.Name = "FeelsLike_Label";
            this.FeelsLike_Label.Size = new System.Drawing.Size(109, 25);
            this.FeelsLike_Label.TabIndex = 0;
            this.FeelsLike_Label.Text = "Feels Like:";
            // 
            // FeelsLikePercentage_Label
            // 
            this.FeelsLikePercentage_Label.AutoSize = true;
            this.FeelsLikePercentage_Label.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeelsLikePercentage_Label.Location = new System.Drawing.Point(442, 198);
            this.FeelsLikePercentage_Label.Name = "FeelsLikePercentage_Label";
            this.FeelsLikePercentage_Label.Size = new System.Drawing.Size(38, 25);
            this.FeelsLikePercentage_Label.TabIndex = 1;
            this.FeelsLikePercentage_Label.Text = "0%";
            // 
            // Lowest_Label
            // 
            this.Lowest_Label.AutoSize = true;
            this.Lowest_Label.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lowest_Label.Location = new System.Drawing.Point(500, 198);
            this.Lowest_Label.Name = "Lowest_Label";
            this.Lowest_Label.Size = new System.Drawing.Size(56, 25);
            this.Lowest_Label.TabIndex = 0;
            this.Lowest_Label.Text = "Low:";
            // 
            // LowestTemperature_Label
            // 
            this.LowestTemperature_Label.AutoSize = true;
            this.LowestTemperature_Label.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowestTemperature_Label.Location = new System.Drawing.Point(562, 198);
            this.LowestTemperature_Label.Name = "LowestTemperature_Label";
            this.LowestTemperature_Label.Size = new System.Drawing.Size(38, 25);
            this.LowestTemperature_Label.TabIndex = 1;
            this.LowestTemperature_Label.Text = "0%";
            // 
            // Highest_Label
            // 
            this.Highest_Label.AutoSize = true;
            this.Highest_Label.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highest_Label.Location = new System.Drawing.Point(620, 198);
            this.Highest_Label.Name = "Highest_Label";
            this.Highest_Label.Size = new System.Drawing.Size(62, 25);
            this.Highest_Label.TabIndex = 0;
            this.Highest_Label.Text = "High:";
            // 
            // HighestTemperature_Label
            // 
            this.HighestTemperature_Label.AutoSize = true;
            this.HighestTemperature_Label.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestTemperature_Label.Location = new System.Drawing.Point(682, 198);
            this.HighestTemperature_Label.Name = "HighestTemperature_Label";
            this.HighestTemperature_Label.Size = new System.Drawing.Size(38, 25);
            this.HighestTemperature_Label.TabIndex = 1;
            this.HighestTemperature_Label.Text = "0%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 302);
            this.Controls.Add(this.CurrenWeatherType_Label);
            this.Controls.Add(this.CurrentTemperature_Label);
            this.Controls.Add(this.WeatherIcon_PictureBox);
            this.Controls.Add(this.PressurePower_Label);
            this.Controls.Add(this.VisibilityDistance_Label);
            this.Controls.Add(this.HighestTemperature_Label);
            this.Controls.Add(this.LowestTemperature_Label);
            this.Controls.Add(this.FeelsLikePercentage_Label);
            this.Controls.Add(this.HumidityPercentage_Label);
            this.Controls.Add(this.WindSpeed_Label);
            this.Controls.Add(this.Presure_Label);
            this.Controls.Add(this.Visibility_Label);
            this.Controls.Add(this.Highest_Label);
            this.Controls.Add(this.Lowest_Label);
            this.Controls.Add(this.FeelsLike_Label);
            this.Controls.Add(this.Humidity_Label);
            this.Controls.Add(this.Wind_Label);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wind_Label;
        private System.Windows.Forms.Label Humidity_Label;
        private System.Windows.Forms.Label Visibility_Label;
        private System.Windows.Forms.Label Presure_Label;
        private System.Windows.Forms.Label WindSpeed_Label;
        private System.Windows.Forms.Label HumidityPercentage_Label;
        private System.Windows.Forms.Label VisibilityDistance_Label;
        private System.Windows.Forms.Label PressurePower_Label;
        private System.Windows.Forms.PictureBox WeatherIcon_PictureBox;
        private System.Windows.Forms.Label CurrentTemperature_Label;
        private System.Windows.Forms.Label CurrenWeatherType_Label;
        private System.Windows.Forms.Label FeelsLike_Label;
        private System.Windows.Forms.Label FeelsLikePercentage_Label;
        private System.Windows.Forms.Label Lowest_Label;
        private System.Windows.Forms.Label LowestTemperature_Label;
        private System.Windows.Forms.Label Highest_Label;
        private System.Windows.Forms.Label HighestTemperature_Label;
    }
}