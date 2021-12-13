
namespace hesapMakinasi
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
            this.calculate = new System.Windows.Forms.Button();
            this.resultLabel6 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.number2Text2 = new System.Windows.Forms.TextBox();
            this.number2Label = new System.Windows.Forms.Label();
            this.number1Text7 = new System.Windows.Forms.TextBox();
            this.number1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProcess = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculate.Location = new System.Drawing.Point(216, 250);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(95, 30);
            this.calculate.TabIndex = 20;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resultLabel6
            // 
            this.resultLabel6.AutoSize = true;
            this.resultLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultLabel6.Location = new System.Drawing.Point(216, 197);
            this.resultLabel6.Name = "resultLabel6";
            this.resultLabel6.Size = new System.Drawing.Size(57, 20);
            this.resultLabel6.TabIndex = 19;
            this.resultLabel6.Text = "--------";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tempLabel.Location = new System.Drawing.Point(139, 197);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(71, 20);
            this.tempLabel.TabIndex = 18;
            this.tempLabel.Text = "Result :";
            // 
            // number2Text2
            // 
            this.number2Text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number2Text2.Location = new System.Drawing.Point(216, 114);
            this.number2Text2.Name = "number2Text2";
            this.number2Text2.Size = new System.Drawing.Size(100, 26);
            this.number2Text2.TabIndex = 17;
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number2Label.Location = new System.Drawing.Point(114, 117);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(96, 20);
            this.number2Label.TabIndex = 16;
            this.number2Label.Text = "Number 2 :";
            // 
            // number1Text7
            // 
            this.number1Text7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number1Text7.Location = new System.Drawing.Point(216, 61);
            this.number1Text7.Name = "number1Text7";
            this.number1Text7.Size = new System.Drawing.Size(100, 26);
            this.number1Text7.TabIndex = 15;
            // 
            // number1Label
            // 
            this.number1Label.AutoSize = true;
            this.number1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number1Label.Location = new System.Drawing.Point(114, 64);
            this.number1Label.Name = "number1Label";
            this.number1Label.Size = new System.Drawing.Size(96, 20);
            this.number1Label.TabIndex = 14;
            this.number1Label.Text = "Number 1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Process Type :";
            // 
            // comboBoxProcess
            // 
            this.comboBoxProcess.FormattingEnabled = true;
            this.comboBoxProcess.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxProcess.Location = new System.Drawing.Point(216, 158);
            this.comboBoxProcess.Name = "comboBoxProcess";
            this.comboBoxProcess.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProcess.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 335);
            this.Controls.Add(this.comboBoxProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.resultLabel6);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.number2Text2);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number1Text7);
            this.Controls.Add(this.number1Label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label resultLabel6;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TextBox number2Text2;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.TextBox number1Text7;
        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProcess;
    }
}

