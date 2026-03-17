namespace Q2_ConversorDolarReal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResultado = new Label();
            label3 = new Label();
            txtCotacao = new TextBox();
            txtDolares = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação do dólar (R$):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Green;
            lblResultado.Location = new Point(198, 147);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(57, 21);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 33);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade em dólares (US$):";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(64, 51);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 1;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(257, 51);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(184, 98);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(90, 27);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 200);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(txtCotacao);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private Label label3;
        private TextBox txtCotacao;
        private TextBox txtDolares;
        private Button btnConverter;
    }
}
