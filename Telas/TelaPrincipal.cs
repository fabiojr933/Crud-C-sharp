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
    public partial class TelaPrincipal : Form
    {
        ClienteModel model = new ClienteModel();

        public void HabilitarCampos()
        {
            txtNome.Enabled = true;
            comboBoxSexo.Enabled = true;
            dateTimeDataNascimento.Enabled = true;
            txtIdade.Enabled = true;
            txtcelular.Enabled = true;
            txtEndereço.Enabled = true;
        }
        public void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            comboBoxSexo.Enabled = false;
            dateTimeDataNascimento.Enabled = false;
            txtIdade.Enabled = false;
            txtcelular.Enabled = false;
            txtEndereço.Enabled = false;
        }
        public void LimparCampos()
        {
            txtNome.Text = "";
            comboBoxSexo.Text = "";
            dateTimeDataNascimento.Text = "";
            txtIdade.Text = "";
            txtcelular.Text = "";
            txtEndereço.Text = "";
        }
        public void salvarCliente(Clientes dados)  //metedo salvar cliente
        {
            try
            {
                dados.Nome = txtNome.Text;
                dados.Sexo = comboBoxSexo.Text;
                dados.Nascimento = Convert.ToDateTime(dateTimeDataNascimento.Text);
                dados.Idade = Convert.ToInt32(txtIdade.Text);
                dados.Celular = txtcelular.Text;
                dados.Endereco = txtEndereço.Text;
                model.salvarCliente(dados);
                MessageBox.Show("Cliente Salvo com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao salvar Cliente" + ex.Message);
            }
        }

        public void EditarCliente(Clientes dados) // medtedo editar cliente
        {
            try
            {
                dados.Id = Convert.ToInt32(txtCodigo.Text);
                dados.Nome = txtNome.Text;
                dados.Sexo = comboBoxSexo.Text;
                dados.Nascimento = Convert.ToDateTime(dateTimeDataNascimento.Text);
                dados.Idade = Convert.ToInt32(txtIdade.Text);
                dados.Celular = txtcelular.Text;
                dados.Endereco = txtEndereço.Text;
                model.editarClientes(dados);
                MessageBox.Show("Cliente editado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! ocorreu algun erroao EDITAR o cliente" + ex.Message);
            }
        }
        public void excluirCliente(Clientes dados)
        {
            try
            {
                dados.Id = Convert.ToInt32(txtCodigo.Text);
                model.excluirCliente(dados);
                MessageBox.Show("Cliente deletado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ops! ocorreu um erro ao excluir um cliente " + ex.Message);
            }
        }

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            buscarDados();  //metedo para listar cliente na Datagrid
            DesabilitarCampos();
        }
        public void buscarDados()  //metedo para listar cliente na Datagrid
        {
            try
            {
                dataGridClientes.DataSource = model.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ops! Ocorreu algum erro ao buscar dados dos clientes" + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            salvarCliente(clientes);
            buscarDados();
            LimparCampos();
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //metedo preenchedoos campos ao clicar na datagrid

            txtCodigo.Text = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
            comboBoxSexo.Text = dataGridClientes.CurrentRow.Cells[2].Value.ToString();
            dateTimeDataNascimento.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
            txtIdade.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = dataGridClientes.CurrentRow.Cells[5].Value.ToString();
            txtEndereço.Text = dataGridClientes.CurrentRow.Cells[6].Value.ToString();
            HabilitarCampos();
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("selecione um REGISTRO na tabela");
                return;
            }
            else
            {
                Clientes clientes = new Clientes();
                EditarCliente(clientes);
                buscarDados();
                LimparCampos();
            }
        }
        public void Pesquisar(Clientes dados)
        {
            try
            {
                dados.Nome = txtBuscar.Text;
                dataGridClientes.DataSource = model.Pesquisar(dados);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            excluirCliente(clientes);
            buscarDados();
            LimparCampos();
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Clientes dados = new Clientes();
            Pesquisar(dados);        
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }            
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
