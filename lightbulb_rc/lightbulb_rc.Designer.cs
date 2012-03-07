namespace lightbulb_rc
{
    partial class lightbulb_rc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_infname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_outfname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_density = new System.Windows.Forms.TextBox();
            this.txt_cap = new System.Windows.Forms.TextBox();
            this.txt_initvolt = new System.Windows.Forms.TextBox();
            this.txt_inittemp = new System.Windows.Forms.TextBox();
            this.txt_maxtemp = new System.Windows.Forms.TextBox();
            this.txt_minpower = new System.Windows.Forms.TextBox();
            this.txt_timestep = new System.Windows.Forms.TextBox();
            this.btn_simulate = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.bck_sim = new System.ComponentModel.BackgroundWorker();
            this.of_dialog = new System.Windows.Forms.OpenFileDialog();
            this.sf_dialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(588, 347);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btn_simulate);
            this.flowLayoutPanel1.Controls.Add(this.btn_exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 347);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.12329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_infname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_save, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_outfname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_load, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties File";
            // 
            // txt_infname
            // 
            this.txt_infname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_infname.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_infname.Location = new System.Drawing.Point(82, 3);
            this.txt_infname.Name = "txt_infname";
            this.txt_infname.Size = new System.Drawing.Size(146, 20);
            this.txt_infname.TabIndex = 1;
            this.txt_infname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_infval);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Liberation Sans", 8.25F);
            this.btn_save.Location = new System.Drawing.Point(234, 32);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(43, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_outfname
            // 
            this.txt_outfname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_outfname.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outfname.Location = new System.Drawing.Point(82, 32);
            this.txt_outfname.Name = "txt_outfname";
            this.txt_outfname.Size = new System.Drawing.Size(146, 20);
            this.txt_outfname.TabIndex = 3;
            this.txt_outfname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_outfval);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output File";
            // 
            // btn_load
            // 
            this.btn_load.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_load.Location = new System.Drawing.Point(234, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(43, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txt_length, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_area, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_density, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_cap, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_initvolt, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_inittemp, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txt_maxtemp, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txt_minpower, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_timestep, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Liberation Sans", 8.25F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 234);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(47, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length (mm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(45, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Area (mm^2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Density (kg/mm^3)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(30, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Capacitance (F)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(26, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Initial Voltage (V)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Initial Temperature (K)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Max Temperature (K)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(35, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Min Power (W)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Location = new System.Drawing.Point(35, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "Time Step (ms)";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(118, 3);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(159, 20);
            this.txt_length.TabIndex = 5;
            this.txt_length.Validating += new System.ComponentModel.CancelEventHandler(this.txt_lengthval);
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(118, 29);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(159, 20);
            this.txt_area.TabIndex = 6;
            this.txt_area.Validating += new System.ComponentModel.CancelEventHandler(this.txt_areaval);
            // 
            // txt_density
            // 
            this.txt_density.Location = new System.Drawing.Point(118, 55);
            this.txt_density.Name = "txt_density";
            this.txt_density.Size = new System.Drawing.Size(159, 20);
            this.txt_density.TabIndex = 7;
            this.txt_density.Validating += new System.ComponentModel.CancelEventHandler(this.txt_densityval);
            // 
            // txt_cap
            // 
            this.txt_cap.Location = new System.Drawing.Point(118, 81);
            this.txt_cap.Name = "txt_cap";
            this.txt_cap.Size = new System.Drawing.Size(159, 20);
            this.txt_cap.TabIndex = 8;
            this.txt_cap.Validating += new System.ComponentModel.CancelEventHandler(this.txt_capval);
            // 
            // txt_initvolt
            // 
            this.txt_initvolt.Location = new System.Drawing.Point(118, 107);
            this.txt_initvolt.Name = "txt_initvolt";
            this.txt_initvolt.Size = new System.Drawing.Size(159, 20);
            this.txt_initvolt.TabIndex = 9;
            this.txt_initvolt.Validating += new System.ComponentModel.CancelEventHandler(this.txt_initvoltval);
            // 
            // txt_inittemp
            // 
            this.txt_inittemp.Location = new System.Drawing.Point(118, 133);
            this.txt_inittemp.Name = "txt_inittemp";
            this.txt_inittemp.Size = new System.Drawing.Size(159, 20);
            this.txt_inittemp.TabIndex = 10;
            this.txt_inittemp.Validating += new System.ComponentModel.CancelEventHandler(this.txt_inittempval);
            // 
            // txt_maxtemp
            // 
            this.txt_maxtemp.Location = new System.Drawing.Point(118, 159);
            this.txt_maxtemp.Name = "txt_maxtemp";
            this.txt_maxtemp.Size = new System.Drawing.Size(159, 20);
            this.txt_maxtemp.TabIndex = 11;
            this.txt_maxtemp.Validating += new System.ComponentModel.CancelEventHandler(this.txt_maxtempval);
            // 
            // txt_minpower
            // 
            this.txt_minpower.Location = new System.Drawing.Point(118, 185);
            this.txt_minpower.Name = "txt_minpower";
            this.txt_minpower.Size = new System.Drawing.Size(159, 20);
            this.txt_minpower.TabIndex = 12;
            this.txt_minpower.Validating += new System.ComponentModel.CancelEventHandler(this.txt_minpowerval);
            // 
            // txt_timestep
            // 
            this.txt_timestep.Location = new System.Drawing.Point(118, 211);
            this.txt_timestep.Name = "txt_timestep";
            this.txt_timestep.Size = new System.Drawing.Size(159, 20);
            this.txt_timestep.TabIndex = 13;
            this.txt_timestep.Validating += new System.ComponentModel.CancelEventHandler(this.txt_timestepval);
            // 
            // btn_simulate
            // 
            this.btn_simulate.Font = new System.Drawing.Font("Liberation Sans", 8.25F);
            this.btn_simulate.Location = new System.Drawing.Point(3, 307);
            this.btn_simulate.Name = "btn_simulate";
            this.btn_simulate.Size = new System.Drawing.Size(112, 23);
            this.btn_simulate.TabIndex = 14;
            this.btn_simulate.Text = "Simulate";
            this.btn_simulate.UseVisualStyleBackColor = true;
            this.btn_simulate.Click += new System.EventHandler(this.btn_simulate_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.Font = new System.Drawing.Font("Liberation Sans", 8.25F);
            this.btn_exit.Location = new System.Drawing.Point(121, 307);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(42, 23);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bck_sim
            // 
            this.bck_sim.WorkerReportsProgress = true;
            this.bck_sim.WorkerSupportsCancellation = true;
            this.bck_sim.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bck_sim_DoWork);
            this.bck_sim.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bck_sim_RunWorkerCompleted);
            // 
            // of_dialog
            // 
            this.of_dialog.Filter = "Comma Seperated Value Files (*.csv)|*.csv|All Files (*.*)|*.*";
            // 
            // sf_dialog
            // 
            this.sf_dialog.Filter = "Comma Seperated Value Files (*.csv)|*.csv";
            // 
            // lightbulb_rc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 347);
            this.Controls.Add(this.splitContainer1);
            this.Name = "lightbulb_rc";
            this.Text = "Lightbulb RC";
            this.Load += new System.EventHandler(this.lightbulb_rc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_infname;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_outfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_simulate;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_density;
        private System.Windows.Forms.TextBox txt_cap;
        private System.Windows.Forms.TextBox txt_initvolt;
        private System.Windows.Forms.TextBox txt_inittemp;
        private System.Windows.Forms.TextBox txt_maxtemp;
        private System.Windows.Forms.TextBox txt_minpower;
        private System.Windows.Forms.TextBox txt_timestep;
        private System.ComponentModel.BackgroundWorker bck_sim;
        private System.Windows.Forms.OpenFileDialog of_dialog;
        private System.Windows.Forms.SaveFileDialog sf_dialog;
    }
}