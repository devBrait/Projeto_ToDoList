# Projeto de uma API de Listagem de Tarefas (ToDoList)

A ideia desse projeto é colocar em prática o conhecimento em .Net e focando no uso de Entity Framework.

# Linguagens utilizadas:

- .Net 6: Utilizado como framework principal para o desenvolvimento da aplicação.
- Entity Framework
- SQL Server: a conexão utilizada com o servidor foi a (localdb)\MSSQLLocalDB.

# Conceitos aplicados:

- Code First
- Repositories
- Desenvolvimento em camadas: Organização do projeto em camadas (Controllers, Services, Repositories) para promover melhor organização da aplicação.

# Principais Endpoints:

- GET '/api/tasks': Retorna todas as tarefas cadastradas.
- POST '/api/tasks': Adiciona uma nova tarefa.
- PUT '/api/tasks/{id}': Atualiza uma tarefa existente pelo ID.
- DELETE '/api/tasks/{id}': Remove uma tarefa pelo ID.

## Endpoints alternativos:

- GET '/api/tasks/{id}: Retorna uma tarefa específica pelo ID.

# Execução 

Embora o Visual Studio seja a principal IDE para o desenvolvimento .NET, escolhi o VS Code por sua leveza e melhor desempenho em minha máquina. Fique à vontade para escolher sua própria IDE, vou explicar o passo a passo de execução no VS Code, da mesma forma que eu utilizo.

- Primeiro acesse o site oficial da Microsoft e instale o SDK.Net: https://dotnet.microsoft.com/pt-br/download/dotnet-framework

- Verificar versão instalada:
  
         dotnet --version
  
  - Rodar Projeto:

        dotnet run
  #### Lembre de abrir o terminal integrado com a solução Projeto.API.

### Outras instalações necessárias:

- Lembre-se de adicionar o Entity Framework ao projeto com os seguintes comandos:

   1. Microsoft.EntityFrameworkCore:

            dotnet add package Microsoft.EntityFrameworkCore --version 6.0.1
    2. Microsoft.EntityFrameworkCore.Design:

            dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.1
    3. Microsoft.EntityFrameworkCore.SqlServer:

            dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.1
    4. Microsoft.EntityFrameworkCore.Tools:

            dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.1
    #### ⚠️AVISO: é necessário baixar o EF CORE antes de tentar executar o projeto.


### Muito obrigado por ler até aqui e espero que tenha gostado!







