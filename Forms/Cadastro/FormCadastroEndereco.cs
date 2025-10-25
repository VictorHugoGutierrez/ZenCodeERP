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
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Cadastro
{
    public partial class FormCadastroEndereco : Form
    {
        private EnderecoRepository enderecoRepository = new EnderecoRepository();
        public int codEndereco;
        public bool edita = false;

        public FormCadastroEndereco()
        {
            InitializeComponent();
        }

        private void FormCadastroEndereco_Load(object sender, EventArgs e)
        {
            if (edita)
                CarregaCampos();
            else
                tbCodEndereco.Text = enderecoRepository.GetNextCodEndereco().ToString();
        }

        private void CarregaCampos()
        {
            Endereco endereco = enderecoRepository.GetByCodEndereco(codEndereco);

            tbCodEndereco.Text = endereco.CODENDERECO.ToString();
            tbNomeEndereco.Text = endereco.NOME;
            tbRua.Text = endereco.RUA;
            tbNumero.Text = endereco.NUMERO;
            tbComplemento.Text = endereco.COMPLEMENTO;
            tbBairro.Text = endereco.BAIRRO;
            tbCEP.Text = endereco.CEP;
            tbCidade.Text = endereco.CIDADE;
            tbEstado.Text = endereco.ESTADO;
            tbPais.Text = endereco.PAIS;
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM ENDERECO WHERE CODENDERECO = {codEndereco}"))
                {
                    enderecoRepository.Add(new Endereco
                    {
                        CODENDERECO = Convert.ToInt32(tbCodEndereco.Text),
                        NOME = tbNomeEndereco.Text,
                        RUA = tbRua.Text,
                        NUMERO = tbNumero.Text,
                        COMPLEMENTO = tbComplemento.Text,
                        BAIRRO = tbBairro.Text,
                        CEP = tbCEP.Text,
                        CIDADE = tbCidade.Text,
                        ESTADO = tbEstado.Text,
                        PAIS = tbPais.Text,
                    });
                    codEndereco = Convert.ToInt32(tbCodEndereco.Text);
                }
                else
                {
                    enderecoRepository.Update(new Endereco
                    {
                        CODENDERECO = Convert.ToInt32(tbCodEndereco.Text),
                        NOME = tbNomeEndereco.Text,
                        RUA = tbRua.Text,
                        NUMERO = tbNumero.Text,
                        COMPLEMENTO = tbComplemento.Text,
                        BAIRRO = tbBairro.Text,
                        CEP = tbCEP.Text,
                        CIDADE = tbCidade.Text,
                        ESTADO = tbEstado.Text,
                        PAIS = tbPais.Text,
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

        private async void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            Endereco endereco = await ViaCepService.BuscarEnderecoAsync(tbCEP.Text);

            if (endereco != null)
            {
                tbRua.Text = endereco.RUA;
                tbBairro.Text = endereco.BAIRRO;
                tbEstado.Text = endereco.ESTADO;
                tbCidade.Text = endereco.CIDADE;
                tbPais.Text = endereco.PAIS;
            }
            else
            {
                MessageBox.Show("CEP não encontrado.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbNumero_Click(object sender, EventArgs e)
        {

        }
    }
}
