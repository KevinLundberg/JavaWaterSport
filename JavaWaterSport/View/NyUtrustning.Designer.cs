namespace JavaWaterSport.View
{
    partial class NyUtrustning
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
            this.lvwUtrustning = new System.Windows.Forms.ListView();
            this.btnVisaUtrustning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwUtrustning
            // 
            this.lvwUtrustning.Location = new System.Drawing.Point(12, 50);
            this.lvwUtrustning.Name = "lvwUtrustning";
            this.lvwUtrustning.Size = new System.Drawing.Size(239, 441);
            this.lvwUtrustning.TabIndex = 0;
            this.lvwUtrustning.UseCompatibleStateImageBehavior = false;
            this.lvwUtrustning.SelectedIndexChanged += new System.EventHandler(this.lvwUtrustning_SelectedIndexChanged);
            // 
            // btnVisaUtrustning
            // 
            this.btnVisaUtrustning.Location = new System.Drawing.Point(12, 497);
            this.btnVisaUtrustning.Name = "btnVisaUtrustning";
            this.btnVisaUtrustning.Size = new System.Drawing.Size(239, 23);
            this.btnVisaUtrustning.TabIndex = 1;
            this.btnVisaUtrustning.Text = "Visa utrustning";
            this.btnVisaUtrustning.UseVisualStyleBackColor = true;
            this.btnVisaUtrustning.Click += new System.EventHandler(this.btnVisaUtrustning_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visar all utrustning";
            // 
            // NyUtrustning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisaUtrustning);
            this.Controls.Add(this.lvwUtrustning);
            this.Name = "NyUtrustning";
            this.Text = "NyUtrustning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwUtrustning;
        private System.Windows.Forms.Button btnVisaUtrustning;
        private System.Windows.Forms.Label label1;
    }
}