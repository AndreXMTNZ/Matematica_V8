namespace Matematica_V8
{
    partial class PlanoC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanoC));
            txtX = new TextBox();
            txtY = new TextBox();
            btnVerificar = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxPlano = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlano).BeginInit();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtX.Location = new Point(250, 270);
            txtX.Name = "txtX";
            txtX.Size = new Size(189, 39);
            txtX.TabIndex = 0;
            // 
            // txtY
            // 
            txtY.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtY.Location = new Point(250, 184);
            txtY.Name = "txtY";
            txtY.Size = new Size(189, 39);
            txtY.TabIndex = 1;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(35, 179, 179);
            btnVerificar.Cursor = Cursors.Hand;
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.ForeColor = Color.Transparent;
            btnVerificar.Location = new Point(207, 621);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(201, 60);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxPlano
            // 
            pictureBoxPlano.BackColor = Color.FromArgb(78, 53, 151);
            pictureBoxPlano.Location = new Point(250, 165);
            pictureBoxPlano.Name = "pictureBoxPlano";
            pictureBoxPlano.Size = new Size(762, 426);
            pictureBoxPlano.TabIndex = 4;
            pictureBoxPlano.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 187);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 5;
            label1.Text = "Eje X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 270);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 6;
            label2.Text = "Eje Y";
            // 
            // PlanoC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 721);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(pictureBoxPlano);
            Controls.Add(pictureBox1);
            Controls.Add(btnVerificar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlanoC";
            Text = "Plano Cartesiano";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlano).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX;
        private TextBox txtY;
        private Button btnVerificar;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxPlano;
        private Label label1;
        private Label label2;
    }
}