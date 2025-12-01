using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenCodeERP.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Visao;
using ZenCodeERP.Model;

namespace ZenCodeERP.Forms.Cadastro
{
    public partial class FormCadastroEmpresa : Form
    {
        private EmpresaRepository empresaRepository = new EmpresaRepository();
        public int codEmpresa;
        public bool edita = false;

        public string CodigoEndereco;
        public string NomeEndereco;

        public FormCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void FormCadastroEmpresa_Load(object sender, EventArgs e)
        {
            if (edita)
                CarregaCampos();
            else
                tbCodEmpresa.Text = empresaRepository.GetNextCodEmpresa().ToString();
        }

        private void CarregaCampos()
        {
            Empresa empresa = empresaRepository.GetByCodEmpresa(codEmpresa);

            tbCodEmpresa.Text = empresa.CODEMPRESA.ToString();
            tbNomeFantasia.Text = empresa.NOMEFANTASIA;
            tbNome.Text = empresa.NOME;
            tbCNPJ.Text = empresa.CNPJ;
            tbTelefone.Text = empresa.TELEFONE;
            tbEmail.Text = empresa.EMAIL;
            pictureBox1.Image = empresa.IMAGEM;
            tbCodigoEndereco.Text = empresa.CODENDERECO.ToString();
            tbCodigoEndereco_Leave(null, null);
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM EMPRESA WHERE CODEMPRESA = {codEmpresa}"))
                {
                    empresaRepository.Add(new Empresa
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        NOMEFANTASIA = tbNomeFantasia.Text,
                        NOME = tbNome.Text,
                        CNPJ = tbCNPJ.Text,
                        TELEFONE = tbTelefone.Text,
                        EMAIL = tbEmail.Text,
                        IMAGEM = pictureBox1.Image,
                        CODENDERECO = Convert.ToInt32(tbCodigoEndereco.Text),
                    });

                    codEmpresa = Convert.ToInt32(tbCodEmpresa.Text);
                }
                else
                {
                    empresaRepository.Update(new Empresa
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        NOMEFANTASIA = tbNomeFantasia.Text,
                        NOME = tbNome.Text,
                        CNPJ = tbCNPJ.Text,
                        TELEFONE = tbTelefone.Text,
                        EMAIL = tbEmail.Text,
                        IMAGEM = pictureBox1.Image,
                        CODENDERECO = Convert.ToInt32(tbCodigoEndereco.Text),
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Salvar())
                return;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Salvar())
                return;

            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iBtnCarregarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao carregar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void iBtnRemoverImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }


        private void btnLookupEndereco_Click(object sender, EventArgs e)
        {
            FormVisaoEndereco formVisaoEndereco = new FormVisaoEndereco(this);
            formVisaoEndereco.ShowDialog();

            tbCodigoEndereco.Text = string.IsNullOrEmpty(CodigoEndereco) ? string.Empty : CodigoEndereco;
            tbNomeEndereco.Text = string.IsNullOrEmpty(NomeEndereco) ? string.Empty : NomeEndereco;
        }

        private void tbCodigoEndereco_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCodigoEndereco.Text))
                tbNomeEndereco.Text = DataBaseConnection.Instance().ExecuteGetField("SELECT NOME FROM ENDERECO WHERE CODENDERECO = ?", new object[] { tbCodigoEndereco.Text }).ToString();
            else
                tbNomeEndereco.Text = string.Empty;
        }
    }
}
