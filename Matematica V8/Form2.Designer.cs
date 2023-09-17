namespace Matematica_V8
{
    partial class Ecuadratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecuadratica));
            brnregresar = new Button();
            btnLipiar = new Button();
            btnCalcular = new Button();
            txtA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtB = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            label4 = new Label();
            txtX1 = new TextBox();
            label5 = new Label();
            txtX2 = new TextBox();
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
            brnregresar.Location = new Point(921, 604);
            brnregresar.Name = "brnregresar";
            brnregresar.Size = new Size(256, 70);
            brnregresar.TabIndex = 0;
            brnregresar.Text = "Regresar";
            brnregresar.UseVisualStyleBackColor = false;
            brnregresar.Click += brnregresar_Click;
            // 
            // btnLipiar
            // 
            btnLipiar.BackColor = Color.FromArgb(35, 179, 179);
            btnLipiar.Cursor = Cursors.Hand;
            btnLipiar.FlatAppearance.BorderSize = 0;
            btnLipiar.FlatStyle = FlatStyle.Flat;
            btnLipiar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLipiar.ForeColor = SystemColors.Control;
            btnLipiar.Location = new Point(922, 449);
            btnLipiar.Name = "btnLipiar";
            btnLipiar.Size = new Size(256, 72);
            btnLipiar.TabIndex = 1;
            btnLipiar.Text = "Limpiar";
            btnLipiar.UseVisualStyleBackColor = false;
            btnLipiar.Click += btnLipiar_Click;
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
            btnCalcular.Location = new Point(262, 623);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(266, 68);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtA
            // 
            txtA.Cursor = Cursors.IBeam;
            txtA.Location = new Point(105, 375);
            txtA.Name = "txtA";
            txtA.Size = new Size(186, 27);
            txtA.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(67, 366);
            label1.Name = "label1";
            label1.Size = new Size(32, 38);
            label1.TabIndex = 4;
            label1.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(67, 429);
            label2.Name = "label2";
            label2.Size = new Size(34, 38);
            label2.TabIndex = 6;
            label2.Text = "b";
            // 
            // txtB
            // 
            txtB.Cursor = Cursors.IBeam;
            txtB.Location = new Point(105, 438);
            txtB.Name = "txtB";
            txtB.Size = new Size(186, 27);
            txtB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(78, 53, 151);
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(67, 496);
            label3.Name = "label3";
            label3.Size = new Size(30, 38);
            label3.TabIndex = 8;
            label3.Text = "c";
            // 
            // txtC
            // 
            txtC.Cursor = Cursors.IBeam;
            txtC.Location = new Point(105, 505);
            txtC.Name = "txtC";
            txtC.Size = new Size(186, 27);
            txtC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(78, 53, 151);
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(519, 366);
            label4.Name = "label4";
            label4.Size = new Size(48, 38);
            label4.TabIndex = 10;
            label4.Text = "x1";
            // 
            // txtX1
            // 
            /*txtX1.Cursor = Cursors.No;
            txtX1.Enabled = false;
            txtX1.Location = new Point(573, 375);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(186, 27);
            txtX1.TabIndex = 9;
            txtX1.TextChanged += txtX1_TextChanged;*/
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(78, 53, 151);
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(519, 429);
            label5.Name = "label5";
            label5.Size = new Size(48, 38);
            label5.TabIndex = 12;
            label5.Text = "x2";
            // 
            // txtX2
            // 
            txtX2.Cursor = Cursors.No;
            txtX2.Enabled = false;
            txtX2.Location = new Point(573, 440);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(186, 27);
            txtX2.TabIndex = 11;
            // 
            // Ecuadratica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 722);
            Controls.Add(label5);
            Controls.Add(txtX2);
            Controls.Add(label4);
            Controls.Add(txtX1);
            Controls.Add(label3);
            Controls.Add(txtC);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(btnCalcular);
            Controls.Add(btnLipiar);
            Controls.Add(brnregresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Ecuadratica";
            Text = "Ecuadratica";
            Load += Ecuadratica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button brnregresar;
        private Button btnLipiar;
        private Button btnCalcular;
        private TextBox txtA;
        private Label label1;
        private Label label2;
        private TextBox txtB;
        private Label label3;
        private TextBox txtC;
        private Label label4;
        private TextBox txtX1;
        private Label label5;
        private TextBox txtX2;
    }
}