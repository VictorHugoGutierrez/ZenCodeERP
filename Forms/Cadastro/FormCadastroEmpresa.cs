using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenCodeERP.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Model;

namespace ZenCodeERP.Forms.Cadastro
{
    public partial class FormCadastroEmpresa : Form
    {
        private EmpresaRepository empresaRepository = new EmpresaRepository();
        public int codEmpresa;
        public bool edita = false;

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
            //tbCodEndereco.Text = empresa.CODENDERECO.ToString();
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
                    });
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
    }
}
