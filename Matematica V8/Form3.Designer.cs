namespace Matematica_V8
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
            btnrg = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
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
            btnrg.Location = new Point(980, 621);
            btnrg.Name = "btnrg";
            btnrg.Size = new Size(200, 59);
            btnrg.TabIndex = 0;
            btnrg.Text = "Regresar";
            btnrg.UseVisualStyleBackColor = false;
            btnrg.Click += btnrg_Click;
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
            button1.Location = new Point(208, 525);
            button1.Name = "button1";
            button1.Size = new Size(200, 59);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 179, 179);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(208, 620);
            button2.Name = "button2";
            button2.Size = new Size(200, 59);
            button2.TabIndex = 2;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(78, 53, 151);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(92, 259);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 3;
            label1.Text = "Cateto menor";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 263);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 325);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 27);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(78, 53, 151);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(92, 321);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 5;
            label2.Text = "Cateto mayor";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(806, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 27);
            textBox3.TabIndex = 7;
            // 
            // aagudos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 713);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnrg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "aagudos";
            Text = "Angulos Agudos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnrg;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
    }
}