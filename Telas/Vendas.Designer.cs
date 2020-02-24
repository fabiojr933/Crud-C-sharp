namespace SistemaMSQL.Telas
{
    partial class Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtVendaCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboVendaCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendaValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridVenda = new System.Windows.Forms.DataGridView();
            this.btnCadastroProdutoExcluir = new System.Windows.Forms.Button();
            this.btnCadastroProdutoEditar = new System.Windows.Forms.Button();
            this.btnCadastroProdutoSalvar = new System.Windows.Forms.Button();
            this.btnCadastroProdutoNovo = new System.Windows.Forms.Button();
            this.dateTimeDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVendaCodigo
            // 
            this.txtVendaCodigo.Location = new System.Drawing.Point(12, 84);
            this.txtVendaCodigo.Name = "txtVendaCodigo";
            this.txtVendaCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtVendaCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Cliente";
            // 
            // comboVendaCliente
            // 
            this.comboVendaCliente.FormattingEnabled = true;
            this.comboVendaCliente.Location = new System.Drawing.Point(158, 88);
            this.comboVendaCliente.Name = "comboVendaCliente";
            this.comboVendaCliente.Size = new System.Drawing.Size(293, 27);
            this.comboVendaCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            // 
            // txtVendaValor
            // 
            this.txtVendaValor.Location = new System.Drawing.Point(12, 142);
            this.txtVendaValor.Name = "txtVendaValor";
            this.txtVendaValor.Size = new System.Drawing.Size(100, 26);
            this.txtVendaValor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Venda";
            // 
            // dataGridVenda
            // 
            this.dataGridVenda.AllowUserToAddRows = false;
            this.dataGridVenda.AllowUserToDeleteRows = false;
            this.dataGridVenda.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridVenda.Location = new System.Drawing.Point(12, 260);
            this.dataGridVenda.Name = "dataGridVenda";
            this.dataGridVenda.ReadOnly = true;
            this.dataGridVenda.Size = new System.Drawing.Size(439, 154);
            this.dataGridVenda.TabIndex = 25;
            this.dataGridVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenda_CellClick);
            // 
            // btnCadastroProdutoExcluir
            // 
            this.btnCadastroProdutoExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroProdutoExcluir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastroProdutoExcluir.Location = new System.Drawing.Point(360, 204);
            this.btnCadastroProdutoExcluir.Name = "btnCadastroProdutoExcluir";
            this.btnCadastroProdutoExcluir.Size = new System.Drawing.Size(75, 35);
            this.btnCadastroProdutoExcluir.TabIndex = 24;
            this.btnCadastroProdutoExcluir.Text = "Excluir";
            this.btnCadastroProdutoExcluir.UseVisualStyleBackColor = false;
            this.btnCadastroProdutoExcluir.Click += new System.EventHandler(this.btnCadastroProdutoExcluir_Click);
            // 
            // btnCadastroProdutoEditar
            // 
            this.btnCadastroProdutoEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroProdutoEditar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastroProdutoEditar.Location = new System.Drawing.Point(247, 204);
            this.btnCadastroProdutoEditar.Name = "btnCadastroProdutoEditar";
            this.btnCadastroProdutoEditar.Size = new System.Drawing.Size(75, 35);
            this.btnCadastroProdutoEditar.TabIndex = 23;
            this.btnCadastroProdutoEditar.Text = "Editar";
            this.btnCadastroProdutoEditar.UseVisualStyleBackColor = false;
            this.btnCadastroProdutoEditar.Click += new System.EventHandler(this.btnCadastroProdutoEditar_Click);
            // 
            // btnCadastroProdutoSalvar
            // 
            this.btnCadastroProdutoSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroProdutoSalvar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastroProdutoSalvar.Location = new System.Drawing.Point(122, 204);
            this.btnCadastroProdutoSalvar.Name = "btnCadastroProdutoSalvar";
            this.btnCadastroProdutoSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnCadastroProdutoSalvar.TabIndex = 22;
            this.btnCadastroProdutoSalvar.Text = "Salvar";
            this.btnCadastroProdutoSalvar.UseVisualStyleBackColor = false;
            this.btnCadastroProdutoSalvar.Click += new System.EventHandler(this.btnCadastroProdutoSalvar_Click);
            // 
            // btnCadastroProdutoNovo
            // 
            this.btnCadastroProdutoNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroProdutoNovo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutoNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastroProdutoNovo.Location = new System.Drawing.Point(16, 204);
            this.btnCadastroProdutoNovo.Name = "btnCadastroProdutoNovo";
            this.btnCadastroProdutoNovo.Size = new System.Drawing.Size(75, 35);
            this.btnCadastroProdutoNovo.TabIndex = 21;
            this.btnCadastroProdutoNovo.Text = "Novo";
            this.btnCadastroProdutoNovo.UseVisualStyleBackColor = false;
            this.btnCadastroProdutoNovo.Click += new System.EventHandler(this.btnCadastroProdutoNovo_Click);
            // 
            // dateTimeDataVenda
            // 
            this.dateTimeDataVenda.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeDataVenda.Enabled = false;
            this.dateTimeDataVenda.Location = new System.Drawing.Point(158, 145);
            this.dateTimeDataVenda.Name = "dateTimeDataVenda";
            this.dateTimeDataVenda.Size = new System.Drawing.Size(293, 26);
            this.dateTimeDataVenda.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Buscar";
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(251, 29);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(121, 27);
            this.comboBoxBuscar.TabIndex = 29;
           
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(376, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(475, 458);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeDataVenda);
            this.Controls.Add(this.dataGridVenda);
            this.Controls.Add(this.btnCadastroProdutoExcluir);
            this.Controls.Add(this.btnCadastroProdutoEditar);
            this.Controls.Add(this.btnCadastroProdutoSalvar);
            this.Controls.Add(this.btnCadastroProdutoNovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVendaValor);
            this.Controls.Add(this.comboVendaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVendaCodigo);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVendaCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboVendaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendaValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridVenda;
        private System.Windows.Forms.Button btnCadastroProdutoExcluir;
        private System.Windows.Forms.Button btnCadastroProdutoEditar;
        private System.Windows.Forms.Button btnCadastroProdutoSalvar;
        private System.Windows.Forms.Button btnCadastroProdutoNovo;
        private System.Windows.Forms.DateTimePicker dateTimeDataVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}