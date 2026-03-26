namespace SimpleCalculator
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
            title = new Label();
            textResultBox = new TextBox();
            textInputBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonAdd = new Button();
            buttonCal = new Button();
            buttonSub = new Button();
            buttonMulti = new Button();
            buttonDiv = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            buttonDel = new Button();
            buttonDot = new Button();
            buttonPM = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("맑은 고딕", 20F);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(367, 60);
            title.TabIndex = 0;
            title.Text = "Simple Calculator";
            // 
            // textResultBox
            // 
            textResultBox.Font = new Font("맑은 고딕", 15F);
            textResultBox.Location = new Point(23, 88);
            textResultBox.Name = "textResultBox";
            textResultBox.Size = new Size(329, 41);
            textResultBox.TabIndex = 1;
            // 
            // textInputBox
            // 
            textInputBox.Font = new Font("맑은 고딕", 15F);
            textInputBox.Location = new Point(23, 146);
            textInputBox.Name = "textInputBox";
            textInputBox.Size = new Size(329, 41);
            textInputBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F);
            button1.Location = new Point(23, 345);
            button1.Name = "button1";
            button1.Size = new Size(72, 47);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15F);
            button2.Location = new Point(101, 345);
            button2.Name = "button2";
            button2.Size = new Size(72, 47);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 15F);
            button3.Location = new Point(179, 345);
            button3.Name = "button3";
            button3.Size = new Size(72, 47);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 15F);
            button4.Location = new Point(23, 398);
            button4.Name = "button4";
            button4.Size = new Size(72, 47);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("맑은 고딕", 15F);
            button5.Location = new Point(101, 398);
            button5.Name = "button5";
            button5.Size = new Size(72, 47);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 15F);
            button6.Location = new Point(179, 398);
            button6.Name = "button6";
            button6.Size = new Size(72, 47);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("맑은 고딕", 15F);
            button7.Location = new Point(23, 451);
            button7.Name = "button7";
            button7.Size = new Size(72, 47);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 15F);
            button8.Location = new Point(101, 451);
            button8.Name = "button8";
            button8.Size = new Size(72, 47);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("맑은 고딕", 15F);
            button9.Location = new Point(179, 451);
            button9.Name = "button9";
            button9.Size = new Size(72, 47);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("맑은 고딕", 15F);
            button0.Location = new Point(101, 504);
            button0.Name = "button0";
            button0.Size = new Size(72, 47);
            button0.TabIndex = 12;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("맑은 고딕", 15F);
            buttonAdd.Location = new Point(257, 292);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(72, 47);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCal
            // 
            buttonCal.Font = new Font("맑은 고딕", 15F);
            buttonCal.Location = new Point(257, 504);
            buttonCal.Name = "buttonCal";
            buttonCal.Size = new Size(72, 47);
            buttonCal.TabIndex = 14;
            buttonCal.Text = "=";
            buttonCal.UseVisualStyleBackColor = true;
            buttonCal.Click += buttonCal_Click;
            // 
            // buttonSub
            // 
            buttonSub.Font = new Font("맑은 고딕", 15F);
            buttonSub.Location = new Point(257, 345);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(72, 47);
            buttonSub.TabIndex = 15;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Font = new Font("맑은 고딕", 15F);
            buttonMulti.Location = new Point(257, 398);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(72, 47);
            buttonMulti.TabIndex = 16;
            buttonMulti.Text = "×";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("맑은 고딕", 15F);
            buttonDiv.Location = new Point(257, 451);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(72, 47);
            buttonDiv.TabIndex = 17;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("맑은 고딕", 15F);
            buttonCE.Location = new Point(23, 292);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(72, 47);
            buttonCE.TabIndex = 18;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("맑은 고딕", 15F);
            buttonC.Location = new Point(101, 292);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(72, 47);
            buttonC.TabIndex = 19;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("맑은 고딕", 15F);
            buttonDel.Location = new Point(179, 292);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(72, 47);
            buttonDel.TabIndex = 20;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("맑은 고딕", 15F);
            buttonDot.Location = new Point(179, 504);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(72, 47);
            buttonDot.TabIndex = 21;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonPM
            // 
            buttonPM.Font = new Font("맑은 고딕", 15F);
            buttonPM.Location = new Point(23, 504);
            buttonPM.Name = "buttonPM";
            buttonPM.Size = new Size(72, 47);
            buttonPM.TabIndex = 22;
            buttonPM.Text = "+/-";
            buttonPM.UseVisualStyleBackColor = true;
            buttonPM.Click += buttonPM_Click;
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 574);
            Controls.Add(buttonPM);
            Controls.Add(buttonDot);
            Controls.Add(buttonDel);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSub);
            Controls.Add(buttonCal);
            Controls.Add(buttonAdd);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textInputBox);
            Controls.Add(textResultBox);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox textResultBox;
        private TextBox textInputBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonAdd;
        private Button buttonCal;
        private Button buttonSub;
        private Button buttonMulti;
        private Button buttonDiv;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonDel;
        private Button buttonDot;
        private Button buttonPM;
    }
}
