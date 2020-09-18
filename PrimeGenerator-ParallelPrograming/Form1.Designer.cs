namespace PrimeGenerator_ParallelPrograming
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
            this.SequencialBTN = new System.Windows.Forms.Button();
            this.LengthEndNUD = new System.Windows.Forms.NumericUpDown();
            this.ParallelBTN = new System.Windows.Forms.Button();
            this.TimeStampsTXT = new System.Windows.Forms.TextBox();
            this.LengthStartNUD = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeStamps = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LengthEndNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthStartNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SequencialBTN
            // 
            this.SequencialBTN.Location = new System.Drawing.Point(696, 65);
            this.SequencialBTN.Name = "SequencialBTN";
            this.SequencialBTN.Size = new System.Drawing.Size(93, 23);
            this.SequencialBTN.TabIndex = 2;
            this.SequencialBTN.Text = "Start Sequential";
            this.SequencialBTN.UseVisualStyleBackColor = true;
            this.SequencialBTN.Click += new System.EventHandler(this.SequencialBTN_Click);
            // 
            // LengthEndNUD
            // 
            this.LengthEndNUD.Location = new System.Drawing.Point(588, 39);
            this.LengthEndNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.LengthEndNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LengthEndNUD.Name = "LengthEndNUD";
            this.LengthEndNUD.Size = new System.Drawing.Size(201, 20);
            this.LengthEndNUD.TabIndex = 3;
            this.LengthEndNUD.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LengthEndNUD.ValueChanged += new System.EventHandler(this.LengthNUD_ValueChanged);
            // 
            // ParallelBTN
            // 
            this.ParallelBTN.Location = new System.Drawing.Point(587, 65);
            this.ParallelBTN.Name = "ParallelBTN";
            this.ParallelBTN.Size = new System.Drawing.Size(102, 23);
            this.ParallelBTN.TabIndex = 4;
            this.ParallelBTN.Text = "Start Parallel";
            this.ParallelBTN.UseVisualStyleBackColor = true;
            this.ParallelBTN.Click += new System.EventHandler(this.ParallelBTN_Click);
            // 
            // TimeStampsTXT
            // 
            this.TimeStampsTXT.Location = new System.Drawing.Point(349, 39);
            this.TimeStampsTXT.Multiline = true;
            this.TimeStampsTXT.Name = "TimeStampsTXT";
            this.TimeStampsTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TimeStampsTXT.Size = new System.Drawing.Size(232, 407);
            this.TimeStampsTXT.TabIndex = 5;
            // 
            // LengthStartNUD
            // 
            this.LengthStartNUD.Location = new System.Drawing.Point(588, 13);
            this.LengthStartNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthStartNUD.Name = "LengthStartNUD";
            this.LengthStartNUD.Size = new System.Drawing.Size(200, 20);
            this.LengthStartNUD.TabIndex = 6;
            this.LengthStartNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 407);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // TimeStamps
            // 
            this.TimeStamps.AutoSize = true;
            this.TimeStamps.Location = new System.Drawing.Point(346, 13);
            this.TimeStamps.Name = "TimeStamps";
            this.TimeStamps.Size = new System.Drawing.Size(65, 13);
            this.TimeStamps.TabIndex = 9;
            this.TimeStamps.Text = "TimeStamps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Primes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeStamps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LengthStartNUD);
            this.Controls.Add(this.TimeStampsTXT);
            this.Controls.Add(this.ParallelBTN);
            this.Controls.Add(this.LengthEndNUD);
            this.Controls.Add(this.SequencialBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LengthEndNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthStartNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SequencialBTN;
        private System.Windows.Forms.NumericUpDown LengthEndNUD;
        private System.Windows.Forms.Button ParallelBTN;
        private System.Windows.Forms.TextBox TimeStampsTXT;
        private System.Windows.Forms.NumericUpDown LengthStartNUD;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeStamps;
        private System.Windows.Forms.Label label2;
    }
}

