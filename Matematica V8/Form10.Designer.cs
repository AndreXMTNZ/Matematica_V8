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
            txt = new TextBox();
            txtX = new TextBox();
            btnVerificar = new Button();
            pictureBoxPlano = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnclean = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlano).BeginInit();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Cursor = Cursors.IBeam;
            txt.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt.Location = new Point(27, 305);
            txt.Name = "txt";
            txt.Size = new Size(189, 39);
            txt.TabIndex = 0;
            // 
            // txtX
            // 
            txtX.Cursor = Cursors.IBeam;
            txtX.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtX.Location = new Point(27, 210);
            txtX.Name = "txtX";
            txtX.Size = new Size(189, 39);
            txtX.TabIndex = 1;
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
            // pictureBoxPlano
            // 
            pictureBoxPlano.BackColor = Color.FromArgb(78, 53, 151);
            pictureBoxPlano.Cursor = Cursors.Cross;
            pictureBoxPlano.Location = new Point(250, 165);
            pictureBoxPlano.Name = "pictureBoxPlano";
            pictureBoxPlano.Size = new Size(762, 426);
            pictureBoxPlano.TabIndex = 4;
            pictureBoxPlano.TabStop = false;
            pictureBoxPlano.Click += pictureBoxPlano_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 175);
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
            label2.Location = new Point(27, 270);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 6;
            label2.Text = "Eje Y";
            // 
            // btnclean
            // 
            btnclean.BackColor = Color.FromArgb(35, 179, 179);
            btnclean.Cursor = Cursors.Hand;
            btnclean.FlatAppearance.BorderSize = 0;
            btnclean.FlatStyle = FlatStyle.Flat;
            btnclean.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnclean.ForeColor = Color.Transparent;
            btnclean.Location = new Point(488, 621);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(201, 60);
            btnclean.TabIndex = 7;
            btnclean.Text = "Limpiar";
            btnclean.UseVisualStyleBackColor = false;
            btnclean.Click += btnclean_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 179, 179);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(976, 621);
            button1.Name = "button1";
            button1.Size = new Size(201, 60);
            button1.TabIndex = 8;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PlanoC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 721);
            Controls.Add(button1);
            Controls.Add(btnclean);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtX);
            Controls.Add(txt);
            Controls.Add(pictureBoxPlano);
            Controls.Add(btnVerificar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlanoC";
            Text = "Plano Cartesiano";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlano).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
        private TextBox txtX;
        private Button btnVerificar;
        private PictureBox pictureBoxPlano;
        private Label label1;
        private Label label2;
        private Button btnclean;
        private Button button1;
    }
}