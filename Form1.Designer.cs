namespace cpu_scheduling
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
            this.radioButtonSTF = new System.Windows.Forms.RadioButton();
            this.radioButtonSRTF = new System.Windows.Forms.RadioButton();
            this.radioButtonP = new System.Windows.Forms.RadioButton();
            this.radioButtonFCFS = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1insert = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.process_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu_burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButtonPP = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonSTF
            // 
            this.radioButtonSTF.AutoSize = true;
            this.radioButtonSTF.Location = new System.Drawing.Point(79, 67);
            this.radioButtonSTF.Name = "radioButtonSTF";
            this.radioButtonSTF.Size = new System.Drawing.Size(137, 21);
            this.radioButtonSTF.TabIndex = 1;
            this.radioButtonSTF.TabStop = true;
            this.radioButtonSTF.Text = "shortest time first";
            this.radioButtonSTF.UseVisualStyleBackColor = true;
            this.radioButtonSTF.CheckedChanged += new System.EventHandler(this.radioButtonSTF_CheckedChanged);
            // 
            // radioButtonSRTF
            // 
            this.radioButtonSRTF.AutoSize = true;
            this.radioButtonSRTF.Location = new System.Drawing.Point(79, 94);
            this.radioButtonSRTF.Name = "radioButtonSRTF";
            this.radioButtonSRTF.Size = new System.Drawing.Size(207, 21);
            this.radioButtonSRTF.TabIndex = 2;
            this.radioButtonSRTF.TabStop = true;
            this.radioButtonSRTF.Text = "shortest remaining time first ";
            this.radioButtonSRTF.UseVisualStyleBackColor = true;
            this.radioButtonSRTF.CheckedChanged += new System.EventHandler(this.radioButtonSRTF_CheckedChanged);
            // 
            // radioButtonP
            // 
            this.radioButtonP.AutoSize = true;
            this.radioButtonP.Location = new System.Drawing.Point(79, 121);
            this.radioButtonP.Name = "radioButtonP";
            this.radioButtonP.Size = new System.Drawing.Size(174, 21);
            this.radioButtonP.TabIndex = 3;
            this.radioButtonP.TabStop = true;
            this.radioButtonP.Text = "priority non preemptive";
            this.radioButtonP.UseVisualStyleBackColor = true;
            this.radioButtonP.CheckedChanged += new System.EventHandler(this.radioButtonP_CheckedChanged);
            // 
            // radioButtonFCFS
            // 
            this.radioButtonFCFS.AutoSize = true;
            this.radioButtonFCFS.Location = new System.Drawing.Point(79, 148);
            this.radioButtonFCFS.Name = "radioButtonFCFS";
            this.radioButtonFCFS.Size = new System.Drawing.Size(164, 21);
            this.radioButtonFCFS.TabIndex = 4;
            this.radioButtonFCFS.TabStop = true;
            this.radioButtonFCFS.Text = "first come first served";
            this.radioButtonFCFS.UseVisualStyleBackColor = true;
            this.radioButtonFCFS.CheckedChanged += new System.EventHandler(this.radioButtonFCFS_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Number of processes";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 312);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1insert
            // 
            this.button1insert.Location = new System.Drawing.Point(227, 358);
            this.button1insert.Name = "button1insert";
            this.button1insert.Size = new System.Drawing.Size(75, 23);
            this.button1insert.TabIndex = 7;
            this.button1insert.Text = "Insert";
            this.button1insert.UseVisualStyleBackColor = true;
            this.button1insert.Click += new System.EventHandler(this.button1insert_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(227, 414);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process_number,
            this.priorty,
            this.arrival_time,
            this.cpu_burst});
            this.dataGridView2.Location = new System.Drawing.Point(333, 28);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(571, 423);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // process_number
            // 
            this.process_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.process_number.FillWeight = 4F;
            this.process_number.HeaderText = "Process Number";
            this.process_number.Name = "process_number";
            this.process_number.ReadOnly = true;
            // 
            // priorty
            // 
            this.priorty.HeaderText = "priorty";
            this.priorty.Name = "priorty";
            // 
            // arrival_time
            // 
            this.arrival_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrival_time.FillWeight = 2F;
            this.arrival_time.HeaderText = "Arrival Time";
            this.arrival_time.Name = "arrival_time";
            // 
            // cpu_burst
            // 
            this.cpu_burst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpu_burst.FillWeight = 2F;
            this.cpu_burst.HeaderText = "CPU Burst";
            this.cpu_burst.Name = "cpu_burst";
            // 
            // radioButton1
            // 
            this.radioButtonPP.AutoSize = true;
            this.radioButtonPP.Location = new System.Drawing.Point(79, 176);
            this.radioButtonPP.Name = "radioButton1";
            this.radioButtonPP.Size = new System.Drawing.Size(146, 21);
            this.radioButtonPP.TabIndex = 13;
            this.radioButtonPP.TabStop = true;
            this.radioButtonPP.Text = "priority preemptive";
            this.radioButtonPP.UseVisualStyleBackColor = true;
            this.radioButtonPP.CheckedChanged += new System.EventHandler(this.radioButtonPP_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 489);
            this.Controls.Add(this.radioButtonPP);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button1insert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonFCFS);
            this.Controls.Add(this.radioButtonP);
            this.Controls.Add(this.radioButtonSRTF);
            this.Controls.Add(this.radioButtonSTF);
            this.Name = "Form1";
            this.Text = "cpu scheduling";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSTF;
        private System.Windows.Forms.RadioButton radioButtonSRTF;
        private System.Windows.Forms.RadioButton radioButtonP;
        private System.Windows.Forms.RadioButton radioButtonFCFS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1insert;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorty;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu_burst;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioButtonPP;
    }
}

