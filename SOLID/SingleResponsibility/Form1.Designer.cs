﻿namespace SingleResponsibility
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
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            buttonCreate = new Button();
            buttonChangeColor = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(77, 73);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(100, 23);
            textBoxProductName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(77, 102);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(91, 131);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(86, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Oluştur";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonChangeColor
            // 
            buttonChangeColor.Location = new Point(65, 12);
            buttonChangeColor.Name = "buttonChangeColor";
            buttonChangeColor.Size = new Size(174, 23);
            buttonChangeColor.TabIndex = 3;
            buttonChangeColor.Text = "Arkaplan rengini değiştir";
            buttonChangeColor.UseVisualStyleBackColor = true;
            buttonChangeColor.Click += buttonChangeColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 237);
            Controls.Add(buttonChangeColor);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProductName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private TextBox textBoxPrice;
        private Button buttonCreate;
        private Button buttonChangeColor;
    }
}
