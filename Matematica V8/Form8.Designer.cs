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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mcd));
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
            brnregresar.Location = new Point(999, 629);
            brnregresar.Margin = new Padding(3, 2, 3, 2);
            brnregresar.Name = "brnregresar";
            brnregresar.Size = new Size(189, 40);
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
            btnCalcular.Location = new Point(554, 623);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(186, 46);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(242, 388);
            label2.Name = "label2";
            label2.Size = new Size(29, 32);
            label2.TabIndex = 10;
            label2.Text = "b";
            // 
            // txtB
            // 
            txtB.Cursor = Cursors.IBeam;
            txtB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(277, 391);
            txtB.Margin = new Padding(3, 2, 3, 2);
            txtB.Name = "txtB";
            txtB.Size = new Size(163, 29);
            txtB.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(244, 247);
            label1.Name = "label1";
            label1.Size = new Size(27, 32);
            label1.TabIndex = 8;
            label1.Text = "a";
            // 
            // txtA
            // 
            txtA.Cursor = Cursors.IBeam;
            txtA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(277, 250);
            txtA.Margin = new Padding(3, 2, 3, 2);
            txtA.Name = "txtA";
            txtA.Size = new Size(163, 29);
            txtA.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(78, 53, 151);
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(539, 293);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 14;
            label4.Text = "MCD";
            label4.Click += label4_Click;
            // 
            // txtX1
            // 
            txtX1.Enabled = false;
            txtX1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtX1.Location = new Point(539, 327);
            txtX1.Margin = new Padding(3, 2, 3, 2);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(201, 29);
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
            btnLipiar.Location = new Point(219, 623);
            btnLipiar.Margin = new Padding(3, 2, 3, 2);
            btnLipiar.Name = "btnLipiar";
            btnLipiar.Size = new Size(196, 44);
            btnLipiar.TabIndex = 16;
            btnLipiar.Text = "Limpiar";
            btnLipiar.UseVisualStyleBackColor = false;
            btnLipiar.Click += btnLipiar_Click;
            // 
            // mcd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 721);
            Controls.Add(btnLipiar);
            Controls.Add(label4);
            Controls.Add(txtX1);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(btnCalcular);
            Controls.Add(brnregresar);
            Margin = new Padding(3, 2, 3, 2);
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