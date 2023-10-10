namespace Matematica_V8
{
    partial class mcd
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
            brnregresar = new Button();
            btnCalcular = new Button();
            label2 = new Label();
            txtB = new TextBox();
            label1 = new Label();
            txtA = new TextBox();
            label4 = new Label();
            txtX1 = new TextBox();
            btnLipiar = new Button();
            SuspendLayout();
            // 
            // brnregresar
            // 
            brnregresar.BackColor = Color.FromArgb(35, 179, 179);
            brnregresar.Cursor = Cursors.Hand;
            brnregresar.FlatAppearance.BorderSize = 0;
            brnregresar.FlatStyle = FlatStyle.Flat;
            brnregresar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            brnregresar.ForeColor = SystemColors.Control;
            brnregresar.Location = new Point(968, 626);
            brnregresar.Name = "brnregresar";
            brnregresar.Size = new Size(216, 53);
            brnregresar.TabIndex = 1;
            brnregresar.Text = "Regresar";
            brnregresar.UseVisualStyleBackColor = false;
            brnregresar.Click += brnregresar_Click_1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(35, 179, 179);
            btnCalcular.BackgroundImageLayout = ImageLayout.None;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(477, 620);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(213, 61);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(141, 410);
            label2.Name = "label2";
            label2.Size = new Size(34, 38);
            label2.TabIndex = 10;
            label2.Text = "b";
            // 
            // txtB
            // 
            txtB.Cursor = Cursors.IBeam;
            txtB.Location = new Point(179, 418);
            txtB.Name = "txtB";
            txtB.Size = new Size(186, 27);
            txtB.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(141, 257);
            label1.Name = "label1";
            label1.Size = new Size(32, 38);
            label1.TabIndex = 8;
            label1.Text = "a";
            // 
            // txtA
            // 
            txtA.Cursor = Cursors.IBeam;
            txtA.Location = new Point(179, 266);
            txtA.Name = "txtA";
            txtA.Size = new Size(186, 27);
            txtA.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(78, 53, 151);
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(614, 319);
            label4.Name = "label4";
            label4.Size = new Size(82, 38);
            label4.TabIndex = 14;
            label4.Text = "MCD";
            label4.Click += label4_Click;
            // 
            // txtX1
            // 
            txtX1.Enabled = false;
            txtX1.Location = new Point(547, 372);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(229, 27);
            txtX1.TabIndex = 15;
            txtX1.TextChanged += txtX1_TextChanged;
            // 
            // btnLipiar
            // 
            btnLipiar.BackColor = Color.FromArgb(35, 179, 179);
            btnLipiar.Cursor = Cursors.Hand;
            btnLipiar.FlatAppearance.BorderSize = 0;
            btnLipiar.FlatStyle = FlatStyle.Flat;
            btnLipiar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLipiar.ForeColor = SystemColors.Control;
            btnLipiar.Location = new Point(195, 622);
            btnLipiar.Name = "btnLipiar";
            btnLipiar.Size = new Size(224, 58);
            btnLipiar.TabIndex = 16;
            btnLipiar.Text = "Limpiar";
            btnLipiar.UseVisualStyleBackColor = false;
            btnLipiar.Click += btnLipiar_Click;
            // 
            // mcd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9;
            ClientSize = new Size(1262, 713);
            Controls.Add(btnLipiar);
            Controls.Add(label4);
            Controls.Add(txtX1);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(btnCalcular);
            Controls.Add(brnregresar);
            Name = "mcd";
            Text = "MCDracukeo";
            Load += mcd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button brnregresar;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtB;
        private Label label1;
        private TextBox txtA;
        private Label label4;
        private TextBox txtX1;
        private Button btnLipiar;
    }
}