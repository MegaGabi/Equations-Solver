namespace WindowsFormsApplication2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLiniar = new System.Windows.Forms.RadioButton();
            this.radioButtonCvadratic = new System.Windows.Forms.RadioButton();
            this.radioButtonCubic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxA = new System.Windows.Forms.TextBox();
            this.BoxB = new System.Windows.Forms.TextBox();
            this.BoxC = new System.Windows.Forms.TextBox();
            this.Equation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxSolve = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCubic);
            this.groupBox1.Controls.Add(this.radioButtonCvadratic);
            this.groupBox1.Controls.Add(this.radioButtonLiniar);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Типы уровнений";
            // 
            // radioButtonLiniar
            // 
            this.radioButtonLiniar.AutoSize = true;
            this.radioButtonLiniar.Location = new System.Drawing.Point(6, 21);
            this.radioButtonLiniar.Name = "radioButtonLiniar";
            this.radioButtonLiniar.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLiniar.TabIndex = 0;
            this.radioButtonLiniar.TabStop = true;
            this.radioButtonLiniar.Text = "Линейное";
            this.radioButtonLiniar.UseVisualStyleBackColor = true;
            this.radioButtonLiniar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonCvadratic
            // 
            this.radioButtonCvadratic.AutoSize = true;
            this.radioButtonCvadratic.Location = new System.Drawing.Point(6, 44);
            this.radioButtonCvadratic.Name = "radioButtonCvadratic";
            this.radioButtonCvadratic.Size = new System.Drawing.Size(108, 17);
            this.radioButtonCvadratic.TabIndex = 1;
            this.radioButtonCvadratic.TabStop = true;
            this.radioButtonCvadratic.Text = "Квадратическое";
            this.radioButtonCvadratic.UseVisualStyleBackColor = true;
            this.radioButtonCvadratic.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonCubic
            // 
            this.radioButtonCubic.AutoSize = true;
            this.radioButtonCubic.Location = new System.Drawing.Point(6, 69);
            this.radioButtonCubic.Name = "radioButtonCubic";
            this.radioButtonCubic.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCubic.TabIndex = 2;
            this.radioButtonCubic.TabStop = true;
            this.radioButtonCubic.Text = "Кубическое";
            this.radioButtonCubic.UseVisualStyleBackColor = true;
            this.radioButtonCubic.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "c";
            // 
            // BoxA
            // 
            this.BoxA.Location = new System.Drawing.Point(36, 126);
            this.BoxA.Name = "BoxA";
            this.BoxA.Size = new System.Drawing.Size(100, 20);
            this.BoxA.TabIndex = 4;
            // 
            // BoxB
            // 
            this.BoxB.Location = new System.Drawing.Point(36, 152);
            this.BoxB.Name = "BoxB";
            this.BoxB.Size = new System.Drawing.Size(100, 20);
            this.BoxB.TabIndex = 5;
            // 
            // BoxC
            // 
            this.BoxC.Location = new System.Drawing.Point(36, 178);
            this.BoxC.Name = "BoxC";
            this.BoxC.Size = new System.Drawing.Size(100, 20);
            this.BoxC.TabIndex = 6;
            // 
            // Equation
            // 
            this.Equation.AutoSize = true;
            this.Equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equation.Location = new System.Drawing.Point(156, 46);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(64, 17);
            this.Equation.TabIndex = 7;
            this.Equation.Text = "Equation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "d";
            // 
            // BoxD
            // 
            this.BoxD.Location = new System.Drawing.Point(36, 204);
            this.BoxD.Name = "BoxD";
            this.BoxD.Size = new System.Drawing.Size(100, 20);
            this.BoxD.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxSolve
            // 
            this.BoxSolve.Location = new System.Drawing.Point(36, 259);
            this.BoxSolve.Name = "BoxSolve";
            this.BoxSolve.Size = new System.Drawing.Size(318, 20);
            this.BoxSolve.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxSolve);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Equation);
            this.Controls.Add(this.BoxC);
            this.Controls.Add(this.BoxB);
            this.Controls.Add(this.BoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Equations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCubic;
        private System.Windows.Forms.RadioButton radioButtonCvadratic;
        private System.Windows.Forms.RadioButton radioButtonLiniar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxA;
        private System.Windows.Forms.TextBox BoxB;
        private System.Windows.Forms.TextBox BoxC;
        private System.Windows.Forms.Label Equation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BoxSolve;
        private System.Windows.Forms.Label label5;

    }
}

