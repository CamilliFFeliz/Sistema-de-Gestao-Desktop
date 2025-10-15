# SysInventory

Aplicação desktop de exemplo em C# (Windows Forms) para gestão de estoque.

## Estrutura
- Models/Produto.cs
- DAL/Database.cs
- UI/FormPrincipal.cs
- UI/FormCadastroProduto.cs
- Program.cs
- SysInventory.csproj

## Como executar
1. Tenha o .NET SDK (6.0 ou superior) ou Visual Studio instalado.
2. Abra o diretório `SysInventory` no Visual Studio ou pelo terminal.
3. Se estiver usando o terminal (com dotnet SDK): `dotnet run`
   - Observação: Em alguns ambientes, executar WinForms com `dotnet run` requer GUI disponível.
4. Ao iniciar, o banco SQLite (`inventory.db`) será criado automaticamente no diretório do executável.

## Observações
- A UI foi criada de forma programática (sem arquivos Designer) para simplificar a portabilidade.
- O projeto usa `System.Data.SQLite.Core`. Instale via NuGet se necessário:
  `dotnet add package System.Data.SQLite.Core`
