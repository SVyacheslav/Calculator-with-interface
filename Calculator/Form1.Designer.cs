namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSqrt = new System.Windows.Forms.Button();
            this.ButtonSquare = new System.Windows.Forms.Button();
            this.ButtonSqrtX = new System.Windows.Forms.Button();
            this.ButtonMRC = new System.Windows.Forms.Button();
            this.ButtonMPlus = new System.Windows.Forms.Button();
            this.ButtonMMinus = new System.Windows.Forms.Button();
            this.ButtonMMult = new System.Windows.Forms.Button();
            this.ButtonMDiv = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonChangeSign = new System.Windows.Forms.Button();
            this.ButtonMult = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonCalc = new System.Windows.Forms.Button();
            this.ButtonDegreeY = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(275, 16);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(38, 40);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "0";
            this.labelNumber.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Crimson;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClear.Location = new System.Drawing.Point(12, 91);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(45, 40);
            this.ButtonClear.TabIndex = 1;
            this.ButtonClear.Text = "CE";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSqrt
            // 
            this.ButtonSqrt.BackColor = System.Drawing.Color.MediumOrchid;
            this.ButtonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSqrt.Location = new System.Drawing.Point(87, 91);
            this.ButtonSqrt.Name = "ButtonSqrt";
            this.ButtonSqrt.Size = new System.Drawing.Size(45, 40);
            this.ButtonSqrt.TabIndex = 2;
            this.ButtonSqrt.Text = "√";
            this.ButtonSqrt.UseVisualStyleBackColor = false;
            this.ButtonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // ButtonSquare
            // 
            this.ButtonSquare.BackColor = System.Drawing.Color.MediumOrchid;
            this.ButtonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSquare.Location = new System.Drawing.Point(153, 91);
            this.ButtonSquare.Name = "ButtonSquare";
            this.ButtonSquare.Size = new System.Drawing.Size(45, 40);
            this.ButtonSquare.TabIndex = 3;
            this.ButtonSquare.Text = "x^2";
            this.ButtonSquare.UseVisualStyleBackColor = false;
            this.ButtonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // ButtonSqrtX
            // 
            this.ButtonSqrtX.BackColor = System.Drawing.Color.MediumOrchid;
            this.ButtonSqrtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSqrtX.Location = new System.Drawing.Point(218, 91);
            this.ButtonSqrtX.Name = "ButtonSqrtX";
            this.ButtonSqrtX.Size = new System.Drawing.Size(45, 40);
            this.ButtonSqrtX.TabIndex = 4;
            this.ButtonSqrtX.Text = "x√";
            this.ButtonSqrtX.UseVisualStyleBackColor = false;
            this.ButtonSqrtX.Click += new System.EventHandler(this.ButtonSqrtX_Click);
            // 
            // ButtonMRC
            // 
            this.ButtonMRC.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMRC.Location = new System.Drawing.Point(12, 153);
            this.ButtonMRC.Name = "ButtonMRC";
            this.ButtonMRC.Size = new System.Drawing.Size(45, 40);
            this.ButtonMRC.TabIndex = 6;
            this.ButtonMRC.Text = "MRC";
            this.ButtonMRC.UseVisualStyleBackColor = false;
            this.ButtonMRC.Click += new System.EventHandler(this.ButtonMRC_Click);
            // 
            // ButtonMPlus
            // 
            this.ButtonMPlus.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMPlus.Location = new System.Drawing.Point(12, 217);
            this.ButtonMPlus.Name = "ButtonMPlus";
            this.ButtonMPlus.Size = new System.Drawing.Size(45, 40);
            this.ButtonMPlus.TabIndex = 7;
            this.ButtonMPlus.Text = "M+";
            this.ButtonMPlus.UseVisualStyleBackColor = false;
            this.ButtonMPlus.Click += new System.EventHandler(this.ButtonMPlus_Click);
            // 
            // ButtonMMinus
            // 
            this.ButtonMMinus.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMMinus.Location = new System.Drawing.Point(12, 281);
            this.ButtonMMinus.Name = "ButtonMMinus";
            this.ButtonMMinus.Size = new System.Drawing.Size(45, 40);
            this.ButtonMMinus.TabIndex = 8;
            this.ButtonMMinus.Text = "M-";
            this.ButtonMMinus.UseVisualStyleBackColor = false;
            this.ButtonMMinus.Click += new System.EventHandler(this.ButtonMMinus_Click);
            // 
            // ButtonMMult
            // 
            this.ButtonMMult.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMMult.Location = new System.Drawing.Point(12, 345);
            this.ButtonMMult.Name = "ButtonMMult";
            this.ButtonMMult.Size = new System.Drawing.Size(45, 40);
            this.ButtonMMult.TabIndex = 9;
            this.ButtonMMult.Text = "M×";
            this.ButtonMMult.UseVisualStyleBackColor = false;
            this.ButtonMMult.Click += new System.EventHandler(this.ButtonMMult_Click);
            // 
            // ButtonMDiv
            // 
            this.ButtonMDiv.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonMDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMDiv.Location = new System.Drawing.Point(12, 409);
            this.ButtonMDiv.Name = "ButtonMDiv";
            this.ButtonMDiv.Size = new System.Drawing.Size(45, 40);
            this.ButtonMDiv.TabIndex = 10;
            this.ButtonMDiv.Text = "M÷";
            this.ButtonMDiv.UseVisualStyleBackColor = false;
            this.ButtonMDiv.Click += new System.EventHandler(this.ButtonMDiv_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button7.Location = new System.Drawing.Point(87, 153);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(45, 40);
            this.Button7.TabIndex = 11;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button8.Location = new System.Drawing.Point(153, 153);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(45, 40);
            this.Button8.TabIndex = 12;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button9.Location = new System.Drawing.Point(218, 153);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(45, 40);
            this.Button9.TabIndex = 13;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button4.Location = new System.Drawing.Point(87, 217);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(45, 40);
            this.Button4.TabIndex = 14;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button5.Location = new System.Drawing.Point(153, 217);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(45, 40);
            this.Button5.TabIndex = 15;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button6.Location = new System.Drawing.Point(218, 217);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(45, 40);
            this.Button6.TabIndex = 16;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(87, 281);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(45, 40);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Location = new System.Drawing.Point(153, 281);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(45, 40);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button3.Location = new System.Drawing.Point(218, 281);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(45, 40);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPoint.Location = new System.Drawing.Point(87, 345);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(45, 40);
            this.ButtonPoint.TabIndex = 20;
            this.ButtonPoint.Text = ",";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button0.Location = new System.Drawing.Point(153, 345);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(45, 40);
            this.Button0.TabIndex = 21;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonChangeSign
            // 
            this.ButtonChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChangeSign.Location = new System.Drawing.Point(218, 345);
            this.ButtonChangeSign.Name = "ButtonChangeSign";
            this.ButtonChangeSign.Size = new System.Drawing.Size(45, 40);
            this.ButtonChangeSign.TabIndex = 22;
            this.ButtonChangeSign.Text = "+/-";
            this.ButtonChangeSign.UseVisualStyleBackColor = true;
            this.ButtonChangeSign.Click += new System.EventHandler(this.ButtonChangeSign_Click);
            // 
            // ButtonMult
            // 
            this.ButtonMult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMult.Location = new System.Drawing.Point(283, 153);
            this.ButtonMult.Name = "ButtonMult";
            this.ButtonMult.Size = new System.Drawing.Size(45, 40);
            this.ButtonMult.TabIndex = 23;
            this.ButtonMult.Text = "×";
            this.ButtonMult.UseVisualStyleBackColor = false;
            this.ButtonMult.Click += new System.EventHandler(this.ButtonMult_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDiv.Location = new System.Drawing.Point(283, 217);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(45, 40);
            this.ButtonDiv.TabIndex = 24;
            this.ButtonDiv.Text = "÷";
            this.ButtonDiv.UseVisualStyleBackColor = false;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.Location = new System.Drawing.Point(283, 281);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(45, 40);
            this.ButtonMinus.TabIndex = 25;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlus.Location = new System.Drawing.Point(283, 345);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(45, 104);
            this.ButtonPlus.TabIndex = 26;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonCalc
            // 
            this.ButtonCalc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCalc.Location = new System.Drawing.Point(155, 409);
            this.ButtonCalc.Name = "ButtonCalc";
            this.ButtonCalc.Size = new System.Drawing.Size(108, 40);
            this.ButtonCalc.TabIndex = 27;
            this.ButtonCalc.Text = "=";
            this.ButtonCalc.UseVisualStyleBackColor = false;
            this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // ButtonDegreeY
            // 
            this.ButtonDegreeY.BackColor = System.Drawing.Color.MediumOrchid;
            this.ButtonDegreeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDegreeY.Location = new System.Drawing.Point(283, 91);
            this.ButtonDegreeY.Name = "ButtonDegreeY";
            this.ButtonDegreeY.Size = new System.Drawing.Size(45, 40);
            this.ButtonDegreeY.TabIndex = 28;
            this.ButtonDegreeY.Text = "x^y";
            this.ButtonDegreeY.UseVisualStyleBackColor = false;
            this.ButtonDegreeY.Click += new System.EventHandler(this.ButtonDegreeY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 461);
            this.Controls.Add(this.ButtonDegreeY);
            this.Controls.Add(this.ButtonCalc);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonMult);
            this.Controls.Add(this.ButtonChangeSign);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonPoint);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.ButtonMDiv);
            this.Controls.Add(this.ButtonMMult);
            this.Controls.Add(this.ButtonMMinus);
            this.Controls.Add(this.ButtonMPlus);
            this.Controls.Add(this.ButtonMRC);
            this.Controls.Add(this.ButtonSqrtX);
            this.Controls.Add(this.ButtonSquare);
            this.Controls.Add(this.ButtonSqrt);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSqrt;
        private System.Windows.Forms.Button ButtonSquare;
        private System.Windows.Forms.Button ButtonSqrtX;
        private System.Windows.Forms.Button ButtonMRC;
        private System.Windows.Forms.Button ButtonMPlus;
        private System.Windows.Forms.Button ButtonMMinus;
        private System.Windows.Forms.Button ButtonMMult;
        private System.Windows.Forms.Button ButtonMDiv;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonChangeSign;
        private System.Windows.Forms.Button ButtonMult;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonCalc;
        private System.Windows.Forms.Button ButtonDegreeY;
    }
}

