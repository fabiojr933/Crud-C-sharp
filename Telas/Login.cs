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
using SistemaMSQL.Telas;

namespace SistemaMSQL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        { 
            LoginModel model = new LoginModel();
            LoginUsuario usuario = new LoginUsuario();
         //   model.logar(txtUsuario.Text, txtSenha.Text);
            /*   if (model.mensagem.Equals(""))
               {
                   if (model.tem)
                   {
                       MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       Principal principal = new Principal();
                       principal.Show();
                       this.Visible = false;

                   }
                   else
                   {
                       MessageBox.Show("Login ou Senha não encontrado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
               else
               {
                   MessageBox.Show(model.mensagem);
               }     */

            Logar2(usuario);

        }
     public void Logar2(LoginUsuario login)
        {
            LoginModel model = new LoginModel();
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o usuario");
                    txtUsuario.Focus();
                    return;
                }
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha a senha");
                    txtSenha.Focus();
                    return;
                }

                login.Usuario = txtUsuario.Text;
                login.Senha = txtSenha.Text;

               login =  model.logar2(login);

                if(login.Usuario == null)
                {
                    lblMensagem.Text = "Usuario ou senha incorreto";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }
                Principal principal = new Principal();
                this.Hide();
                principal.Show();                

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);
                throw;
            }
        }
    }
}
