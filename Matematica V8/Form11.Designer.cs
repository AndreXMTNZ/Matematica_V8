﻿namespace Matematica_V8
{
    partial class Devs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devs));
            rgs = new Button();
            SuspendLayout();
            // 
            // rgs
            // 
            rgs.BackColor = Color.FromArgb(35, 179, 179);
            rgs.Cursor = Cursors.Hand;
            rgs.FlatAppearance.BorderSize = 0;
            rgs.FlatStyle = FlatStyle.Flat;
            rgs.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            rgs.ForeColor = SystemColors.ActiveCaptionText;
            rgs.Location = new Point(538, 646);
            rgs.Name = "rgs";
            rgs.Size = new Size(202, 55);
            rgs.TabIndex = 0;
            rgs.Text = "Regresar";
            rgs.UseVisualStyleBackColor = false;
            rgs.Click += rgs_Click;
            // 
            // Devs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 713);
            Controls.Add(rgs);
            Name = "Devs";
            Text = "Creditos";
            ResumeLayout(false);
        }

        #endregion

        private Button rgs;
    }
}