﻿namespace Yhteistyo
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
            OtsikkoLB = new Label();
            VaihdaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OtsikkoLB.Location = new Point(35, 27);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(87, 25);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Otstikko";
            // 
            // VaihdaBT
            // 
            VaihdaBT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VaihdaBT.Location = new Point(35, 79);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(93, 37);
            VaihdaBT.TabIndex = 1;
            VaihdaBT.Text = "Vaihda";
            VaihdaBT.UseVisualStyleBackColor = true;
            VaihdaBT.Click += VaihdaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 300);
            Controls.Add(VaihdaBT);
            Controls.Add(OtsikkoLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Button VaihdaBT;
    }
}
