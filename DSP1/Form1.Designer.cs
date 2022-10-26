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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fillFactorModulationField = new System.Windows.Forms.TextBox();
            this.initPhaseModulationField = new System.Windows.Forms.TextBox();
            this.frequencyModulationField = new System.Windows.Forms.TextBox();
            this.amplitudeModulationField = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noModulationRb = new System.Windows.Forms.RadioButton();
            this.freqModulationRb = new System.Windows.Forms.RadioButton();
            this.AmpModulationRb = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.addPolyharm = new System.Windows.Forms.Button();
            this.generatePolyharm = new System.Windows.Forms.Button();
            this.clearPolyharm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
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
            this.comboBox1.Location = new System.Drawing.Point(12, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Sinusoid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // amplitudeField
            // 
            this.amplitudeField.Location = new System.Drawing.Point(12, 97);
            this.amplitudeField.Name = "amplitudeField";
            this.amplitudeField.Size = new System.Drawing.Size(151, 27);
            this.amplitudeField.TabIndex = 3;
            // 
            // frequencyField
            // 
            this.frequencyField.Location = new System.Drawing.Point(12, 149);
            this.frequencyField.Name = "frequencyField";
            this.frequencyField.Size = new System.Drawing.Size(151, 27);
            this.frequencyField.TabIndex = 4;
            // 
            // initialPhaseField
            // 
            this.initialPhaseField.Location = new System.Drawing.Point(12, 202);
            this.initialPhaseField.Name = "initialPhaseField";
            this.initialPhaseField.Size = new System.Drawing.Size(151, 27);
            this.initialPhaseField.TabIndex = 5;
            // 
            // samplingField
            // 
            this.samplingField.Location = new System.Drawing.Point(177, 202);
            this.samplingField.Name = "samplingField";
            this.samplingField.Size = new System.Drawing.Size(151, 27);
            this.samplingField.TabIndex = 6;
            this.samplingField.TextChanged += new System.EventHandler(this.samplingField_TextChanged);
            // 
            // fillFactorField
            // 
            this.fillFactorField.Location = new System.Drawing.Point(12, 253);
            this.fillFactorField.Name = "fillFactorField";
            this.fillFactorField.Size = new System.Drawing.Size(151, 27);
            this.fillFactorField.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amplitude";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Initial phase (Radians)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sampling";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fill factor (for Pulse)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modulaion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fill factor (for Pulse)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Initial phase (Radians)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Frequency";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Amplitude";
            // 
            // fillFactorModulationField
            // 
            this.fillFactorModulationField.Location = new System.Drawing.Point(347, 253);
            this.fillFactorModulationField.Name = "fillFactorModulationField";
            this.fillFactorModulationField.Size = new System.Drawing.Size(151, 27);
            this.fillFactorModulationField.TabIndex = 19;
            this.fillFactorModulationField.TextChanged += new System.EventHandler(this.fillFactorModulationField_TextChanged);
            // 
            // initPhaseModulationField
            // 
            this.initPhaseModulationField.Location = new System.Drawing.Point(347, 202);
            this.initPhaseModulationField.Name = "initPhaseModulationField";
            this.initPhaseModulationField.Size = new System.Drawing.Size(151, 27);
            this.initPhaseModulationField.TabIndex = 17;
            // 
            // frequencyModulationField
            // 
            this.frequencyModulationField.Location = new System.Drawing.Point(347, 149);
            this.frequencyModulationField.Name = "frequencyModulationField";
            this.frequencyModulationField.Size = new System.Drawing.Size(151, 27);
            this.frequencyModulationField.TabIndex = 16;
            // 
            // amplitudeModulationField
            // 
            this.amplitudeModulationField.Location = new System.Drawing.Point(347, 97);
            this.amplitudeModulationField.Name = "amplitudeModulationField";
            this.amplitudeModulationField.Size = new System.Drawing.Size(151, 27);
            this.amplitudeModulationField.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sinusoid",
            "Pulse",
            "Triangle",
            "Sawtooth",
            "White noise"});
            this.comboBox2.Location = new System.Drawing.Point(347, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Sinusoid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noModulationRb);
            this.groupBox1.Controls.Add(this.freqModulationRb);
            this.groupBox1.Controls.Add(this.AmpModulationRb);
            this.groupBox1.Location = new System.Drawing.Point(177, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 117);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // noModulationRb
            // 
            this.noModulationRb.AutoSize = true;
            this.noModulationRb.Checked = true;
            this.noModulationRb.Location = new System.Drawing.Point(6, 25);
            this.noModulationRb.Name = "noModulationRb";
            this.noModulationRb.Size = new System.Drawing.Size(50, 24);
            this.noModulationRb.TabIndex = 2;
            this.noModulationRb.TabStop = true;
            this.noModulationRb.Text = "No";
            this.noModulationRb.UseVisualStyleBackColor = true;
            // 
            // freqModulationRb
            // 
            this.freqModulationRb.AutoSize = true;
            this.freqModulationRb.Location = new System.Drawing.Point(6, 85);
            this.freqModulationRb.Name = "freqModulationRb";
            this.freqModulationRb.Size = new System.Drawing.Size(97, 24);
            this.freqModulationRb.TabIndex = 1;
            this.freqModulationRb.TabStop = true;
            this.freqModulationRb.Text = "Frequency";
            this.freqModulationRb.UseVisualStyleBackColor = true;
            // 
            // AmpModulationRb
            // 
            this.AmpModulationRb.AutoSize = true;
            this.AmpModulationRb.Location = new System.Drawing.Point(6, 55);
            this.AmpModulationRb.Name = "AmpModulationRb";
            this.AmpModulationRb.Size = new System.Drawing.Size(100, 24);
            this.AmpModulationRb.TabIndex = 0;
            this.AmpModulationRb.TabStop = true;
            this.AmpModulationRb.Text = "Amplitude";
            this.AmpModulationRb.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Modulation Algorithm";
            // 
            // addPolyharm
            // 
            this.addPolyharm.Location = new System.Drawing.Point(12, 286);
            this.addPolyharm.Name = "addPolyharm";
            this.addPolyharm.Size = new System.Drawing.Size(179, 29);
            this.addPolyharm.TabIndex = 27;
            this.addPolyharm.Text = "Add above to polyharm.";
            this.addPolyharm.UseVisualStyleBackColor = true;
            this.addPolyharm.Click += new System.EventHandler(this.addPolyharm_Click);
            // 
            // generatePolyharm
            // 
            this.generatePolyharm.Location = new System.Drawing.Point(334, 286);
            this.generatePolyharm.Name = "generatePolyharm";
            this.generatePolyharm.Size = new System.Drawing.Size(155, 29);
            this.generatePolyharm.TabIndex = 28;
            this.generatePolyharm.Text = "Generate polyharm.";
            this.generatePolyharm.UseVisualStyleBackColor = true;
            this.generatePolyharm.Click += new System.EventHandler(this.generatePolyharm_Click);
            // 
            // clearPolyharm
            // 
            this.clearPolyharm.Location = new System.Drawing.Point(197, 286);
            this.clearPolyharm.Name = "clearPolyharm";
            this.clearPolyharm.Size = new System.Drawing.Size(131, 29);
            this.clearPolyharm.TabIndex = 29;
            this.clearPolyharm.Text = "Clear polyharm.";
            this.clearPolyharm.UseVisualStyleBackColor = true;
            this.clearPolyharm.Click += new System.EventHandler(this.clearPolyharm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 323);
            this.Controls.Add(this.clearPolyharm);
            this.Controls.Add(this.generatePolyharm);
            this.Controls.Add(this.addPolyharm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amplitudeModulationField);
            this.Controls.Add(this.fillFactorField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.samplingField);
            this.Controls.Add(this.frequencyModulationField);
            this.Controls.Add(this.initialPhaseField);
            this.Controls.Add(this.fillFactorModulationField);
            this.Controls.Add(this.frequencyField);
            this.Controls.Add(this.initPhaseModulationField);
            this.Controls.Add(this.amplitudeField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 370);
            this.Name = "Form1";
            this.Text = "DSP1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox fillFactorModulationField;
        private TextBox initPhaseModulationField;
        private TextBox frequencyModulationField;
        private TextBox amplitudeModulationField;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private RadioButton noModulationRb;
        private RadioButton freqModulationRb;
        private RadioButton AmpModulationRb;
        private Label label13;
        private Button addPolyharm;
        private Button generatePolyharm;
        private Button clearPolyharm;
    }
}