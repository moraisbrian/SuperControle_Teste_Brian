using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_Brian.Context;
using Teste_Brian.Converter;
using Teste_Brian.Entities;

namespace Teste_Brian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SystemContext context = new SystemContext();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Entidade entidade = new Entidade();

            string erros = "";
            bool? isCpf = null;

            if (txtAdicionarNome.Text.Length > 50 || string.IsNullOrEmpty(txtAdicionarNome.Text))
                erros = "Nome não pode conter mais que 50 caracteres e não pode ser vazio";
            if (txtAdicionarCpf.Text.Length == 11)
                isCpf = true;
            else if (txtAdicionarCpf.Text.Length == 14)
                isCpf = false;
            else
                erros += "\nInforme um CPF ou um CNPJ";

            if (erros == "")
            {
                entidade.Nome = txtAdicionarNome.Text;
                entidade.DtNasc = dtpAdicionarNasc.Value;
                entidade.DtCadastro = DateTime.Now;
                entidade.Identificador = Guid.NewGuid();

                if (isCpf == true)
                {
                    entidade.Cpf = txtAdicionarCpf.Text;
                    entidade.PessoaFisica = true;
                }
                else
                {
                    entidade.Cnpj = txtAdicionarCpf.Text;
                    entidade.PessoaFisica = false;
                }
                context.Entidade.Add(entidade);
                context.SaveChanges();
                LimparAdicionar();
                MessageBox.Show("Regístro inserido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(erros, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparAdicionar()
        {
            txtAdicionarCpf.Clear();
            txtAdicionarNome.Clear();
            dtpAdicionarNasc.Value = DateTime.Now;
        }

        public void LimparEditar()
        {
            txtEditarBairro.Clear();
            txtEditarTipo.Clear();
            txtEditarUf.Clear();
            txtEditarLogradouro.Clear();
            txtEditarEmailEnd.Clear();
            txtEditarNumero.Clear();
            txtEditarMunicipio.Clear();
            txtEditarCep.Clear();
            txtEditarDdd1.Clear();
            txtEditarNumTel1.Clear();
            txtEditarCel.Clear();
            txtEditarDdd2.Clear();
            txtEditarNumTel2.Clear();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                IEnumerable<Entidade> entidade = context.Entidade.ToList();
                cmbEditarEntidade.DataSource = entidade;
                cmbEditarEntidade.ValueMember = "Id";
                cmbEditarEntidade.DisplayMember = "Nome";
            }
            else if (e.TabPageIndex == 2)
            {
                var entidade = context.Entidade
                    .Select(x => new
                    {
                        Nome = x.Nome,
                        Endereco = !string.IsNullOrEmpty(x.Endereco.Logradouro) ?
                                    x.Endereco.Logradouro + ", " + x.Endereco.Numero
                                    + " - " + x.Endereco.Cep + " " + x.Endereco.Bairro
                                    + " " + x.Endereco.Municipio + " - " + x.Endereco.Uf : "",
                        Fone = x.Telefone.Numero1,
                        Email = x.Email.Endereco,
                        GUID = x.Identificador
                    })
                    .ToList();

                dgvConsultar.DataSource = entidade;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Entidade entidade = (Entidade)cmbEditarEntidade.SelectedItem;

            if (entidade.Endereco == null)
                entidade.Endereco = new Endereco();
            if (entidade.Email == null)
                entidade.Email = new Email();
            if (entidade.Telefone == null)
                entidade.Telefone = new Telefone();

            if (!string.IsNullOrEmpty(txtEditarTipo.Text))
                entidade.Endereco.TipoLogradouro = txtEditarTipo.Text;
            if (!string.IsNullOrEmpty(txtEditarLogradouro.Text))
                entidade.Endereco.Logradouro = txtEditarLogradouro.Text;
            if (!string.IsNullOrEmpty(txtEditarNumero.Text))
                entidade.Endereco.Numero = Convert.ToInt32(txtEditarNumero.Text);
            if (!string.IsNullOrEmpty(txtEditarBairro.Text))
                entidade.Endereco.Bairro = txtEditarBairro.Text;
            if (!string.IsNullOrEmpty(txtEditarCep.Text))
                entidade.Endereco.Cep = txtEditarCep.Text;
            if (!string.IsNullOrEmpty(txtEditarMunicipio.Text))
                entidade.Endereco.Municipio = txtEditarMunicipio.Text;
            if (!string.IsNullOrEmpty(txtEditarUf.Text))
                entidade.Endereco.Uf = txtEditarUf.Text;

            if (!string.IsNullOrEmpty(txtEditarDdd1.Text))
                entidade.Telefone.Ddd1 = txtEditarDdd1.Text;
            if (!string.IsNullOrEmpty(txtEditarNumTel1.Text))
                entidade.Telefone.Numero1 = txtEditarNumTel1.Text;
            if (!string.IsNullOrEmpty(txtEditarDdd2.Text))
                entidade.Telefone.Ddd2 = txtEditarDdd2.Text;
            if (!string.IsNullOrEmpty(txtEditarNumTel2.Text))
                entidade.Telefone.Numero2 = txtEditarNumTel2.Text;
            if (!string.IsNullOrEmpty(txtEditarCel.Text))
                entidade.Telefone.Cel = txtEditarCel.Text;

            if (!string.IsNullOrEmpty(txtEditarEmailEnd.Text))
                entidade.Email.Endereco = txtEditarEmailEnd.Text;

            string erros = string.Empty;
            if (entidade.Endereco != null)
            {
                if (!string.IsNullOrEmpty(entidade.Endereco.Logradouro))
                {
                    if (entidade.Endereco.Logradouro.Length > 30)
                        erros = "Logradouro não deve ultrapassar 30 caracteres\n";
                }
                if (!string.IsNullOrEmpty(entidade.Endereco.TipoLogradouro))
                {
                    if (entidade.Endereco.TipoLogradouro.Length > 10)
                        erros += "Tipo de logradouro não pode ultrapassar 10 caracteres\n";
                }
                if (!string.IsNullOrEmpty(entidade.Endereco.Bairro))
                {
                    if (entidade.Endereco.Bairro.Length > 15)
                        erros += "Bairro não pode ultrapassar 15 caracteres\n";
                }
                if (!string.IsNullOrEmpty(entidade.Endereco.Cep))
                {
                    if (entidade.Endereco.Cep.Length != 8)
                        erros += "CEP deve conter 8 dígitos\n";
                }
                if (!string.IsNullOrEmpty(entidade.Endereco.Municipio))
                {
                    if (entidade.Endereco.Municipio.Length > 30)
                        erros += "Municipio não pode ultrapassar 30 caracteres\n";
                }
                if (!string.IsNullOrEmpty(entidade.Endereco.Uf))
                {
                    if (entidade.Endereco.Uf.Length != 2)
                        erros += "UF deve conter 2 caracteres\n";
                }
            }
            if (entidade.Telefone != null)
            {
                bool hasDddError = false;
                bool hasNumberError = false;
                if (!string.IsNullOrEmpty(entidade.Telefone.Ddd1))
                {
                    if (entidade.Telefone.Ddd1.Length != 2)
                    {
                        erros += "DDD deve conter 2 dígitos\n";
                        hasDddError = true;
                    }
                }
                if (!string.IsNullOrEmpty(entidade.Telefone.Ddd2) && !hasDddError)
                {
                    if (entidade.Telefone.Ddd2.Length != 2)
                        erros += "DDD deve conter 2 dígitos\n";
                }
                if (!string.IsNullOrEmpty(entidade.Telefone.Numero1))
                {
                    if (entidade.Telefone.Numero1.Length > 9)
                    {
                        erros += "Telefone não pode ultrapassar 9 dígitos\n";
                        hasNumberError = true;
                    }
                }
                if (!string.IsNullOrEmpty(entidade.Telefone.Numero2) && !hasNumberError)
                {
                    if (entidade.Telefone.Numero2.Length > 9)
                        erros += "Telefone não pode ultrapassar 9 dígitos\n";
                }
                if (!string.IsNullOrEmpty(entidade.Telefone.Cel))
                {
                    if (entidade.Telefone.Cel.Length > 9)
                        erros += "Celular não pode ultrapassar 9 dígitos\n";
                }
            }
            if (entidade.Email != null)
            {
                if (!string.IsNullOrEmpty(entidade.Email.Endereco))
                {
                    if (entidade.Email.Endereco.Length > 20)
                        erros += "Email não pode ultrapassar 20 caracteres";
                }
            }

            if (erros == string.Empty)
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Regístro inserido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(erros, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbEditarEntidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparEditar();
            Entidade entidade = (Entidade)cmbEditarEntidade.SelectedItem;

            entidade.Email = context.Email.Where(x => x.Id == entidade.Id).FirstOrDefault();
            entidade.Telefone = context.Telefone.Where(x => x.Id == entidade.Id).FirstOrDefault();
            entidade.Endereco = context.Endereco.Where(x => x.Id == entidade.Id).FirstOrDefault();

            if (entidade.Endereco != null)
            {
                if (!string.IsNullOrEmpty(entidade.Endereco.TipoLogradouro))
                    txtEditarTipo.Text = entidade.Endereco.TipoLogradouro;
                if (!string.IsNullOrEmpty(entidade.Endereco.Logradouro))
                    txtEditarLogradouro.Text = entidade.Endereco.Logradouro;
                if (entidade.Endereco.Numero != null)
                    txtEditarNumero.Text = entidade.Endereco.Numero.ToString();
                if (!string.IsNullOrEmpty(entidade.Endereco.Bairro))
                    txtEditarBairro.Text = entidade.Endereco.Bairro;
                if (!string.IsNullOrEmpty(entidade.Endereco.Cep))
                    txtEditarCep.Text = entidade.Endereco.Cep;
                if (!string.IsNullOrEmpty(entidade.Endereco.Municipio))
                    txtEditarMunicipio.Text = entidade.Endereco.Municipio;
                if (!string.IsNullOrEmpty(entidade.Endereco.Uf))
                    txtEditarUf.Text = entidade.Endereco.Uf;
            }

            if (entidade.Telefone != null)
            {
                if (!string.IsNullOrEmpty(entidade.Telefone.Ddd1))
                    txtEditarDdd1.Text = entidade.Telefone.Ddd1;
                if (!string.IsNullOrEmpty(entidade.Telefone.Numero1))
                    txtEditarNumTel1.Text = entidade.Telefone.Numero1;
                if (!string.IsNullOrEmpty(entidade.Telefone.Ddd2))
                    txtEditarDdd2.Text = entidade.Telefone.Ddd2;
                if (!string.IsNullOrEmpty(entidade.Telefone.Numero2))
                    txtEditarNumTel2.Text = entidade.Telefone.Numero2;
                if (!string.IsNullOrEmpty(entidade.Telefone.Cel))
                    txtEditarCel.Text = entidade.Telefone.Cel;
            }

            if (entidade.Email != null)
            {
                if (!string.IsNullOrEmpty(entidade.Email.Endereco))
                    txtEditarEmailEnd.Text = entidade.Email.Endereco;
            }
        }

        private void btnConsultarPesquisar_Click(object sender, EventArgs e)
        {
            var entidade = context.Entidade
                .Where(x => x.Nome.ToLower()
                    .Contains(txtConsultarPesquisar.Text.ToLower()))
                .Select(x => new
                {
                    Nome = x.Nome,
                    Endereco = !string.IsNullOrEmpty(x.Endereco.Logradouro) ?
                                    x.Endereco.Logradouro + ", " + x.Endereco.Numero
                                    + " - " + x.Endereco.Cep + " " + x.Endereco.Bairro
                                    + " " + x.Endereco.Municipio + " - " + x.Endereco.Uf : "",
                    Fone = x.Telefone.Numero1,
                    Email = x.Email.Endereco,
                    GUID = x.Identificador
                })
                .ToList();

            dgvConsultar.DataSource = entidade;
        }

        private void btnConverterBanco_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show("Deseja fazer a conversão?",
                                "Atenção",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button3);

            if (resposta == DialogResult.Yes)
            {
                Query query = new Query();
                try
                {
                    query.ConverterBanco();
                    MessageBox.Show("Banco convertido!",
                                "Informação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }

        }
    }
}
