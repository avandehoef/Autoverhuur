﻿namespace Autoverhuur
{
    partial class Autoverhuur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autoverhuur));
            this.textBoxWelcome = new System.Windows.Forms.TextBox();
            this.textBoxFout = new System.Windows.Forms.TextBox();
            this.textBoxAutoOfBus = new System.Windows.Forms.TextBox();
            this.textBoxStartDatum = new System.Windows.Forms.TextBox();
            this.textBoxEindDatum = new System.Windows.Forms.TextBox();
            this.textBoxKilometer = new System.Windows.Forms.TextBox();
            this.textBoxKilometerInput = new System.Windows.Forms.TextBox();
            this.textBoxTotaalPrijs = new System.Windows.Forms.TextBox();
            this.comboBoxStartDag = new System.Windows.Forms.ComboBox();
            this.comboBoxEindDag = new System.Windows.Forms.ComboBox();
            this.comboBoxEindMaand = new System.Windows.Forms.ComboBox();
            this.comboBoxStartMaand = new System.Windows.Forms.ComboBox();
            this.comboBoxEindJaar = new System.Windows.Forms.ComboBox();
            this.comboBoxStartJaar = new System.Windows.Forms.ComboBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxAutoOfBus = new System.Windows.Forms.ComboBox();
            this.textBoxFoutStartDatum = new System.Windows.Forms.TextBox();
            this.textBoxFoutEindDatum = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxBrandstofInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWelcome
            // 
            this.textBoxWelcome.BackColor = System.Drawing.Color.LightGray;
            this.textBoxWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWelcome.Enabled = false;
            this.textBoxWelcome.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWelcome.Location = new System.Drawing.Point(13, 13);
            this.textBoxWelcome.Name = "textBoxWelcome";
            this.textBoxWelcome.Size = new System.Drawing.Size(847, 27);
            this.textBoxWelcome.TabIndex = 0;
            this.textBoxWelcome.TabStop = false;
            this.textBoxWelcome.Text = "Bereken hieronder de prijs voor de totale huurperiode";
            this.textBoxWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFout
            // 
            this.textBoxFout.BackColor = System.Drawing.Color.LightGray;
            this.textBoxFout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFout.Enabled = false;
            this.textBoxFout.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFout.ForeColor = System.Drawing.Color.Black;
            this.textBoxFout.Location = new System.Drawing.Point(13, 53);
            this.textBoxFout.Multiline = true;
            this.textBoxFout.Name = "textBoxFout";
            this.textBoxFout.Size = new System.Drawing.Size(847, 73);
            this.textBoxFout.TabIndex = 1;
            this.textBoxFout.TabStop = false;
            // 
            // textBoxAutoOfBus
            // 
            this.textBoxAutoOfBus.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAutoOfBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAutoOfBus.Enabled = false;
            this.textBoxAutoOfBus.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutoOfBus.Location = new System.Drawing.Point(12, 135);
            this.textBoxAutoOfBus.Name = "textBoxAutoOfBus";
            this.textBoxAutoOfBus.Size = new System.Drawing.Size(306, 27);
            this.textBoxAutoOfBus.TabIndex = 2;
            this.textBoxAutoOfBus.TabStop = false;
            this.textBoxAutoOfBus.Text = "Personenauto of Personenbusje";
            this.textBoxAutoOfBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxStartDatum
            // 
            this.textBoxStartDatum.BackColor = System.Drawing.Color.LightGray;
            this.textBoxStartDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartDatum.Enabled = false;
            this.textBoxStartDatum.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartDatum.Location = new System.Drawing.Point(13, 176);
            this.textBoxStartDatum.Name = "textBoxStartDatum";
            this.textBoxStartDatum.Size = new System.Drawing.Size(306, 27);
            this.textBoxStartDatum.TabIndex = 3;
            this.textBoxStartDatum.TabStop = false;
            this.textBoxStartDatum.Text = "Startdatum";
            this.textBoxStartDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEindDatum
            // 
            this.textBoxEindDatum.BackColor = System.Drawing.Color.LightGray;
            this.textBoxEindDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEindDatum.Enabled = false;
            this.textBoxEindDatum.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEindDatum.Location = new System.Drawing.Point(12, 216);
            this.textBoxEindDatum.Name = "textBoxEindDatum";
            this.textBoxEindDatum.Size = new System.Drawing.Size(306, 27);
            this.textBoxEindDatum.TabIndex = 4;
            this.textBoxEindDatum.TabStop = false;
            this.textBoxEindDatum.Text = "Einddatum";
            this.textBoxEindDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxKilometer
            // 
            this.textBoxKilometer.BackColor = System.Drawing.Color.LightGray;
            this.textBoxKilometer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKilometer.Enabled = false;
            this.textBoxKilometer.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKilometer.Location = new System.Drawing.Point(13, 257);
            this.textBoxKilometer.Name = "textBoxKilometer";
            this.textBoxKilometer.Size = new System.Drawing.Size(306, 27);
            this.textBoxKilometer.TabIndex = 5;
            this.textBoxKilometer.TabStop = false;
            this.textBoxKilometer.Text = "Totaal aantal kilometers";
            this.textBoxKilometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxKilometerInput
            // 
            this.textBoxKilometerInput.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKilometerInput.Location = new System.Drawing.Point(325, 254);
            this.textBoxKilometerInput.MaxLength = 5;
            this.textBoxKilometerInput.Name = "textBoxKilometerInput";
            this.textBoxKilometerInput.Size = new System.Drawing.Size(100, 34);
            this.textBoxKilometerInput.TabIndex = 1;
            // 
            // textBoxTotaalPrijs
            // 
            this.textBoxTotaalPrijs.BackColor = System.Drawing.Color.LightGray;
            this.textBoxTotaalPrijs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotaalPrijs.Enabled = false;
            this.textBoxTotaalPrijs.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotaalPrijs.Location = new System.Drawing.Point(325, 357);
            this.textBoxTotaalPrijs.Name = "textBoxTotaalPrijs";
            this.textBoxTotaalPrijs.Size = new System.Drawing.Size(535, 27);
            this.textBoxTotaalPrijs.TabIndex = 7;
            // 
            // comboBoxStartDag
            // 
            this.comboBoxStartDag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartDag.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStartDag.FormattingEnabled = true;
            this.comboBoxStartDag.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBoxStartDag.Location = new System.Drawing.Point(325, 173);
            this.comboBoxStartDag.Name = "comboBoxStartDag";
            this.comboBoxStartDag.Size = new System.Drawing.Size(70, 35);
            this.comboBoxStartDag.TabIndex = 4;
            // 
            // comboBoxEindDag
            // 
            this.comboBoxEindDag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEindDag.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEindDag.FormattingEnabled = true;
            this.comboBoxEindDag.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBoxEindDag.Location = new System.Drawing.Point(325, 213);
            this.comboBoxEindDag.Name = "comboBoxEindDag";
            this.comboBoxEindDag.Size = new System.Drawing.Size(70, 35);
            this.comboBoxEindDag.TabIndex = 7;
            // 
            // comboBoxEindMaand
            // 
            this.comboBoxEindMaand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEindMaand.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEindMaand.FormattingEnabled = true;
            this.comboBoxEindMaand.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maart",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Augustus",
            "September",
            "Oktober",
            "November",
            "December"});
            this.comboBoxEindMaand.Location = new System.Drawing.Point(401, 213);
            this.comboBoxEindMaand.Name = "comboBoxEindMaand";
            this.comboBoxEindMaand.Size = new System.Drawing.Size(157, 35);
            this.comboBoxEindMaand.TabIndex = 8;
            // 
            // comboBoxStartMaand
            // 
            this.comboBoxStartMaand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartMaand.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStartMaand.FormattingEnabled = true;
            this.comboBoxStartMaand.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maart",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Augustus",
            "September",
            "Oktober",
            "November",
            "December"});
            this.comboBoxStartMaand.Location = new System.Drawing.Point(401, 172);
            this.comboBoxStartMaand.Name = "comboBoxStartMaand";
            this.comboBoxStartMaand.Size = new System.Drawing.Size(157, 35);
            this.comboBoxStartMaand.TabIndex = 5;
            // 
            // comboBoxEindJaar
            // 
            this.comboBoxEindJaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEindJaar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEindJaar.FormattingEnabled = true;
            this.comboBoxEindJaar.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBoxEindJaar.Location = new System.Drawing.Point(564, 213);
            this.comboBoxEindJaar.Name = "comboBoxEindJaar";
            this.comboBoxEindJaar.Size = new System.Drawing.Size(93, 35);
            this.comboBoxEindJaar.TabIndex = 9;
            // 
            // comboBoxStartJaar
            // 
            this.comboBoxStartJaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartJaar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStartJaar.FormattingEnabled = true;
            this.comboBoxStartJaar.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBoxStartJaar.Location = new System.Drawing.Point(564, 172);
            this.comboBoxStartJaar.Name = "comboBoxStartJaar";
            this.comboBoxStartJaar.Size = new System.Drawing.Size(93, 35);
            this.comboBoxStartJaar.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBereken.Location = new System.Drawing.Point(210, 350);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(108, 40);
            this.btnBereken.TabIndex = 10;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(751, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Afsluiten";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReset.Location = new System.Drawing.Point(637, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 40);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxAutoOfBus
            // 
            this.comboBoxAutoOfBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutoOfBus.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAutoOfBus.FormattingEnabled = true;
            this.comboBoxAutoOfBus.Items.AddRange(new object[] {
            "Personenauto",
            "Personenbusje"});
            this.comboBoxAutoOfBus.Location = new System.Drawing.Point(325, 132);
            this.comboBoxAutoOfBus.Name = "comboBoxAutoOfBus";
            this.comboBoxAutoOfBus.Size = new System.Drawing.Size(177, 35);
            this.comboBoxAutoOfBus.TabIndex = 3;
            // 
            // textBoxFoutStartDatum
            // 
            this.textBoxFoutStartDatum.BackColor = System.Drawing.Color.LightGray;
            this.textBoxFoutStartDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFoutStartDatum.Enabled = false;
            this.textBoxFoutStartDatum.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoutStartDatum.Location = new System.Drawing.Point(663, 176);
            this.textBoxFoutStartDatum.Name = "textBoxFoutStartDatum";
            this.textBoxFoutStartDatum.Size = new System.Drawing.Size(82, 27);
            this.textBoxFoutStartDatum.TabIndex = 18;
            this.textBoxFoutStartDatum.TabStop = false;
            // 
            // textBoxFoutEindDatum
            // 
            this.textBoxFoutEindDatum.BackColor = System.Drawing.Color.LightGray;
            this.textBoxFoutEindDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFoutEindDatum.Enabled = false;
            this.textBoxFoutEindDatum.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoutEindDatum.Location = new System.Drawing.Point(663, 216);
            this.textBoxFoutEindDatum.Name = "textBoxFoutEindDatum";
            this.textBoxFoutEindDatum.Size = new System.Drawing.Size(82, 27);
            this.textBoxFoutEindDatum.TabIndex = 19;
            this.textBoxFoutEindDatum.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 27);
            this.textBox1.TabIndex = 20;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Bedrag getankte brandstof";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBrandstofInput
            // 
            this.textBoxBrandstofInput.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrandstofInput.Location = new System.Drawing.Point(324, 295);
            this.textBoxBrandstofInput.MaxLength = 5;
            this.textBoxBrandstofInput.Name = "textBoxBrandstofInput";
            this.textBoxBrandstofInput.Size = new System.Drawing.Size(100, 34);
            this.textBoxBrandstofInput.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Autoverhuur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(872, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBrandstofInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxFoutEindDatum);
            this.Controls.Add(this.textBoxFoutStartDatum);
            this.Controls.Add(this.comboBoxAutoOfBus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.comboBoxEindJaar);
            this.Controls.Add(this.comboBoxStartJaar);
            this.Controls.Add(this.comboBoxEindMaand);
            this.Controls.Add(this.comboBoxStartMaand);
            this.Controls.Add(this.comboBoxEindDag);
            this.Controls.Add(this.comboBoxStartDag);
            this.Controls.Add(this.textBoxTotaalPrijs);
            this.Controls.Add(this.textBoxKilometerInput);
            this.Controls.Add(this.textBoxKilometer);
            this.Controls.Add(this.textBoxEindDatum);
            this.Controls.Add(this.textBoxStartDatum);
            this.Controls.Add(this.textBoxAutoOfBus);
            this.Controls.Add(this.textBoxFout);
            this.Controls.Add(this.textBoxWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Autoverhuur";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kosten Autoverhuur";
            this.Load += new System.EventHandler(this.Autoverhuur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWelcome;
        private System.Windows.Forms.TextBox textBoxFout;
        private System.Windows.Forms.TextBox textBoxAutoOfBus;
        private System.Windows.Forms.TextBox textBoxStartDatum;
        private System.Windows.Forms.TextBox textBoxEindDatum;
        private System.Windows.Forms.TextBox textBoxKilometer;
        private System.Windows.Forms.TextBox textBoxKilometerInput;
        private System.Windows.Forms.TextBox textBoxTotaalPrijs;
        private System.Windows.Forms.ComboBox comboBoxStartDag;
        private System.Windows.Forms.ComboBox comboBoxEindDag;
        private System.Windows.Forms.ComboBox comboBoxEindMaand;
        private System.Windows.Forms.ComboBox comboBoxStartMaand;
        private System.Windows.Forms.ComboBox comboBoxEindJaar;
        private System.Windows.Forms.ComboBox comboBoxStartJaar;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxAutoOfBus;
        private System.Windows.Forms.TextBox textBoxFoutStartDatum;
        private System.Windows.Forms.TextBox textBoxFoutEindDatum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxBrandstofInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

