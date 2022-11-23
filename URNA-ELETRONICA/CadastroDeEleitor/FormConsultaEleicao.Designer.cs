﻿namespace UiTerminalWindows
{
    partial class FormConsultaEleicao
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
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.bindingSourceEleicao = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonAno = new System.Windows.Forms.RadioButton();
            this.radioButtonTurno = new System.Windows.Forms.RadioButton();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Eleiçao";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 138);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(426, 27);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // bindingSourceEleicao
            // 
            this.bindingSourceEleicao.DataSource = typeof(MODELS.Eleicao);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceEleicao;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(574, 429);
            this.dataGridView1.TabIndex = 5;
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
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // radioButtonAno
            // 
            this.radioButtonAno.AutoSize = true;
            this.radioButtonAno.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAno.Location = new System.Drawing.Point(143, 87);
            this.radioButtonAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonAno.Name = "radioButtonAno";
            this.radioButtonAno.Size = new System.Drawing.Size(101, 29);
            this.radioButtonAno.TabIndex = 6;
            this.radioButtonAno.TabStop = true;
            this.radioButtonAno.Text = "Por Ano";
            this.radioButtonAno.UseVisualStyleBackColor = true;
            // 
            // radioButtonTurno
            // 
            this.radioButtonTurno.AutoSize = true;
            this.radioButtonTurno.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTurno.Location = new System.Drawing.Point(272, 87);
            this.radioButtonTurno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonTurno.Name = "radioButtonTurno";
            this.radioButtonTurno.Size = new System.Drawing.Size(116, 29);
            this.radioButtonTurno.TabIndex = 7;
            this.radioButtonTurno.TabStop = true;
            this.radioButtonTurno.Text = "Por Turno";
            this.radioButtonTurno.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuscar.Location = new System.Drawing.Point(455, 121);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(86, 44);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInserir.Location = new System.Drawing.Point(557, 121);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(86, 42);
            this.buttonInserir.TabIndex = 12;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExcluir.Location = new System.Drawing.Point(659, 121);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(86, 44);
            this.buttonExcluir.TabIndex = 13;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAlterar.Location = new System.Drawing.Point(621, 72);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(86, 40);
            this.buttonAlterar.TabIndex = 14;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTodos.Location = new System.Drawing.Point(12, 87);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(116, 29);
            this.radioButtonTodos.TabIndex = 15;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Por Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(480, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConsultaEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.radioButtonTurno);
            this.Controls.Add(this.radioButtonAno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConsultaEleicao";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormConsultaEleicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxBuscar;
        private BindingSource bindingSourceEleicao;
        private DataGridView dataGridView1;
        private RadioButton radioButtonAno;
        private RadioButton radioButtonTurno;
        private Button buttonBuscar;
        private Button buttonInserir;
        private Button buttonExcluir;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private Button buttonAlterar;
        private RadioButton radioButtonTodos;
        private Button button1;
    }
}