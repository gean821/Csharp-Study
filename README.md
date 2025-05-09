# Csharp-Study


Voltado para estudos de C#


OBJETIVOS : 




✅ ETAPA 1 – Ambientação com a linguagem (1-2 dias)
Foco: revisar e adaptar sua lógica Java para a sintaxe C#

Estude e pratique:

using, namespace, class, Main, Console.WriteLine

Declaração de variáveis (int, string, var)

Métodos com parâmetros, retorno, sobrecarga

Classes, encapsulamento (get; set;)

Listas (List<T>), dicionários (Dictionary<TKey, TValue>)

foreach, if, switch, while

Material recomendado:

Documentação oficial da Microsoft (C# Fundamentals)

✅ ETAPA 2 – Preparação para APIs (1-2 dias)
Foco: construir estrutura de dados e retorno em formato JSON

Estude e pratique:

Criar classes DTO (record ou class)

Trabalhar com listas e simular um "banco em memória"

Serializar/deserializar com System.Text.Json

Criar métodos que retornam JSON

csharp
Copiar
Editar
var users = new List<User> {
    new User("Gean", "gean@email.com"),
    new User("Ana", "ana@email.com")
};

record User(string Name, string Email);
Dica: simule já o comportamento da API antes de codar a rota.

✅ ETAPA 3 – Minimal API na prática (2-4 dias)
Foco: criar rotas reais de API com .NET 6/7/8

Estude e pratique:

Criar projeto: dotnet new web -o MinhaApi

Entender a estrutura do Program.cs

Rotas básicas:

csharp
Copiar
Editar
app.MapGet("/usuarios", () => users);
app.MapPost("/usuarios", (User user) => { users.Add(user); return Results.Created("/usuarios", user); });
Trabalhar com IResult, Results.Ok(), Results.NotFound(), etc.

Testar com Postman, ThunderClient (VSCode), ou curl

Dica: crie uma API de tarefas, produtos ou usuários.

✅ ETAPA 4 – Evoluindo com boas práticas (4-6 dias)
Foco: separar responsabilidades e preparar para algo mais real

Estude e pratique:

Separar camadas: Models, Services, Repositories

Injeção de dependência (DI): builder.Services.AddSingleton<IMeuServico, MeuServico>()

Validação com DataAnnotations

Documentação com Swagger: builder.Services.AddEndpointsApiExplorer(); e AddSwaggerGen()

Logging básico

Criação de Middleware simples (opcional)

🛠 Ferramentas Recomendadas:
IDE: Visual Studio ou VS Code com C# Extension

CLI: dotnet new, dotnet run, dotnet watch run

Teste de API: Postman ou Thunder Client

🧭 Resumo do Caminho
Etapa	Meta	Tempo sugerido
1	Sintaxe base do C#	1–2 dias
2	Manipular dados (JSON)	1–2 dias
3	Criar e testar Minimal API	2–4 dias
4	Separar camadas e boas práticas	4–6 dias