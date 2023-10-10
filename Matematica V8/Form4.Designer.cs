namespace Matematica_V8
{
    partial class rkreamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rkreamer));
            button1 = new Button();
            textA = new TextBox();
            textB = new TextBox();
            textR = new TextBox();
            textS = new TextBox();
            textD = new TextBox();
            textC = new TextBox();
            botoncalc = new Button();
            limpiar = new Button();
            RESX = new TextBox();
            RESY = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(148, 221, 222);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(535, 623);
            button1.Name = "button1";
            button1.Size = new Size(211, 57);
            button1.TabIndex = 0;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textA
            // 
            textA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textA.Location = new Point(81, 179);
            textA.Margin = new Padding(3, 4, 3, 4);
            textA.Name = "textA";
            textA.Size = new Size(66, 47);
            textA.TabIndex = 4;
            // 
            // textB
            // 
            textB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textB.Location = new Point(247, 179);
            textB.Margin = new Padding(3, 4, 3, 4);
            textB.Name = "textB";
            textB.Size = new Size(66, 47);
            textB.TabIndex = 5;
            // 
            // textR
            // 
            textR.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textR.Location = new Point(538, 179);
            textR.Margin = new Padding(3, 4, 3, 4);
            textR.Name = "textR";
            textR.Size = new Size(92, 47);
            textR.TabIndex = 6;
            // 
            // textS
            // 
            textS.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textS.Location = new Point(538, 278);
            textS.Margin = new Padding(3, 4, 3, 4);
            textS.Name = "textS";
            textS.Size = new Size(92, 47);
            textS.TabIndex = 12;
            // 
            // textD
            // 
            textD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textD.Location = new Point(247, 278);
            textD.Margin = new Padding(3, 4, 3, 4);
            textD.Name = "textD";
            textD.Size = new Size(66, 47);
            textD.TabIndex = 11;
            // 
            // textC
            // 
            textC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textC.Location = new Point(81, 278);
            textC.Margin = new Padding(3, 4, 3, 4);
            textC.Name = "textC";
            textC.Size = new Size(66, 47);
            textC.TabIndex = 10;
            // 
            // botoncalc
            // 
            botoncalc.BackColor = Color.FromArgb(148, 221, 222);
            botoncalc.FlatAppearance.BorderSize = 0;
            botoncalc.FlatStyle = FlatStyle.Flat;
            botoncalc.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            botoncalc.Location = new Point(180, 378);
            botoncalc.Margin = new Padding(3, 4, 3, 4);
            botoncalc.Name = "botoncalc";
            botoncalc.Size = new Size(183, 52);
            botoncalc.TabIndex = 13;
            botoncalc.Text = "CALCULAR";
            botoncalc.UseVisualStyleBackColor = false;
            botoncalc.Click += botoncalc_Click;
            // 
            // limpiar
            // 
            limpiar.BackColor = Color.FromArgb(148, 221, 222);
            limpiar.FlatAppearance.BorderSize = 0;
            limpiar.FlatStyle = FlatStyle.Flat;
            limpiar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            limpiar.Location = new Point(538, 378);
            limpiar.Margin = new Padding(3, 4, 3, 4);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(181, 52);
            limpiar.TabIndex = 15;
            limpiar.Text = "LIMPIAR";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // RESX
            // 
            RESX.Enabled = false;
            RESX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RESX.Location = new Point(247, 501);
            RESX.Margin = new Padding(3, 4, 3, 4);
            RESX.Name = "RESX";
            RESX.Size = new Size(201, 47);
            RESX.TabIndex = 20;
            // 
            // RESY
            // 
            RESY.Enabled = false;
            RESY.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RESY.Location = new Point(550, 501);
            RESY.Margin = new Padding(3, 4, 3, 4);
            RESY.Name = "RESY";
            RESY.Size = new Size(198, 47);
            RESY.TabIndex = 21;
            // 
            // rkreamer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1262, 713);
            Controls.Add(RESY);
            Controls.Add(RESX);
            Controls.Add(limpiar);
            Controls.Add(botoncalc);
            Controls.Add(textS);
            Controls.Add(textD);
            Controls.Add(textC);
            Controls.Add(textR);
            Controls.Add(textB);
            Controls.Add(textA);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "rkreamer";
            Text = "Regla Kramer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textA;
        private TextBox textB;
        private TextBox textR;
        private TextBox textS;
        private TextBox textD;
        private TextBox textC;
        private Button botoncalc;
        private Button limpiar;
        private TextBox RESX;
        private TextBox RESY;
    }
}