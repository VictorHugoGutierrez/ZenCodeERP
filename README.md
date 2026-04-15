# ZenCode ERP | Sistema de Gestão Empresarial

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MySQL](https://img.shields.io/badge/mysql-4479A1.svg?style=for-the-badge&logo=mysql&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

O **ZenCode ERP** é um sistema completo de gestão empresarial desenvolvido para ambiente Desktop (WinForms). Construído como um Projeto de Extensão Universitária, a aplicação oferece controle robusto de estoque, fluxo financeiro e administração multiempresa com alto rigor de segurança e controle de acesso.

## 🌟 Principais Funcionalidades

* 🏢 **Arquitetura Multiempresa:** Permite a seleção da empresa/filial diretamente na tela de login, garantindo o isolamento correto dos dados operacionais.
* 📦 **Gestão Administrativa:** Cadastro e controle completo de estoque, base de clientes e catálogo de produtos.
* 💰 **Controle Financeiro:** Gerenciamento preciso de movimentações financeiras, acompanhamento de receitas e despesas.
* 📊 **Relatórios Mensais:** Geração e emissão de relatórios para acompanhamento de métricas e fechamentos de mês.
* 🔐 **Segurança e Controle de Acesso:**
  * Autenticação com **senhas criptografadas** no banco de dados.
  * Sistema avançado de **permissões por usuário**, restringindo ou liberando o acesso a módulos específicos do ERP de acordo com o perfil.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET / Windows Forms (WinForms)
* **Banco de Dados:** MySQL

## 🚀 Como Executar Localmente

### Pré-requisitos
* **Visual Studio** (com a carga de trabalho de "Desenvolvimento para Desktop com .NET" instalada).
* **Servidor MySQL** (local ou remoto) configurado e ativo.

### Passo a Passo de Instalação

1. Clone este repositório em sua máquina local:
   ```bash
   git clone [https://github.com/VictorHugoGutierrez/ZenCodeERP.git](https://github.com/VictorHugoGutierrez/ZenCodeERP.git)
   ```
2. Abra o arquivo da Solução (.sln) no Visual Studio.

3. Importe a estrutura do banco de dados executando o script SQL (se fornecido na raiz do projeto) no seu servidor MySQL.

4. Localize a classe ou arquivo de configuração da String de Conexão (Connection String) no código-fonte e ajuste as credenciais (Servidor, Usuário, Senha e Banco de Dados) para as da sua máquina.

5. No Visual Studio, pressione F5 (ou vá em Iniciar > Iniciar Depuração) para compilar e executar o sistema.
