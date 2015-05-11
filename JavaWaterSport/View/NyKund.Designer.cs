namespace JavaWaterSport.View
{
    partial class NyKund
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
            this.btnRegistreraKund = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.lvwKunder = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPersonligID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvwBokningar = new System.Windows.Forms.ListView();
            this.lvwDykarkurs = new System.Windows.Forms.ListView();
            this.btnSorteraBokingar = new System.Windows.Forms.Button();
            this.btnBokaDykarkurs = new System.Windows.Forms.Button();
            this.btnTaBortKund = new System.Windows.Forms.Button();
            this.lblKursID = new System.Windows.Forms.Label();
            this.lblKundID = new System.Windows.Forms.Label();
            this.btnTaBortBokning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistreraKund
            // 
            this.btnRegistreraKund.Location = new System.Drawing.Point(279, 83);
            this.btnRegistreraKund.Name = "btnRegistreraKund";
            this.btnRegistreraKund.Size = new System.Drawing.Size(90, 23);
            this.btnRegistreraKund.TabIndex = 0;
            this.btnRegistreraKund.Text = "Registera kund";
            this.btnRegistreraKund.UseVisualStyleBackColor = true;
            this.btnRegistreraKund.Click += new System.EventHandler(this.btnRegistreraKund_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(15, 85);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(251, 20);
            this.tbxNamn.TabIndex = 2;
            // 
            // lvwKunder
            // 
            this.lvwKunder.Location = new System.Drawing.Point(15, 155);
            this.lvwKunder.Name = "lvwKunder";
            this.lvwKunder.Size = new System.Drawing.Size(354, 430);
            this.lvwKunder.TabIndex = 10;
            this.lvwKunder.UseCompatibleStateImageBehavior = false;
            this.lvwKunder.View = System.Windows.Forms.View.Details;
            this.lvwKunder.SelectedIndexChanged += new System.EventHandler(this.lvwKunder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kunder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personlig ID:";
            // 
            // tbxPersonligID
            // 
            this.tbxPersonligID.Location = new System.Drawing.Point(15, 34);
            this.tbxPersonligID.Name = "tbxPersonligID";
            this.tbxPersonligID.Size = new System.Drawing.Size(251, 20);
            this.tbxPersonligID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bokade kurser";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(432, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bokning av dykarkurs";
            // 
            // lvwBokningar
            // 
            this.lvwBokningar.Location = new System.Drawing.Point(436, 55);
            this.lvwBokningar.Name = "lvwBokningar";
            this.lvwBokningar.Size = new System.Drawing.Size(276, 226);
            this.lvwBokningar.TabIndex = 16;
            this.lvwBokningar.UseCompatibleStateImageBehavior = false;
            this.lvwBokningar.View = System.Windows.Forms.View.Details;
            // 
            // lvwDykarkurs
            // 
            this.lvwDykarkurs.Location = new System.Drawing.Point(436, 360);
            this.lvwDykarkurs.Name = "lvwDykarkurs";
            this.lvwDykarkurs.Size = new System.Drawing.Size(276, 225);
            this.lvwDykarkurs.TabIndex = 17;
            this.lvwDykarkurs.UseCompatibleStateImageBehavior = false;
            this.lvwDykarkurs.View = System.Windows.Forms.View.Details;
            this.lvwDykarkurs.SelectedIndexChanged += new System.EventHandler(this.lvwDykarkurs_SelectedIndexChanged);
            // 
            // btnSorteraBokingar
            // 
            this.btnSorteraBokingar.Location = new System.Drawing.Point(436, 287);
            this.btnSorteraBokingar.Name = "btnSorteraBokingar";
            this.btnSorteraBokingar.Size = new System.Drawing.Size(131, 23);
            this.btnSorteraBokingar.TabIndex = 18;
            this.btnSorteraBokingar.Text = "Sortera bokningar";
            this.btnSorteraBokingar.UseVisualStyleBackColor = true;
            this.btnSorteraBokingar.Click += new System.EventHandler(this.btnSorteraBokingar_Click);
            // 
            // btnBokaDykarkurs
            // 
            this.btnBokaDykarkurs.Location = new System.Drawing.Point(436, 591);
            this.btnBokaDykarkurs.Name = "btnBokaDykarkurs";
            this.btnBokaDykarkurs.Size = new System.Drawing.Size(276, 23);
            this.btnBokaDykarkurs.TabIndex = 19;
            this.btnBokaDykarkurs.Text = "Boka Dykarkurs";
            this.btnBokaDykarkurs.UseVisualStyleBackColor = true;
            this.btnBokaDykarkurs.Click += new System.EventHandler(this.btnBokaDykarkurs_Click);
            // 
            // btnTaBortKund
            // 
            this.btnTaBortKund.Location = new System.Drawing.Point(15, 591);
            this.btnTaBortKund.Name = "btnTaBortKund";
            this.btnTaBortKund.Size = new System.Drawing.Size(354, 23);
            this.btnTaBortKund.TabIndex = 20;
            this.btnTaBortKund.Text = "Ta bort kund";
            this.btnTaBortKund.UseVisualStyleBackColor = true;
            this.btnTaBortKund.Click += new System.EventHandler(this.btnTaBortKund_Click);
            // 
            // lblKursID
            // 
            this.lblKursID.AutoSize = true;
            this.lblKursID.Location = new System.Drawing.Point(309, 13);
            this.lblKursID.Name = "lblKursID";
            this.lblKursID.Size = new System.Drawing.Size(39, 13);
            this.lblKursID.TabIndex = 21;
            this.lblKursID.Text = "KursID";
            // 
            // lblKundID
            // 
            this.lblKundID.AutoSize = true;
            this.lblKundID.Location = new System.Drawing.Point(309, 41);
            this.lblKundID.Name = "lblKundID";
            this.lblKundID.Size = new System.Drawing.Size(43, 13);
            this.lblKundID.TabIndex = 22;
            this.lblKundID.Text = "KundID";
            // 
            // btnTaBortBokning
            // 
            this.btnTaBortBokning.Location = new System.Drawing.Point(581, 287);
            this.btnTaBortBokning.Name = "btnTaBortBokning";
            this.btnTaBortBokning.Size = new System.Drawing.Size(131, 23);
            this.btnTaBortBokning.TabIndex = 23;
            this.btnTaBortBokning.Text = "Ta bort bokning";
            this.btnTaBortBokning.UseVisualStyleBackColor = true;
            this.btnTaBortBokning.Click += new System.EventHandler(this.btnTaBortBokning_Click);
            // 
            // NyKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 626);
            this.Controls.Add(this.btnTaBortBokning);
            this.Controls.Add(this.lblKundID);
            this.Controls.Add(this.lblKursID);
            this.Controls.Add(this.btnTaBortKund);
            this.Controls.Add(this.btnBokaDykarkurs);
            this.Controls.Add(this.btnSorteraBokingar);
            this.Controls.Add(this.lvwDykarkurs);
            this.Controls.Add(this.lvwBokningar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPersonligID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwKunder);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistreraKund);
            this.Name = "NyKund";
            this.Text = "NyKund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistreraKund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.ListView lvwKunder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPersonligID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvwBokningar;
        private System.Windows.Forms.ListView lvwDykarkurs;
        private System.Windows.Forms.Button btnSorteraBokingar;
        private System.Windows.Forms.Button btnBokaDykarkurs;
        private System.Windows.Forms.Button btnTaBortKund;
        private System.Windows.Forms.Label lblKursID;
        private System.Windows.Forms.Label lblKundID;
        private System.Windows.Forms.Button btnTaBortBokning;
    }
}