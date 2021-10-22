namespace ConsumingWebServiceExample1
{
    partial class Quotes
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter Stock Symbol, then press button";
            // 
            // txtQuote
            // 
            this.txtQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuote.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuote.Location = new System.Drawing.Point(37, 94);
            this.txtQuote.Multiline = true;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.ReadOnly = true;
            this.txtQuote.Size = new System.Drawing.Size(291, 219);
            this.txtQuote.TabIndex = 12;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(91, 30);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtSymbol.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stock quote:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stock symbol:";
            // 
            // btnShowQuote
            // 
            this.btnShowQuote.Location = new System.Drawing.Point(239, 22);
            this.btnShowQuote.Name = "btnShowQuote";
            this.btnShowQuote.Size = new System.Drawing.Size(89, 54);
            this.btnShowQuote.TabIndex = 8;
            this.btnShowQuote.Text = "Get Quote";
            this.btnShowQuote.UseVisualStyleBackColor = true;
            this.btnShowQuote.Click += new System.EventHandler(this.btnShowQuote_Click);
            // 
            // Quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuote);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowQuote);
            this.Name = "Quotes";
            this.Text = "Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuote;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowQuote;
    }
}