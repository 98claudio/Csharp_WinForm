﻿namespace WinFormsApp6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(294, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira as dimensões do reservatório em cm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Largura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 87);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 121);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Comprimento:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(346, 167);
            button1.Name = "button1";
            button1.Size = new Size(183, 63);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 171);
            label5.Name = "label5";
            label5.Size = new Size(242, 20);
            label5.TabIndex = 8;
            label5.Text = "Insira seu consumo diário em litros:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 27);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 53);
            label6.Name = "label6";
            label6.Size = new Size(293, 20);
            label6.TabIndex = 10;
            label6.Text = "Capacidade total do reservatório em litros:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 87);
            label7.Name = "label7";
            label7.Size = new Size(247, 20);
            label7.TabIndex = 11;
            label7.Text = "Autonomia do reservatório em dias:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 121);
            label8.Name = "label8";
            label8.Size = new Size(183, 20);
            label8.TabIndex = 12;
            label8.Text = "Classificação do consumo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(645, 53);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(599, 87);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(535, 121);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
