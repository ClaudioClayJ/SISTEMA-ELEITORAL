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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bindingSourceEleitor = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.checkBoxVotou = new System.Windows.Forms.CheckBox();
            this.eleitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
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
            this.labelEleitorCandidato.Size = new System.Drawing.Size(225, 38);
            this.labelEleitorCandidato.TabIndex = 0;
            this.labelEleitorCandidato.Text = "Cadastro Eleitor";
            // 
            // labelNomeEleitor
            // 
            this.labelNomeEleitor.AutoSize = true;
            this.labelNomeEleitor.Location = new System.Drawing.Point(11, 65);
            this.labelNomeEleitor.Name = "labelNomeEleitor";
            this.labelNomeEleitor.Size = new System.Drawing.Size(50, 20);
            this.labelNomeEleitor.TabIndex = 1;
            this.labelNomeEleitor.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEleitor, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(0, 103);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(383, 27);
            this.textBoxNome.TabIndex = 2;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bindingSourceEleitor
            // 
            this.bindingSourceEleitor.DataSource = typeof(MODELS.Eleitor);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(11, 163);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 20);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEleitor, "TituloEleitor", true));
            this.textBoxTitulo.Location = new System.Drawing.Point(0, 196);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(383, 27);
            this.textBoxTitulo.TabIndex = 4;
            // 
            // checkBoxVotou
            // 
            this.checkBoxVotou.AutoSize = true;
            this.checkBoxVotou.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.eleitorBindingSource, "Votou", true));
            this.checkBoxVotou.Location = new System.Drawing.Point(515, 162);
            this.checkBoxVotou.Name = "checkBoxVotou";
            this.checkBoxVotou.Size = new System.Drawing.Size(87, 24);
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
            this.buttonSalvar.Location = new System.Drawing.Point(131, 400);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(300, 400);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(663, 398);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 8;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.checkBoxVotou);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNomeEleitor);
            this.Controls.Add(this.labelEleitorCandidato);
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
        private TextBox textBoxNome;
        private Label labelTitulo;
        private TextBox textBoxTitulo;
        private CheckBox checkBoxVotou;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource bindingSourceEleitor;
        private BindingSource eleitorBindingSource;
        private Button buttonAlterar;
    }
}