namespace Matematica_V8
{
    partial class Promedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promedio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            btncalc = new Button();
            btnclean = new Button();
            regresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 199);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 0;
            label1.Text = "Venta 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(238, 199);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 1;
            label2.Text = "Venta 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(78, 53, 151);
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(397, 199);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 2;
            label3.Text = "Venta 3";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(87, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 35);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(238, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 35);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(397, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(105, 35);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(78, 53, 151);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.FromArgb(35, 179, 179);
            textBox4.Location = new Point(87, 361);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 28);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(78, 53, 151);
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(87, 328);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 7;
            label4.Text = "Promedio";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(78, 53, 151);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.FromArgb(35, 179, 179);
            textBox5.Location = new Point(640, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(256, 28);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(78, 53, 151);
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(640, 247);
            label5.Name = "label5";
            label5.Size = new Size(99, 30);
            label5.TabIndex = 9;
            label5.Text = "Mensaje";
            label5.Click += label5_Click;
            // 
            // btncalc
            // 
            btncalc.BackColor = Color.FromArgb(35, 179, 179);
            btncalc.FlatAppearance.BorderSize = 0;
            btncalc.FlatStyle = FlatStyle.Flat;
            btncalc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalc.ForeColor = Color.White;
            btncalc.Location = new Point(202, 621);
            btncalc.Name = "btncalc";
            btncalc.Size = new Size(212, 60);
            btncalc.TabIndex = 11;
            btncalc.Text = "Calcular";
            btncalc.UseVisualStyleBackColor = false;
            btncalc.Click += button2_Click;
            // 
            // btnclean
            // 
            btnclean.BackColor = Color.FromArgb(35, 179, 179);
            btnclean.FlatAppearance.BorderSize = 0;
            btnclean.FlatStyle = FlatStyle.Flat;
            btnclean.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnclean.ForeColor = Color.White;
            btnclean.Location = new Point(482, 621);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(212, 60);
            btnclean.TabIndex = 12;
            btnclean.Text = "Limpiar";
            btnclean.UseVisualStyleBackColor = false;
            btnclean.Click += btnclean_Click;
            // 
            // regresar
            // 
            regresar.BackColor = Color.FromArgb(35, 179, 179);
            regresar.FlatAppearance.BorderSize = 0;
            regresar.FlatStyle = FlatStyle.Flat;
            regresar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            regresar.ForeColor = Color.White;
            regresar.Location = new Point(984, 628);
            regresar.Name = "regresar";
            regresar.Size = new Size(184, 47);
            regresar.TabIndex = 13;
            regresar.Text = "Regresar";
            regresar.UseVisualStyleBackColor = false;
            regresar.Click += button4_Click;
            // 
            // Promedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 721);
            Controls.Add(regresar);
            Controls.Add(btnclean);
            Controls.Add(btncalc);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Promedio";
            Text = "Promedio";
            Load += Promedio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button btncalc;
        private Button btnclean;
        private Button regresar;
    }
}