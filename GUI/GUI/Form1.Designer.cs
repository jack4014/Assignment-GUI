﻿
namespace GUI
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
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Number1TextBox = new System.Windows.Forms.TextBox();
            this.Number2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 144);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(252, 96);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.TabStop = false;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Primes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Number1TextBox
            // 
            this.Number1TextBox.Location = new System.Drawing.Point(12, 23);
            this.Number1TextBox.Name = "Number1TextBox";
            this.Number1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Number1TextBox.TabIndex = 1;
            // 
            // Number2TextBox
            // 
            this.Number2TextBox.Location = new System.Drawing.Point(164, 23);
            this.Number2TextBox.Name = "Number2TextBox";
            this.Number2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Number2TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number2TextBox);
            this.Controls.Add(this.Number1TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Form1";
            this.Text = "Prime Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Number1TextBox;
        private System.Windows.Forms.TextBox Number2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox OutputTextBox;
    }
}

