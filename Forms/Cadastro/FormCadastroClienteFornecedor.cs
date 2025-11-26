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
    public partial class FormCadastroClienteFornecedor : Form
    {
        private ClienteFornecedorRepository clientefornecedorRepository = new ClienteFornecedorRepository();
        public int codEmpresa;
        public int codCliFor;
        public bool edita = false;

        public string codEndereco;
        public string nomeEndereco;

        public class OpcaoComboTipoCadastro
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
        }
        public class OpcaoComboTipoPessoa
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
        }

        public FormCadastroClienteFornecedor()
        {
            InitializeComponent();

            List<OpcaoComboTipoPessoa> listaPessoas = new List<OpcaoComboTipoPessoa>();

            listaPessoas.Add(new OpcaoComboTipoPessoa { Id = 0, Tipo = "Física" });
            listaPessoas.Add(new OpcaoComboTipoPessoa { Id = 1, Tipo = "Jurídica" });

            List<OpcaoComboTipoCadastro> listaCadastro = new List<OpcaoComboTipoCadastro>();

            listaCadastro.Add(new OpcaoComboTipoCadastro { Id = 0, Tipo = "Cliente" });
            listaCadastro.Add(new OpcaoComboTipoCadastro { Id = 1, Tipo = "Fornecedor" });
            listaCadastro.Add(new OpcaoComboTipoCadastro { Id = 2, Tipo = "Ambos" });

            cbTipoCadastro.DataSource = listaCadastro;
            cbTipoPessoa.DataSource = listaPessoas;

            cbTipoCadastro.DisplayMember = "Tipo";
            cbTipoCadastro.ValueMember = "Id";

            cbTipoPessoa.DisplayMember = "Tipo";
            cbTipoPessoa.ValueMember = "Id";
        }

        private void FormCadastroClienteFornecedor_Load(object sender, EventArgs e)
        {
            if (edita)
                CarregaCampos();
            else
                tbCodEmpresa.Text = clientefornecedorRepository.GetNextCodEmpresa().ToString();
        }

        private void CarregaCampos()
        {
            ClienteFornecedor clientefornecedor = clientefornecedorRepository.GetByCodCliFor(codEmpresa, codCliFor);

            tbCodEmpresa.Text = clientefornecedor.CODEMPRESA.ToString();
            tbCodCliFor.Text = clientefornecedor.CODCLIFOR.ToString();
            tbNome.Text = clientefornecedor.NOME;
            tbNomeFantasia.Text = clientefornecedor.NOMEFANTASIA;
            tbCNPJ.Text = clientefornecedor.CNPJCPF;
            tbTelefone.Text = clientefornecedor.TELEFONE;
            cbTipoPessoa.SelectedValue = clientefornecedor.TIPOPESSOA;
            cbTipoCadastro.SelectedValue = clientefornecedor.TIPOCADASTRO;
            tbEmail.Text = clientefornecedor.EMAIL;
            tbCodigoEndereco.Text = clientefornecedor.CODENDERECO.ToString();
            tbCodigoEndereco_Leave(null, null);
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM EMPRESA WHERE CODEMPRESA = {codEmpresa}"))
                {
                    clientefornecedorRepository.Add(new ClienteFornecedor
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODCLIFOR = Convert.ToInt32(tbCodCliFor.Text),
                        NOME = tbNome.Text,
                        NOMEFANTASIA = tbNomeFantasia.Text,
                        CNPJCPF = tbCNPJ.Text,
                        TELEFONE = tbTelefone.Text,
                        TIPOCADASTRO = Convert.ToInt32(cbTipoCadastro.SelectedValue),
                        TIPOPESSOA = Convert.ToInt32(cbTipoPessoa.SelectedValue),
                        EMAIL = tbEmail.Text,
                        CODENDERECO = Convert.ToInt32(tbCodigoEndereco.Text),
                    });

                    codEmpresa = Convert.ToInt32(tbCodEmpresa.Text);
                }
                else
                {
                    clientefornecedorRepository.Update(new ClienteFornecedor
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODCLIFOR = Convert.ToInt32(tbCodCliFor.Text),
                        NOME = tbNome.Text,
                        NOMEFANTASIA = tbNomeFantasia.Text,
                        CNPJCPF = tbCNPJ.Text,
                        TELEFONE = tbTelefone.Text,
                        TIPOCADASTRO = Convert.ToInt32(cbTipoCadastro.SelectedValue),
                        TIPOPESSOA = Convert.ToInt32(cbTipoPessoa.SelectedValue),
                        EMAIL = tbEmail.Text,
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

        private void btnLookupEndereco_Click(object sender, EventArgs e)
        {
            FormVisaoEndereco formVisaoEndereco = new FormVisaoEndereco();
            formVisaoEndereco.ShowDialog();

            tbCodigoEndereco.Text = string.IsNullOrEmpty(codEndereco) ? string.Empty : codEndereco;
            tbNomeEndereco.Text = string.IsNullOrEmpty(nomeEndereco) ? string.Empty : nomeEndereco;
        }

        private void tbCodigoEndereco_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCodigoEndereco.Text))
                tbNomeEndereco.Text = DataBaseConnection.Instance().ExecuteGetField("SELECT NOME FROM ENDERECO WHERE CODENDERECO = ?", new object[] { tbCodigoEndereco.Text }).ToString();
            else
                tbNomeEndereco.Text = string.Empty;
        }

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoPessoa.SelectedIndex == 0)
                tbCNPJ.Mask = "000,000,000-00";
            
            else 
                tbCNPJ.Mask = "00,000,000/0000-00";
        }
    }
}
