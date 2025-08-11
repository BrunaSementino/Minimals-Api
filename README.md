Minimals-Api ✨

Uma Minimal API em ASP.NET Core (.NET 9) para começar rápido, crescer bonito e se divertir no caminho! 🚀

Status: Em construção… mas já cheia de potencial! 💪

🔥 Por que este projeto é legal?

👇 Pouco boilerplate: foco no essencial com Minimal APIs.

🧩 Camadas organizadas (Domínio/Infra): fácil de dar manutenção.

🔐 Rumo ao JWT + Roles: segurança sem drama.

📖 Swagger/OpenAPI: testar endpoints é quase um passeio no parque. 🌳

🧪 Testes (planejado): qualidade que dá orgulho. 😎

🧰 Stack

.NET 9 SDK

ASP.NET Core (Minimal APIs)

Entity Framework Core (opcional)

MySQL 8.x (opcional)

Docker (opcional)

🗂️ Estrutura do projeto

Minimals-Api/
├── Dominio/               # Regras de negócio (entidades, serviços/contratos)
├── Infraestrutura/        # Repositórios, mapeamentos, integrações
├── Program.cs             # Bootstrap + endpoints (Minimal APIs)
├── minimals-api.csproj    # Projeto
└── minimals-api.sln       # Solução

Camadas resumidas

Domínio: coração da regra de negócio 💓

Infraestrutura: conversa com o mundo externo 🌎

API: DI, middlewares e endpoints 🛣️

Dica: crie pastas como Endpoints/, DTOs/, Validators/ quando fizer sentido. 🧱

▶️ Como rodar localmente

1) Pré‑requisitos

.NET 9 SDK instalado (dotnet --version)

(Opcional) MySQL 8.x running

2) Restaurar e compilar

# Raiz do Projeto
 dotnet restore
 dotnet build

3) Executar

 dotnet run

Abra http://localhost:<porta> e, quando o Swagger estiver ligado, visite /swagger. 😍

Pro tip: dotnet watch run para hot reload 🔁

🗄️ Banco de dados (opcional)

Se for usar EF Core + MySQL, um appsettings.Development.json típico:

{
  "ConnectionStrings": {
    "Default": "Server=localhost;Port=3306;Database=MinimalsApiDb;User=root;Password=senha;SslMode=None;"
  }
}

Variáveis úteis:

ASPNETCORE_ENVIRONMENT=Development

ConnectionStrings__Default

Com migrations:

# instalar a ferramenta (uma vez)
dotnet tool install --global dotnet-ef

# criar migration
dotnet ef migrations add Inicial

# aplicar no banco
dotnet ef database update

Ainda não tem DbContext? Relaxa: esta seção é um guia para quando integrar o EF Core. 😄

🔐 Autenticação & Autorização (roadmap)

JWT Bearer ✅

Roles (ex.: Admin/User) ✅

Endpoint para emitir/renovar tokens ✅

Enquanto isso, evite expor endpoints sensíveis. 🛡️

📘 Documentação (Swagger)

Habilitar Swagger/OpenAPI para explorar endpoints com clique. 🖱️

Versionamento (ex.: v1, v2).

Quando ativo: http://localhost:<porta>/swagger 🎯

🧪 Testes

Unidade (Domínio) 🧠

Integração (API/Infra) 🔌

Sugestão de layout:

/tests
 ├── Dominio.Tests/
 ├── Infraestrutura.Tests/
 └── Api.Tests/

Rodar com:

dotnet test

🐳 Docker (opcional)

Dockerfile base:

# build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app

# runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "minimals-api.dll"]

Build & run:

docker build -t minimals-api .
docker run -p 8080:8080 minimals-api

Usará MySQL em container? Crie uma rede e aponte a ConnectionStrings:Default para o serviço do banco. 🔗

🧭 Convenções que deixam tudo redondinho

Commits: Conventional Commits (feat:, fix:, docs:…).

Branches: main (estável), dev (integração), feat/* (feature).

Code style: dotnet format no CI.

Observabilidade (futuro): logs estruturados, métricas e tracing com OpenTelemetry. 📈

🗺️ Roadmap do amor ❤️



🤝 Contribuindo

Abra uma issue com a ideia/bug.

Crie uma feature branch a partir de dev.

Faça um PR caprichado explicando o que mudou. ✨

📄 Licença

Defina uma licença (ex.: MIT). Sem LICENSE, o uso por terceiros fica sem regra clara. 📜

Feito com carinho e café ☕💙 — bora construir algo incrível!

