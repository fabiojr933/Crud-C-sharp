using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMSQL.Entidades;
using SistemaMSQL.Model;
     

namespace SistemaMSQL.Telas
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }
        ProdutoModel model = new ProdutoModel();
        Produtos produto = new Produtos();
        public void HabilitarCampos()
        {
            txtCadastroProdutoDescricao.Enabled = true;
            txtCadastroProdutoEan.Enabled = true;
            txtCadastroProdutoEstoque.Enabled = true;
            txtCadastroProdutoMarca.Enabled = true;
            txtCadastroProdutoNcm.Enabled = true;
            txtCadastroProdutoPreco.Enabled = true;
            txtCadastroProdutoRef.Enabled = true;
        }
        public void DesabilitarCampos()
        {
            txtCadastroProdutoDescricao.Enabled = false;
            txtCadastroProdutoEan.Enabled = false;
            txtCadastroProdutoEstoque.Enabled = false;
            txtCadastroProdutoMarca.Enabled = false;
            txtCadastroProdutoNcm.Enabled = false;
            txtCadastroProdutoPreco.Enabled = false;
            txtCadastroProdutoRef.Enabled = false;
        }
        public void limparCampos()
        {
            txtCadastroProdutoRef.Text = "";
            txtCadastroProdutoPreco.Text = "";
            txtCadastroProdutoNcm.Text = "";
            txtCadastroProdutoMarca.Text = "";
            txtCadastroProdutoEstoque.Text = "";
            txtCadastroProdutoEan.Text = "";
            txtCadastroProdutoDescricao.Text = "";
        }
        public void salvarProduto(Produtos produto)    // cadastrar produto
        {
            try
            {
                produto.Descricao = txtCadastroProdutoDescricao.Text;
                produto.Referencia = txtCadastroProdutoRef.Text;
                produto.Marca = txtCadastroProdutoMarca.Text;
                produto.Ncm = txtCadastroProdutoNcm.Text;
                produto.Codigoean = txtCadastroProdutoEan.Text;
                produto.Estoque = txtCadastroProdutoEstoque.Text;
                produto.Preco = Decimal.Parse(txtCadastroProdutoPreco.Text);
                model.cadastrarProduto(produto);
                MessageBox.Show("Produto Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! ocorreu um erro ao cadastrar PRODUTO");
            }
        }

        public void carregarProdutos()
        {
            try
            {
               dataGridProdutos.DataSource = model.listarProduto();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AtualizarProdutos(Produtos produto)
        {
            try
            {
                produto.Id = Convert.ToInt32(txtCodigo.Text); 
                produto.Descricao = txtCadastroProdutoDescricao.Text;
                produto.Referencia = txtCadastroProdutoRef.Text;
                produto.Marca = txtCadastroProdutoMarca.Text;
                produto.Ncm = txtCadastroProdutoNcm.Text;
                produto.Codigoean = txtCadastroProdutoEan.Text;
                produto.Estoque = txtCadastroProdutoEstoque.Text;
                produto.Preco = Convert.ToDecimal(txtCadastroProdutoPreco.Text);
                model.atualizarProdutos(produto);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("erro " + ex.Message);
            }
        }
        public void deletarProduto(Produtos produto)
        {
            try
            {
                produto.Id = Convert.ToInt32(txtCodigo.Text);
                model.deletarProduto(produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao deltar " + ex.Message);
            }
        }

        private void btnCadastroProdutoNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            limparCampos();
            btnCadastroProdutoSalvar.Enabled = true;
            btnCadastroProdutoEditar.Enabled = false;
            btnCadastroProdutoExcluir.Enabled = false;
        }

        private void btnCadastroProdutoSalvar_Click(object sender, EventArgs e)
        {            
           if(txtCadastroProdutoDescricao.Text == "" && txtCadastroProdutoEan.Text == "")
            {
                MessageBox.Show("Preencha o formulario");
                txtCadastroProdutoDescricao.Focus();
            }
            else
            {
                salvarProduto(produto);
                carregarProdutos();
                limparCampos();
            }
        }
        public void pesquisarProdutos(Produtos produto)
        {
            try
            {
                produto.Descricao = txtPesquisarProdutos.Text;
                dataGridProdutos.DataSource = model.pesquisarProduto(produto);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("erro" + ex.Message);
                throw;
            }
        }

        private void txtCadastroProdutoPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtCadastroProdutoPreco_TextChanged(object sender, EventArgs e)
        {
            //conersao para virgula no textBox PREÇO
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void txtCadastroProdutoEan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadastroProdutoEan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtCadastroProdutoNcm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtCadastroProdutoEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCadastroProdutoEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            carregarProdutos();
            DesabilitarCampos();
            btnCadastroProdutoEditar.Enabled = false;
            btnCadastroProdutoExcluir.Enabled = false;
            btnCadastroProdutoSalvar.Enabled = false;
        }

        private void dataGridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //metedo preenchedoos campos ao clicar na datagrid
            txtCodigo.Text = dataGridProdutos.CurrentRow.Cells[0].Value.ToString();
            txtCadastroProdutoDescricao.Text = dataGridProdutos.CurrentRow.Cells[1].Value.ToString();
            txtCadastroProdutoRef.Text = dataGridProdutos.CurrentRow.Cells[2].Value.ToString();
            txtCadastroProdutoMarca.Text = dataGridProdutos.CurrentRow.Cells[3].Value.ToString();
            txtCadastroProdutoNcm.Text = dataGridProdutos.CurrentRow.Cells[4].Value.ToString();
            txtCadastroProdutoEan.Text = dataGridProdutos.CurrentRow.Cells[5].Value.ToString();
            txtCadastroProdutoEstoque.Text = dataGridProdutos.CurrentRow.Cells[6].Value.ToString();
            txtCadastroProdutoPreco.Text = dataGridProdutos.CurrentRow.Cells[7].Value.ToString();
            HabilitarCampos();
            btnCadastroProdutoEditar.Enabled = true;
            btnCadastroProdutoExcluir.Enabled = true;
            btnCadastroProdutoSalvar.Enabled = false;
        }

        private void btnCadastroProdutoEditar_Click(object sender, EventArgs e)
        {
            AtualizarProdutos(produto);
            carregarProdutos();
            limparCampos();
        }

        private void btnCadastroProdutoExcluir_Click(object sender, EventArgs e)
        {
            deletarProduto(produto);
            carregarProdutos();
            limparCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pesquisarProdutos(produto);
        }
    }
}
