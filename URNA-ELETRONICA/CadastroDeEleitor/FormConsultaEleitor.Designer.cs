﻿namespace UiTerminalWindows
{
    partial class FormConsultaEleitor
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
            this.bindingSourceEleitor = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonTitulo = new System.Windows.Forms.RadioButton();
            this.labelAlterar = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloEleitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votouDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceEleitor
            // 
            this.bindingSourceEleitor.DataSource = typeof(MODELS.Eleitor);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 112);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(476, 27);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuscar.Location = new System.Drawing.Point(545, 107);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInserir.Location = new System.Drawing.Point(545, 55);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 29);
            this.buttonInserir.TabIndex = 4;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Eleitor";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExcluir.Location = new System.Drawing.Point(686, 109);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 6;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNome.Location = new System.Drawing.Point(106, 69);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(117, 29);
            this.radioButtonNome.TabIndex = 7;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Por Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitulo
            // 
            this.radioButtonTitulo.AutoSize = true;
            this.radioButtonTitulo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTitulo.Location = new System.Drawing.Point(229, 69);
            this.radioButtonTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTitulo.Name = "radioButtonTitulo";
            this.radioButtonTitulo.Size = new System.Drawing.Size(116, 29);
            this.radioButtonTitulo.TabIndex = 8;
            this.radioButtonTitulo.TabStop = true;
            this.radioButtonTitulo.Text = "Por Titulo";
            this.radioButtonTitulo.UseVisualStyleBackColor = true;
            // 
            // labelAlterar
            // 
            this.labelAlterar.AutoSize = true;
            this.labelAlterar.Location = new System.Drawing.Point(1123, 619);
            this.labelAlterar.Name = "labelAlterar";
            this.labelAlterar.Size = new System.Drawing.Size(0, 20);
            this.labelAlterar.TabIndex = 12;
            this.labelAlterar.Click += new System.EventHandler(this.labelAlterar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAlterar.Location = new System.Drawing.Point(686, 55);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 13;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTodos.Location = new System.Drawing.Point(12, 69);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(83, 29);
            this.radioButtonTodos.TabIndex = 14;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.tituloEleitorDataGridViewTextBoxColumn,
            this.votouDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceEleitor;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(734, 418);
            this.dataGridView1.TabIndex = 15;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloEleitorDataGridViewTextBoxColumn
            // 
            this.tituloEleitorDataGridViewTextBoxColumn.DataPropertyName = "TituloEleitor";
            this.tituloEleitorDataGridViewTextBoxColumn.HeaderText = "TituloEleitor";
            this.tituloEleitorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloEleitorDataGridViewTextBoxColumn.Name = "tituloEleitorDataGridViewTextBoxColumn";
            this.tituloEleitorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloEleitorDataGridViewTextBoxColumn.Width = 125;
            // 
            // votouDataGridViewCheckBoxColumn
            // 
            this.votouDataGridViewCheckBoxColumn.DataPropertyName = "Votou";
            this.votouDataGridViewCheckBoxColumn.HeaderText = "Votou";
            this.votouDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.votouDataGridViewCheckBoxColumn.Name = "votouDataGridViewCheckBoxColumn";
            this.votouDataGridViewCheckBoxColumn.ReadOnly = true;
            this.votouDataGridViewCheckBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAtualizar.Location = new System.Drawing.Point(409, 65);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(104, 37);
            this.buttonAtualizar.TabIndex = 16;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormConsultaEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 583);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.labelAlterar);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.radioButtonNome);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Name = "FormConsultaEleitor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormConsultaEleitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bindingSourceEleitor;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Button buttonInserir;
        private Label label2;
        private Button buttonExcluir;
        private RadioButton radioButtonNome;
        private RadioButton radioButtonTitulo;
        private Label labelAlterar;
        private Button buttonAlterar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private RadioButton radioButtonTodos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloEleitorDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn votouDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Button buttonAtualizar;
    }
}