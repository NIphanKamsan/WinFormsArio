namespace WinFormsArio
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            เลข = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 156);
            button1.TabIndex = 0;
            button1.Text = "Arrsy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(90, 203);
            button2.Name = "button2";
            button2.Size = new Size(94, 115);
            button2.TabIndex = 1;
            button2.Text = "Arrsy1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Turquoise;
            textBox1.Location = new Point(200, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 348);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Chartreuse;
            label1.Location = new Point(529, 39);
            label1.Name = "label1";
            label1.Size = new Size(249, 348);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(423, 176);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "ตัวหนังสือ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "รายชื่อพิมพ์";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "รายชื่อบันทึก";
            // 
            // เลข
            // 
            เลข.Location = new Point(423, 246);
            เลข.Name = "เลข";
            เลข.Size = new Size(94, 29);
            เลข.TabIndex = 7;
            เลข.Text = "เลข";
            เลข.UseVisualStyleBackColor = true;
            เลข.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(90, 345);
            button5.Name = "button5";
            button5.Size = new Size(94, 93);
            button5.TabIndex = 8;
            button5.Text = "arssy2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(เลข);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Button เลข;
        private Button button5;
    }
}
