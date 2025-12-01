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
using ZstdSharp.Unsafe;

namespace ZenCodeERP.Forms
{
    public partial class FormCadastroClassificacao : Form
    {
        private ClassificacaoRepository classificacaoRepository = new ClassificacaoRepository();
        public int codClassificacao;
        public bool edita = false;

        public FormCadastroClassificacao()
        {
            InitializeComponent();
        }

        private void FormCadastroClassificacao_Load(object sender, EventArgs e)
        {
            if (edita)
                CarregaCampos();
            else
            { 
                tbCodClassificacao.Text = classificacaoRepository.GetNextCodClassificacao(AppZenCodeContext.CodEmpresa).ToString();
                tbCodEmpresa.Text = AppZenCodeContext.CodEmpresa.ToString();
            }
        }

        private void CarregaCampos()
        {
            Classificacao classificacao = classificacaoRepository.GetByCodClassficacao(AppZenCodeContext.CodEmpresa, codClassificacao);

            tbCodEmpresa.Text = AppZenCodeContext.CodEmpresa.ToString();
            tbCodClassificacao.Text = classificacao.CODCLASSIFICACAO.ToString();
            tbNome.Text = classificacao.NOME;
            tbDescricao.Text = classificacao.DESCRICAO;
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM CLASSIFICACAO WHERE CODCLASSIFICACAO = {codClassificacao}"))
                {
                    classificacaoRepository.Add(new Classificacao
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODCLASSIFICACAO = Convert.ToInt32(tbCodClassificacao.Text),
                        NOME = tbNome.Text,
                        DESCRICAO = tbDescricao.Text,
                    });

                    codClassificacao = Convert.ToInt32(tbCodClassificacao.Text);
                }
                else
                {
                    classificacaoRepository.Update(new Classificacao
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODCLASSIFICACAO = Convert.ToInt32(tbCodClassificacao.Text),
                        NOME = tbNome.Text,
                        DESCRICAO = tbDescricao.Text,
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
