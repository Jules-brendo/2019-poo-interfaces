namespace Array
{
    partial class FormCadastroConta
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
            this.Titular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titular
            // 
            this.Titular.AutoSize = true;
            this.Titular.Location = new System.Drawing.Point(296, 202);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(36, 13);
            this.Titular.TabIndex = 0;
            this.Titular.Text = "Titular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(355, 199);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(355, 152);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 3;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(343, 251);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.BotaoCadastro_Click);
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Location = new System.Drawing.Point(355, 110);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(121, 21);
            this.comboTipoConta.TabIndex = 5;
            this.comboTipoConta.SelectedIndexChanged += new System.EventHandler(this.ComboTipoConta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo conta";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTipoConta);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titular);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.ComboBox comboTipoConta;
        private System.Windows.Forms.Label label2;
    }
}