# SysInventor

**Sistema de Inventário - Gestão de Inventário Desktop**

Versão: Console App (.NET 8) otimizada para Visual Studio Code.

## Conteúdo
- Projeto em C# (.NET 8)
- Banco SQLite pré-populado (`inventory.db`) com 100 produtos eletrônicos realistas
- Scripts: `run.sh` (Linux/macOS) e `run.ps1` (Windows)
- Arquivos `.vscode/launch.json` e `.vscode/tasks.json` para depuração
- Funcionalidades: Listar, Adicionar, Editar, Excluir, Buscar, Exportar CSV

## Como usar
1. Tenha o .NET 8 SDK instalado:
   `dotnet --version` (deve exibir algo como `8.x.x`)
2. Abra a pasta no VS Code.
3. Restaure dependências:
   `dotnet restore`
4. Execute:
   `dotnet run`
   ou use `run.sh` / `run.ps1`.

## Observações
- O banco `inventory.db` será criado automaticamente se não existir. Neste pacote ele já vem pré-populado com 100 itens.
- Para ver o banco use uma extensão SQLite no VS Code ou ferramentas como `DB Browser for SQLite`.

## Licença
Projeto de exemplo para estudos.
