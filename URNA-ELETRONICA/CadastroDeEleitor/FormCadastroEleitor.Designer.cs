namespace UiTerminalWindows
{
    partial class FormCadastroEleitor
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
            this.components = new System.ComponentModel.Container();
            this.labelEleitorCandidato = new System.Windows.Forms.Label();
            this.labelNomeEleitor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingSourceEleitor = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxVotou = new System.Windows.Forms.CheckBox();
            this.eleitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEleitorCandidato
            // 
            this.labelEleitorCandidato.AutoSize = true;
            this.labelEleitorCandidato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEleitorCandidato.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEleitorCandidato.Location = new System.Drawing.Point(0, 0);
            this.labelEleitorCandidato.Name = "labelEleitorCandidato";
            this.labelEleitorCandidato.Size = new System.Drawing.Size(179, 30);
            this.labelEleitorCandidato.TabIndex = 0;
            this.labelEleitorCandidato.Text = "Cadastro Eleitor";
            // 
            // labelNomeEleitor
            // 
            this.labelNomeEleitor.AutoSize = true;
            this.labelNomeEleitor.Location = new System.Drawing.Point(10, 49);
            this.labelNomeEleitor.Name = "labelNomeEleitor";
            this.labelNomeEleitor.Size = new System.Drawing.Size(40, 15);
            this.labelNomeEleitor.TabIndex = 1;
            this.labelNomeEleitor.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEleitor, "Nome", true));
            this.textBox1.Location = new System.Drawing.Point(0, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bindingSourceEleitor
            // 
            this.bindingSourceEleitor.DataSource = typeof(MODELS.Eleitor);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(10, 122);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(37, 15);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEleitor, "TituloEleitor", true));
            this.textBox2.Location = new System.Drawing.Point(0, 147);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 23);
            this.textBox2.TabIndex = 4;
            // 
            // checkBoxVotou
            // 
            this.checkBoxVotou.AutoSize = true;
            this.checkBoxVotou.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.eleitorBindingSource, "Votou", true));
            this.checkBoxVotou.Location = new System.Drawing.Point(606, 122);
            this.checkBoxVotou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxVotou.Name = "checkBoxVotou";
            this.checkBoxVotou.Size = new System.Drawing.Size(70, 19);
            this.checkBoxVotou.TabIndex = 5;
            this.checkBoxVotou.Text = "Já Votou";
            this.checkBoxVotou.UseVisualStyleBackColor = true;
            // 
            // eleitorBindingSource
            // 
            this.eleitorBindingSource.DataSource = typeof(MODELS.Eleitor);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(491, 332);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(82, 22);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(663, 332);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 22);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 434);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.checkBoxVotou);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNomeEleitor);
            this.Controls.Add(this.labelEleitorCandidato);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroEleitor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormCadastroEleitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEleitorCandidato;
        private Label labelNomeEleitor;
        private TextBox textBox1;
        private Label labelTitulo;
        private TextBox textBox2;
        private CheckBox checkBoxVotou;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource bindingSourceEleitor;
        private BindingSource eleitorBindingSource;
    }
}