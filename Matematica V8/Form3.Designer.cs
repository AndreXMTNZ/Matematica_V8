﻿namespace Matematica_V8
{
    partial class aagudos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aagudos));
            txtAnguloB = new TextBox();
            txtAnguloC = new TextBox();
            txtHipotenusa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtCatetoMayor = new TextBox();
            label2 = new Label();
            txtCatetoMenor = new TextBox();
            label1 = new Label();
            LimpiarButton = new Button();
            button1 = new Button();
            btnrg = new Button();
            SuspendLayout();
            // 
            // txtAnguloB
            // 
            txtAnguloB.Enabled = false;
            txtAnguloB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnguloB.Location = new Point(1073, 266);
            txtAnguloB.Margin = new Padding(3, 2, 3, 2);
            txtAnguloB.Name = "txtAnguloB";
            txtAnguloB.Size = new Size(133, 39);
            txtAnguloB.TabIndex = 38;
            // 
            // txtAnguloC
            // 
            txtAnguloC.Enabled = false;
            txtAnguloC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnguloC.Location = new Point(911, 443);
            txtAnguloC.Margin = new Padding(3, 2, 3, 2);
            txtAnguloC.Name = "txtAnguloC";
            txtAnguloC.Size = new Size(133, 39);
            txtAnguloC.TabIndex = 37;
            // 
            // txtHipotenusa
            // 
            txtHipotenusa.Enabled = false;
            txtHipotenusa.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtHipotenusa.Location = new Point(803, 254);
            txtHipotenusa.Margin = new Padding(3, 2, 3, 2);
            txtHipotenusa.Name = "txtHipotenusa";
            txtHipotenusa.Size = new Size(135, 35);
            txtHipotenusa.TabIndex = 36;
            txtHipotenusa.TextChanged += txtHipotenusa_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(78, 53, 151);
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(883, 496);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 35;
            label5.Text = "Angulo C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(78, 53, 151);
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1068, 347);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 34;
            label4.Text = "Angulo B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(78, 53, 151);
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(718, 199);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 33;
            label3.Text = "Hipotenusa";
            // 
            // txtCatetoMayor
            // 
            txtCatetoMayor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCatetoMayor.Location = new Point(207, 303);
            txtCatetoMayor.Margin = new Padding(3, 2, 3, 2);
            txtCatetoMayor.Name = "txtCatetoMayor";
            txtCatetoMayor.Size = new Size(124, 39);
            txtCatetoMayor.TabIndex = 32;
            txtCatetoMayor.TextChanged += txtCatetoMayor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(46, 303);
            label2.Name = "label2";
            label2.Size = new Size(154, 30);
            label2.TabIndex = 31;
            label2.Text = "Cateto mayor";
            label2.Click += label2_Click;
            // 
            // txtCatetoMenor
            // 
            txtCatetoMenor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCatetoMenor.Location = new Point(207, 235);
            txtCatetoMenor.Margin = new Padding(3, 2, 3, 2);
            txtCatetoMenor.Name = "txtCatetoMenor";
            txtCatetoMenor.Size = new Size(124, 39);
            txtCatetoMenor.TabIndex = 30;
            txtCatetoMenor.TextChanged += txtCatetoMenor_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(46, 235);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 29;
            label1.Text = "Cateto menor";
            label1.Click += label1_Click;
            // 
            // LimpiarButton
            // 
            LimpiarButton.BackColor = Color.FromArgb(35, 179, 179);
            LimpiarButton.BackgroundImageLayout = ImageLayout.None;
            LimpiarButton.Cursor = Cursors.Hand;
            LimpiarButton.FlatAppearance.BorderSize = 0;
            LimpiarButton.FlatStyle = FlatStyle.Flat;
            LimpiarButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LimpiarButton.ForeColor = SystemColors.Control;
            LimpiarButton.Location = new Point(222, 628);
            LimpiarButton.Margin = new Padding(3, 2, 3, 2);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(175, 44);
            LimpiarButton.TabIndex = 28;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = false;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 179, 179);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(222, 532);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(175, 44);
            button1.TabIndex = 27;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnrg
            // 
            btnrg.BackColor = Color.FromArgb(35, 179, 179);
            btnrg.BackgroundImageLayout = ImageLayout.None;
            btnrg.Cursor = Cursors.Hand;
            btnrg.FlatAppearance.BorderSize = 0;
            btnrg.FlatStyle = FlatStyle.Flat;
            btnrg.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnrg.ForeColor = SystemColors.Control;
            btnrg.Location = new Point(991, 628);
            btnrg.Margin = new Padding(3, 2, 3, 2);
            btnrg.Name = "btnrg";
            btnrg.Size = new Size(175, 44);
            btnrg.TabIndex = 26;
            btnrg.Text = "Regresar";
            btnrg.UseVisualStyleBackColor = false;
            btnrg.Click += btnrg_Click;
            // 
            // aagudos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 721);
            Controls.Add(txtAnguloB);
            Controls.Add(txtAnguloC);
            Controls.Add(txtHipotenusa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCatetoMayor);
            Controls.Add(label2);
            Controls.Add(txtCatetoMenor);
            Controls.Add(label1);
            Controls.Add(LimpiarButton);
            Controls.Add(button1);
            Controls.Add(btnrg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "aagudos";
            Text = "Angulos Agudos";
            Load += aagudos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnguloB;
        private TextBox txtAnguloC;
        private TextBox txtHipotenusa;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtCatetoMayor;
        private Label label2;
        private TextBox txtCatetoMenor;
        private Label label1;
        private Button LimpiarButton;
        private Button button1;
        private Button btnrg;
    }
}