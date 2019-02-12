namespace Stardew_Valley_Crop_Calculator
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.noFertilizerRad = new System.Windows.Forms.RadioButton();
            this.normalFertilizerRad = new System.Windows.Forms.RadioButton();
            this.qualityFertilizerRad = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(143, 59);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cauliflower",
            "Raddish",
            "Rhubarb",
            "Potato",
            "Blue Jazz"});
            this.comboBox1.Location = new System.Drawing.Point(143, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of seeds planted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crop type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Income:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noFertilizerRad
            // 
            this.noFertilizerRad.AutoSize = true;
            this.noFertilizerRad.Location = new System.Drawing.Point(454, 61);
            this.noFertilizerRad.Name = "noFertilizerRad";
            this.noFertilizerRad.Size = new System.Drawing.Size(77, 17);
            this.noFertilizerRad.TabIndex = 7;
            this.noFertilizerRad.Text = "No fertilizer";
            this.noFertilizerRad.UseVisualStyleBackColor = true;
            // 
            // normalFertilizerRad
            // 
            this.normalFertilizerRad.AutoSize = true;
            this.normalFertilizerRad.Location = new System.Drawing.Point(454, 88);
            this.normalFertilizerRad.Name = "normalFertilizerRad";
            this.normalFertilizerRad.Size = new System.Drawing.Size(63, 17);
            this.normalFertilizerRad.TabIndex = 8;
            this.normalFertilizerRad.TabStop = true;
            this.normalFertilizerRad.Text = "Fertilizer";
            this.normalFertilizerRad.UseVisualStyleBackColor = true;
            // 
            // qualityFertilizerRad
            // 
            this.qualityFertilizerRad.AutoSize = true;
            this.qualityFertilizerRad.Location = new System.Drawing.Point(454, 115);
            this.qualityFertilizerRad.Name = "qualityFertilizerRad";
            this.qualityFertilizerRad.Size = new System.Drawing.Size(95, 17);
            this.qualityFertilizerRad.TabIndex = 9;
            this.qualityFertilizerRad.TabStop = true;
            this.qualityFertilizerRad.Text = "Quality fertilizer";
            this.qualityFertilizerRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 260);
            this.Controls.Add(this.qualityFertilizerRad);
            this.Controls.Add(this.normalFertilizerRad);
            this.Controls.Add(this.noFertilizerRad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton noFertilizerRad;
        private System.Windows.Forms.RadioButton normalFertilizerRad;
        private System.Windows.Forms.RadioButton qualityFertilizerRad;
    }
}

