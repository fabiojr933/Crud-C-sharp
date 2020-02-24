using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMSQL.Model;
using SistemaMSQL.Entidades;

namespace SistemaMSQL.Telas
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }
        Venda venda = new Venda();
        VendasModel model = new VendasModel();
        Clientes cliente = new Clientes();
        ClienteModel clienteModel = new ClienteModel();

        public void limparCampos()
        {
            txtVendaCodigo.Text = "";
            dateTimeDataVenda.Text = "";
            txtVendaValor.Text = "";
            comboVendaCliente.Text = "";
        }
        public void habilitarCampo()
        {
            txtVendaCodigo.Enabled = true;
            dateTimeDataVenda.Enabled = true;
            txtVendaValor.Enabled = true;
            comboVendaCliente.Enabled = true;
        }
        public void desabilitarCampos()
        {
            txtVendaValor.Enabled = false;
            dateTimeDataVenda.Enabled = false;
            txtVendaCodigo.Enabled = false;
            comboVendaCliente.Enabled = true;
        }

        private void btnCadastroProdutoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampo();
            limparCampos();
            btnCadastroProdutoSalvar.Enabled = true;
        }
        public void salvarVenda(Venda venda)
        {
            try
            {
                venda.Data = Convert.ToDateTime(dateTimeDataVenda.Text);
                venda.Valor = Convert.ToDecimal(txtVendaValor.Text);
                venda.Id_cliente = Convert.ToInt32(comboVendaCliente.SelectedValue);        
                model.salvarVenda(venda);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);
            }
        }
        public void listarVendas(Venda venda)
        {
            try
            {
                dataGridVenda.DataSource = model.ListarVendas(venda);
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao listar vendas");
            }
        }

        public void buscar(Venda venda)
        {
            try
            {
                MessageBox.Show("buscour ");
                venda.Id_cliente = Convert.ToInt32(comboBoxBuscar.SelectedValue);
                dataGridVenda.DataSource = model.BucarVendas(venda);
            }
            catch (Exception ex)
            {
                
            }
        }
        private void Vendas_Load(object sender, EventArgs e)
        {
            comboVendaCliente.DataSource = clienteModel.listar();
            comboVendaCliente.ValueMember = "id";
            comboVendaCliente.DisplayMember = "nome";

            comboBoxBuscar.DataSource = clienteModel.listar();
            comboBoxBuscar.ValueMember = "id";
            comboBoxBuscar.DisplayMember = "nome";


            desabilitarCampos();
            btnCadastroProdutoEditar.Enabled = false;
            btnCadastroProdutoExcluir.Enabled = false;
            btnCadastroProdutoSalvar.Enabled = false;
            listarVendas(venda);
            limparCampos();
        }

        private void btnCadastroProdutoSalvar_Click(object sender, EventArgs e)
        {
            salvarVenda(venda);
            limparCampos();
            desabilitarCampos();
            listarVendas(venda);
        }

        public void EditarVenda(Venda venda)
        {
            try
            {
                venda.Id = Convert.ToInt32(txtVendaCodigo.Text);
                venda.Data = Convert.ToDateTime(dateTimeDataVenda.Text);
                venda.Valor = Convert.ToDecimal(txtVendaValor.Text);
                venda.Id_cliente = Convert.ToInt32(comboVendaCliente.SelectedValue);
                model.EditarVenda(venda);
                MessageBox.Show("Venda editado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);
                throw;
            }
        }
        public void ExcluirVenda(Venda venda)
        {
            try
            {
                venda.Id = Convert.ToInt32(txtVendaCodigo.Text);
                model.ExcluirVenda(venda);
                MessageBox.Show("Venda excluida com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);
                throw;
            }
        }

        private void dataGridVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVendaCodigo.Text = dataGridVenda.CurrentRow.Cells[0].Value.ToString();
            dateTimeDataVenda.Text = dataGridVenda.CurrentRow.Cells[1].Value.ToString();
            txtVendaValor.Text = dataGridVenda.CurrentRow.Cells[2].Value.ToString();
            comboVendaCliente.SelectedValue = dataGridVenda.CurrentRow.Cells[3].Value.ToString();    
            habilitarCampo();
            btnCadastroProdutoEditar.Enabled = true;
            btnCadastroProdutoExcluir.Enabled = true;

        }

        private void btnCadastroProdutoEditar_Click(object sender, EventArgs e)
        {
            if (txtVendaCodigo.Text == "")
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }
            else
            {
                EditarVenda(venda);
                listarVendas(venda);
                limparCampos();
                desabilitarCampos();
            }
        }

        private void btnCadastroProdutoExcluir_Click(object sender, EventArgs e)
        {
            ExcluirVenda(venda);
            listarVendas(venda);
            limparCampos();
            
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
          //  Venda venda = new Venda();
            buscar(venda);
        }
    }
}
