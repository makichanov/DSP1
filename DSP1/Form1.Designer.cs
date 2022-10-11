namespace DSP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amplitudeField = new System.Windows.Forms.TextBox();
            this.frequencyField = new System.Windows.Forms.TextBox();
            this.initialPhaseField = new System.Windows.Forms.TextBox();
            this.samplingField = new System.Windows.Forms.TextBox();
            this.fillFactorField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sinusoid",
            "Pulse",
            "Triangle",
            "Sawtooth",
            "White noise"});
            this.comboBox1.Location = new System.Drawing.Point(24, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Sinusoid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // amplitudeField
            // 
            this.amplitudeField.Location = new System.Drawing.Point(24, 139);
            this.amplitudeField.Name = "amplitudeField";
            this.amplitudeField.Size = new System.Drawing.Size(151, 27);
            this.amplitudeField.TabIndex = 3;
            // 
            // frequencyField
            // 
            this.frequencyField.Location = new System.Drawing.Point(24, 191);
            this.frequencyField.Name = "frequencyField";
            this.frequencyField.Size = new System.Drawing.Size(151, 27);
            this.frequencyField.TabIndex = 4;
            // 
            // initialPhaseField
            // 
            this.initialPhaseField.Location = new System.Drawing.Point(24, 244);
            this.initialPhaseField.Name = "initialPhaseField";
            this.initialPhaseField.Size = new System.Drawing.Size(151, 27);
            this.initialPhaseField.TabIndex = 5;
            // 
            // samplingField
            // 
            this.samplingField.Location = new System.Drawing.Point(24, 295);
            this.samplingField.Name = "samplingField";
            this.samplingField.Size = new System.Drawing.Size(151, 27);
            this.samplingField.TabIndex = 6;
            // 
            // fillFactorField
            // 
            this.fillFactorField.Location = new System.Drawing.Point(24, 348);
            this.fillFactorField.Name = "fillFactorField";
            this.fillFactorField.Size = new System.Drawing.Size(151, 27);
            this.fillFactorField.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amplitude";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Initial phase (Radians)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sampling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fill factor (for Pulse)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fillFactorField);
            this.Controls.Add(this.samplingField);
            this.Controls.Add(this.initialPhaseField);
            this.Controls.Add(this.frequencyField);
            this.Controls.Add(this.amplitudeField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(215, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(215, 497);
            this.Name = "Form1";
            this.Text = "DSP1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox amplitudeField;
        private TextBox frequencyField;
        private TextBox initialPhaseField;
        private TextBox samplingField;
        private TextBox fillFactorField;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}