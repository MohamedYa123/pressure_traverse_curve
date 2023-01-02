namespace PressureTraverseCurve
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YW = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.WL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TWF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.THF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PHF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.YG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GLR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.API = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.to1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 885);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "DRAW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(710, 53);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1185, 815);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(955, 907);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(605, 30);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.YW);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Q);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.WC);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.WL);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TWF);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.THF);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PHF);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.YG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.GLR);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.OM);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.API);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, -35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 791);
            this.panel1.TabIndex = 4;
            // 
            // YW
            // 
            this.YW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YW.Location = new System.Drawing.Point(318, 737);
            this.YW.Name = "YW";
            this.YW.Size = new System.Drawing.Size(259, 27);
            this.YW.TabIndex = 25;
            this.YW.Text = "1.05";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 740);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Specific gravity of water (gw):";
            // 
            // Q
            // 
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.Location = new System.Drawing.Point(318, 690);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(259, 27);
            this.Q.TabIndex = 23;
            this.Q.Text = "30";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 693);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Interfacial tension (s):";
            // 
            // WC
            // 
            this.WC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC.Location = new System.Drawing.Point(318, 639);
            this.WC.Name = "WC";
            this.WC.Size = new System.Drawing.Size(259, 27);
            this.WC.TabIndex = 21;
            this.WC.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Water cut (WC):";
            // 
            // WL
            // 
            this.WL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WL.Location = new System.Drawing.Point(318, 594);
            this.WL.Name = "WL";
            this.WL.Size = new System.Drawing.Size(259, 27);
            this.WL.TabIndex = 19;
            this.WL.Text = "758";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 597);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Liquid production rate (qL):";
            // 
            // TWF
            // 
            this.TWF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWF.Location = new System.Drawing.Point(318, 545);
            this.TWF.Name = "TWF";
            this.TWF.Size = new System.Drawing.Size(259, 27);
            this.TWF.TabIndex = 17;
            this.TWF.Text = "180";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Flowing temperature at tubing shoe (twf):";
            // 
            // THF
            // 
            this.THF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THF.Location = new System.Drawing.Point(318, 487);
            this.THF.Name = "THF";
            this.THF.Size = new System.Drawing.Size(259, 27);
            this.THF.TabIndex = 15;
            this.THF.Text = "80";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Flowing tubing head temperature (thf):";
            // 
            // PHF
            // 
            this.PHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHF.Location = new System.Drawing.Point(318, 431);
            this.PHF.Name = "PHF";
            this.PHF.Size = new System.Drawing.Size(259, 27);
            this.PHF.TabIndex = 13;
            this.PHF.Text = "200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Flowing tubing head pressure (phf):";
            // 
            // YG
            // 
            this.YG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YG.Location = new System.Drawing.Point(318, 378);
            this.YG.Name = "YG";
            this.YG.Size = new System.Drawing.Size(259, 27);
            this.YG.TabIndex = 11;
            this.YG.Text = "0.7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gas specific gravity (yg):";
            // 
            // GLR
            // 
            this.GLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLR.Location = new System.Drawing.Point(318, 327);
            this.GLR.Name = "GLR";
            this.GLR.Size = new System.Drawing.Size(259, 27);
            this.GLR.TabIndex = 9;
            this.GLR.Text = "75";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Production GLR (GLR):";
            // 
            // OM
            // 
            this.OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OM.Location = new System.Drawing.Point(318, 265);
            this.OM.Name = "OM";
            this.OM.Size = new System.Drawing.Size(259, 27);
            this.OM.TabIndex = 7;
            this.OM.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oil viscosity (cp):";
            // 
            // API
            // 
            this.API.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.API.Location = new System.Drawing.Point(318, 214);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(259, 27);
            this.API.TabIndex = 5;
            this.API.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oil gravity (API):";
            // 
            // TID
            // 
            this.TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID.Location = new System.Drawing.Point(318, 157);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(259, 27);
            this.TID.TabIndex = 3;
            this.TID.Text = "1.995";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tubing inner diameter (dti):";
            // 
            // DO
            // 
            this.DO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO.Location = new System.Drawing.Point(318, 103);
            this.DO.Name = "DO";
            this.DO.Size = new System.Drawing.Size(259, 27);
            this.DO.TabIndex = 1;
            this.DO.Text = "9700";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1207, 882);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 831);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Step";
            // 
            // step1
            // 
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1.Location = new System.Drawing.Point(140, 830);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(165, 27);
            this.step1.TabIndex = 36;
            this.step1.Text = "100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 793);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "to";
            // 
            // to1
            // 
            this.to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to1.Location = new System.Drawing.Point(424, 793);
            this.to1.Name = "to1";
            this.to1.Size = new System.Drawing.Size(165, 27);
            this.to1.TabIndex = 34;
            this.to1.Text = "500";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 793);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "from";
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(140, 793);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(165, 27);
            this.from.TabIndex = 32;
            this.from.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(1152, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(372, 37);
            this.label18.TabIndex = 38;
            this.label18.Text = "Pressure Travers Curve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.to1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pressure Traverse Curve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox THF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PHF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GLR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox API;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TWF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Q;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox YW;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox step1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox to1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label18;
    }
}

