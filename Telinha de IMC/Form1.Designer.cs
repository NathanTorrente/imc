namespace Telinha_de_IMC
{
    partial class IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMC));
            label1 = new Label();
            tx_nome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lb_resultado = new Button();
            tx_altura = new NumericUpDown();
            label6 = new Label();
            tx_peso = new NumericUpDown();
            tx_sexo = new ComboBox();
            label7 = new Label();
            tx_idade = new NumericUpDown();
            panel1 = new Panel();
            tx_cpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)tx_altura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tx_peso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tx_idade).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 106);
            label1.Name = "label1";
            label1.Size = new Size(139, 118);
            label1.TabIndex = 0;
            label1.Text = "IMC";
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(171, 161);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(340, 23);
            tx_nome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 244);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(161, 281);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(112, 243);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 2;
            label4.Text = "Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(150, 367);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 2;
            label5.Text = "Altura";
            // 
            // lb_resultado
            // 
            lb_resultado.Location = new Point(197, 450);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(217, 54);
            lb_resultado.TabIndex = 3;
            lb_resultado.Text = "Cálculo";
            lb_resultado.UseVisualStyleBackColor = true;
            lb_resultado.Click += button1_Click_1;
            // 
            // tx_altura
            // 
            tx_altura.DecimalPlaces = 2;
            tx_altura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tx_altura.Location = new Point(171, 285);
            tx_altura.Name = "tx_altura";
            tx_altura.Size = new Size(120, 25);
            tx_altura.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(463, 376);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 2;
            label6.Text = "Sexo";
            // 
            // tx_peso
            // 
            tx_peso.DecimalPlaces = 2;
            tx_peso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tx_peso.Location = new Point(171, 241);
            tx_peso.Name = "tx_peso";
            tx_peso.Size = new Size(120, 25);
            tx_peso.TabIndex = 4;
            // 
            // tx_sexo
            // 
            tx_sexo.FormattingEnabled = true;
            tx_sexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Não-binário", "Transgênero", "Genderqueer", "Gênero neutro", "Agênero", "Prefiro Não Dizer" });
            tx_sexo.Location = new Point(467, 293);
            tx_sexo.Name = "tx_sexo";
            tx_sexo.Size = new Size(190, 23);
            tx_sexo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(150, 404);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 2;
            label7.Text = "Idade";
            // 
            // tx_idade
            // 
            tx_idade.BackColor = Color.White;
            tx_idade.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tx_idade.ForeColor = SystemColors.WindowText;
            tx_idade.Location = new Point(171, 322);
            tx_idade.Name = "tx_idade";
            tx_idade.RightToLeft = RightToLeft.No;
            tx_idade.Size = new Size(120, 25);
            tx_idade.TabIndex = 4;
            tx_idade.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(tx_cpf);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lb_resultado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-49, -85);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 560);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(220, 283);
            tx_cpf.Mask = "000,000,000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(340, 23);
            tx_cpf.TabIndex = 7;
            tx_cpf.MaskInputRejected += tx_cpf_MaskInputRejected;
            // 
            // IMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(tx_sexo);
            Controls.Add(tx_peso);
            Controls.Add(tx_idade);
            Controls.Add(tx_altura);
            Controls.Add(label4);
            Controls.Add(tx_nome);
            Controls.Add(panel1);
            ForeColor = SystemColors.Highlight;
            Name = "IMC";
            Text = "Cálculo de IMC";
            ((System.ComponentModel.ISupportInitialize)tx_altura).EndInit();
            ((System.ComponentModel.ISupportInitialize)tx_peso).EndInit();
            ((System.ComponentModel.ISupportInitialize)tx_idade).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_nome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button lb_resultado;
        private NumericUpDown tx_altura;
        private Label label6;
        private NumericUpDown tx_peso;
        private ComboBox tx_sexo;
        private Label label7;
        private NumericUpDown tx_idade;
        private Panel panel1;
        private MaskedTextBox tx_cpf;
    }
}