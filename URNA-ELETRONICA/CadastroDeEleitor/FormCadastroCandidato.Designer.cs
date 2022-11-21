namespace UiTerminalWindows
{
    partial class FormCadastroCandidato
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelNumero = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bindingSourceCandidato = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonSalvarCandidato = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Candidato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(3, 43);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(40, 15);
            this.LabelNome.TabIndex = 1;
            this.LabelNome.Text = "Nome";
            this.LabelNome.Click += new System.EventHandler(this.LabelNome_Click);
            // 
            // LabelNumero
            // 
            this.LabelNumero.AutoSize = true;
            this.LabelNumero.Location = new System.Drawing.Point(3, 106);
            this.LabelNumero.Name = "LabelNumero";
            this.LabelNumero.Size = new System.Drawing.Size(51, 15);
            this.LabelNumero.TabIndex = 2;
            this.LabelNumero.Text = "Numero";
            this.LabelNumero.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCandidato, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(3, 66);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(278, 23);
            this.textBoxNome.TabIndex = 3;
            // 
            // bindingSourceCandidato
            // 
            this.bindingSourceCandidato.DataSource = typeof(MODELS.Candidato);
            this.bindingSourceCandidato.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCandidato, "Numero", true));
            this.textBoxNumero.Location = new System.Drawing.Point(3, 142);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(278, 23);
            this.textBoxNumero.TabIndex = 4;
            // 
            // buttonSalvarCandidato
            // 
            this.buttonSalvarCandidato.Location = new System.Drawing.Point(432, 307);
            this.buttonSalvarCandidato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCandidato.Name = "buttonSalvarCandidato";
            this.buttonSalvarCandidato.Size = new System.Drawing.Size(82, 22);
            this.buttonSalvarCandidato.TabIndex = 7;
            this.buttonSalvarCandidato.Text = "Salvar";
            this.buttonSalvarCandidato.UseVisualStyleBackColor = true;
            this.buttonSalvarCandidato.Click += new System.EventHandler(this.buttonSalvarCandidato_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(599, 307);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 22);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 419);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvarCandidato);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.LabelNumero);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroCandidato";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormCadastroCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label LabelNome;
        private Label LabelNumero;
        private TextBox textBoxNome;
        private TextBox textBoxNumero;
        private Label labelIdCandidato;
        private TextBox textBoxIdCandidato;
        private Button buttonSalvarCandidato;
        private Button buttonCancelar;
        private BindingSource bindingSourceCandidato;
    }
}