namespace JavaWaterSport.View
{
    partial class NyDykarkurs
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
            this.lvwDykarKurser = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisaDykarkurser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDykinstruktör = new System.Windows.Forms.Label();
            this.cbxDykinstruktörer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvwDykarKurser
            // 
            this.lvwDykarKurser.Location = new System.Drawing.Point(12, 47);
            this.lvwDykarKurser.Name = "lvwDykarKurser";
            this.lvwDykarKurser.Size = new System.Drawing.Size(220, 387);
            this.lvwDykarKurser.TabIndex = 0;
            this.lvwDykarKurser.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dykarkurser:";
            // 
            // btnVisaDykarkurser
            // 
            this.btnVisaDykarkurser.Location = new System.Drawing.Point(12, 440);
            this.btnVisaDykarkurser.Name = "btnVisaDykarkurser";
            this.btnVisaDykarkurser.Size = new System.Drawing.Size(220, 23);
            this.btnVisaDykarkurser.TabIndex = 2;
            this.btnVisaDykarkurser.Text = "Visa dykarkurser";
            this.btnVisaDykarkurser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lägg till ny dykarkurs:\r\n";
            // 
            // tbxDatum
            // 
            this.tbxDatum.Location = new System.Drawing.Point(313, 78);
            this.tbxDatum.Name = "tbxDatum";
            this.tbxDatum.Size = new System.Drawing.Size(122, 20);
            this.tbxDatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tid:";
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(313, 114);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(122, 20);
            this.tbxTid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "OBS:\r\nAnge datum på formatet: ÅR-MÅNAD-DAG\r\nsamt tid på formatet: TIMMAR-MINUTER\r" +
    "\n";
            // 
            // lblDykinstruktör
            // 
            this.lblDykinstruktör.AutoSize = true;
            this.lblDykinstruktör.Location = new System.Drawing.Point(269, 224);
            this.lblDykinstruktör.Name = "lblDykinstruktör";
            this.lblDykinstruktör.Size = new System.Drawing.Size(72, 13);
            this.lblDykinstruktör.TabIndex = 9;
            this.lblDykinstruktör.Text = "Dykinstruktör:";
            // 
            // cbxDykinstruktörer
            // 
            this.cbxDykinstruktörer.FormattingEnabled = true;
            this.cbxDykinstruktörer.Items.AddRange(new object[] {
            "Yngve",
            "Elias-Button",
            "Macke"});
            this.cbxDykinstruktörer.Location = new System.Drawing.Point(348, 224);
            this.cbxDykinstruktörer.Name = "cbxDykinstruktörer";
            this.cbxDykinstruktörer.Size = new System.Drawing.Size(121, 21);
            this.cbxDykinstruktörer.TabIndex = 10;
            // 
            // NyDykarkurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 489);
            this.Controls.Add(this.cbxDykinstruktörer);
            this.Controls.Add(this.lblDykinstruktör);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVisaDykarkurser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwDykarKurser);
            this.Name = "NyDykarkurs";
            this.Text = "NyDykarkurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwDykarKurser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisaDykarkurser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDykinstruktör;
        private System.Windows.Forms.ComboBox cbxDykinstruktörer;
    }
}