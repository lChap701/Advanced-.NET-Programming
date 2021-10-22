namespace ConsumingWebServiceExample1
{
    partial class Weather
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
            this.btnShowWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowWeather
            // 
            this.btnShowWeather.Location = new System.Drawing.Point(16, 90);
            this.btnShowWeather.Name = "btnShowWeather";
            this.btnShowWeather.Size = new System.Drawing.Size(89, 54);
            this.btnShowWeather.TabIndex = 0;
            this.btnShowWeather.Text = "Show\r\nWeather";
            this.btnShowWeather.UseVisualStyleBackColor = true;
            this.btnShowWeather.Click += new System.EventHandler(this.btnShowWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(70, 30);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(70, 58);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(197, 33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Weather:";
            // 
            // txtWeather
            // 
            this.txtWeather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeather.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtWeather.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeather.Location = new System.Drawing.Point(219, 50);
            this.txtWeather.Multiline = true;
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.ReadOnly = true;
            this.txtWeather.Size = new System.Drawing.Size(345, 200);
            this.txtWeather.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter City and Country, then click button";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWeather);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.Label label4;
    }
}

