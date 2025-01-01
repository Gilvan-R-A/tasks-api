<h1 align="center">
   API de Tarefas
</h1>   

## Descrição   

Este projeto é uma API desenvolvida em **C#** utilizando **ASP.NET Core**, com **Entity Framework Core**, para gerenciar tarefas. A API permite criar, listar, atualizar e excluir tarefas, com informações como título, descrição, data de criação e status. A aplicação foi configurada para usar o banco de dados **SQL Server**.   

## Tecnologias Utilizadas   

- **ASP.NET Core** (Framework para criação da API)
- **Entity Framework Core** (ORM para manipulação de dados)
- **SQL Server** (Banco de Dados)
- **Swagger** (Documentação interativa da API)   

## Estrutura do Projeto   

O projeto está organizado da seguinte forma:   

```   
tasks-api/
│
├── Controllers/                 # Controladores da API
│   └── TarefasController.cs
│
├── Migrations/                  # Arquivos de migração do Entity Framework
│   ├── CriacaoTabelaTarefa.cs
│   ├── AdicionaPropriedadeDescricaoNaTabela.cs
│   └── ...
│
├── Models/                      # Modelos de dados
│   ├── EnumStatusTarefa.cs
│   └── Tarefa.cs
│
├── Properties/                  # Arquivos de configuração do projeto
│   ├── launchSettings.json
│   └── ...
│
├── appsettings.json             # Configurações do ambiente
├── appsettings.Development.json # Configurações específicas para o ambiente de desenvolvimento
├── Program.cs                   # Inicialização e configuração da aplicação
├── Desafio-C#-API.csproj        # Arquivo de projeto do .NET
└── README.md                    # Documentação do projeto
```   

## Funcionalidades da API   

**Endpoints**   

**1. GET /tarefas**  

   - **Descrição:** Lista todas as tarefas.   
   - **Resposta:** Um array de tarefas.   

**2. GET /tarefas/{id}**   

   - **Descrição:** Retorna uma tarefa espedífica.   
   - **Parâmetros:**   
      - **id**: O ID da tarefa.   

**3. POST /tarefas**   

   - **Descrição:** Cria uma nova tarefa.   
   - **Corpo da Requisição:**   

```   
{
  "titulo": "Título da tarefa",
  "descricao": "Descrição da tarefa",
  "data": "2025-01-01T00:00:00",
  "status": "Pendente"
}
```   

**4. PUT /tarefas/{id}**   

   - **Descrição:** Atualiza os dados de uma tarefa existente.   
   - **Parâmetros:**   
      - **id**: O ID da tarefa.   

   - **Corpo da Requisição:**   

```   
{
  "titulo": "Novo título da tarefa",
  "descricao": "Nova descrição",
  "data": "2025-01-02T00:00:00",
  "status": "Finalizado"
}
```   

**5. DELETE /tarefas/{id}**   

   - **Descrição:** Exclui uma tarefa.   
   - **Parâmetros:**   
      - **id**: O ID da tarefa.   


## Modelos de Dados   

- **Tarefa:**   

```   
public class Tarefa
{
    public int Id { get; set; } 
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set;}
    public EnumStatusTarefa Status { get; set; }
}
```   

- **EnumStatusTarefa:**   

```   
public enum EnumStatusTarefa
{
    Pendente,
    Finalizado
}
```   

## Como Rodar o Projeto   

**Requisitos**   

- .NET 7.0 ou superior
- SQL Server

**Passos para Rodar**   

1. Clone o repositório do projeto:   

```   
git clone https://github.com/Gilvan-R-A/tasks-api.git
```

2. Navegue até o diretório do projeto:   

```   
cd tasks-api
```   

3. Restaure as dependências:   

```   
dotnet restore
```   

4. Configure a string de conexão no arquivo **appsettings.Development.json** para o banco de dados:   

```   
"ConnectionStrings": {
  "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=Organizador; Integrated Security=True; TrustServerCertificate=True"
}
```   

5. Execute as migrações para criar o banco de dados:   

```   
dotnet ef database update
```   

6. Execute a aplicação:   

```   
dotnet run
```   

7. Acesse a API em **http://localhost:5000** e visualize a documentação no Swagger em **http://localhost:5000/swagger**   


## Testes   

Os testes podem ser realizados utilizando o Swagger UI ou por meio de ferramentas como Postman ou curl para interagir com os endpoints.   

## Contribuição   

1. Faça um fork do repositório.
2. Crie uma nova branch: git checkout -b minha-feature.
3. Faça as alterações desejadas e adicione os arquivos alterados: git add ..
4. Commit as alterações: git commit -m 'Adiciona nova funcionalidade'.
5. Envie para o repositório: git push origin minha-feature.
6. Abra um Pull Request.

