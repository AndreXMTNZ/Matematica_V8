namespace Matematica_V8
{
    partial class Cajero
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
            button1 = new Button();
            txtMonto = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(91, 408);
            button1.Name = "button1";
            button1.Size = new Size(213, 42);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(126, 150);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(124, 23);
            txtMonto.TabIndex = 31;
            // 
            // button2
            // 
            button2.Location = new Point(428, 408);
            button2.Name = "button2";
            button2.Size = new Size(213, 42);
            button2.TabIndex = 32;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(719, 408);
            button3.Name = "button3";
            button3.Size = new Size(213, 42);
            button3.TabIndex = 33;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Cajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6;
            ClientSize = new Size(1104, 535);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtMonto);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cajero";
            Text = "Cajero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtMonto;
        private Button button2;
        private Button button3;
    }
}