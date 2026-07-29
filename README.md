# Sistema de Achados e Perdidos

Projeto Integrador desenvolvido no **Senac Lapa Tito** para apoiar o cadastro, a consulta e a devolução de objetos encontrados.

A aplicação foi construída como um sistema desktop em **C#**, utilizando **Windows Forms**, **.NET Framework 4.8** e integração com banco de dados **MySQL**.

## Objetivo

Centralizar o registro de objetos perdidos e facilitar o processo de consulta, identificação e devolução dos itens aos seus responsáveis.

## Funcionalidades

- Cadastro e login de usuários
- Registro de objetos encontrados
- Consulta e pesquisa de itens por descrição
- Visualização do status dos objetos
- Seleção de itens cadastrados
- Controle do processo de devolução
- Exclusão de registros
- Integração da interface com banco de dados MySQL

## Tecnologias utilizadas

- C#
- .NET Framework 4.8
- Windows Forms
- SQL
- MySQL
- Git
- GitHub

## Organização do projeto

O código foi separado em pastas de acordo com suas responsabilidades:

```text
Controllers/    Regras de interação entre telas, modelos e serviços
Model/          Modelos das entidades da aplicação
Repositorios/   Consultas e operações no banco de dados
Screen/         Telas e componentes da interface
Services/       Autenticação, conexão com o banco e serviços auxiliares
```

## Banco de dados

A aplicação utiliza o banco MySQL `achados_perdidos`.

A string de conexão está configurada no arquivo `App.config` e deve ser ajustada conforme o ambiente local:

```xml
<add
  name="MySqlConnection"
  connectionString="server=localhost;database=achados_perdidos;uid=root;pwd=;"
  providerName="MySql.Data.MySqlClient" />
```

> Para executar o projeto, o banco local precisa conter as tabelas esperadas pela aplicação. O script de criação do banco ainda será adicionado ao repositório.

## Como executar

1. Clone o repositório:

```bash
git clone https://github.com/jvtorlando/achados_e_perdidos_senac.git
```

2. Abra o arquivo `achados_e_perdidos_senac.sln` no Visual Studio.

3. Configure um servidor MySQL local.

4. Crie o banco de dados `achados_perdidos`.

5. Ajuste a string de conexão em `App.config`, caso necessário.

6. Restaure os pacotes NuGet e execute o projeto.

## Conceitos aplicados

- Programação orientada a objetos
- Desenvolvimento de aplicações desktop
- Integração entre aplicação e banco de dados
- Operações SQL de consulta, inserção e exclusão
- Uso de parâmetros em consultas SQL
- Organização do código por responsabilidades
- Validação de informações
- Tratamento de erros
- Versionamento colaborativo com Git e GitHub

## Contexto acadêmico

O sistema foi desenvolvido em equipe como **Projeto Integrador do curso de Tecnologia do Senac Lapa Tito**.

O projeto permitiu aplicar conhecimentos de desenvolvimento de software, banco de dados, trabalho em equipe, resolução de problemas e versionamento de código em uma solução completa.

## Próximas melhorias

- Adicionar o script SQL de criação do banco
- Incluir imagens das principais telas
- Melhorar o tratamento e o armazenamento de senhas
- Criar testes automatizados
- Padronizar nomes de métodos, classes e pastas
- Separar configurações locais do código versionado

## Equipe

Projeto desenvolvido em equipe no Senac Lapa Tito.

**Responsável por este repositório:** João Vitor Teixeira Orlando

- GitHub: [jvtorlando](https://github.com/jvtorlando)
- Consulte também o histórico de commits e a seção de contribuidores do repositório.
