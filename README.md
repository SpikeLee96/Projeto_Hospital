# Projeto Hospital

Projeto Hospital é um desafio proposto para uma entevista de emprego que passei do qual consiste em criação de CRUDs para determinadas entidades planejadas, validações por back e front-end, e geração de banco de dados a partir de models pré-configuradas com Data Annotations (code first).
O projeto permite cadastrar pacientes, tipos de exames, exames e marcação de consultas. Também foi necessário usar bootstrap para gerar templates.

Passos para rodar a aplicação:

1. Instalar Visual Studio(2019), SQL Server, e SQL Server Managment Studio;
2. Fazer download do projeto e roda-lo com o arquivo Projeto CRUD.sln;
3. Ir em Exibir > Terminal e digitar as seguintes linhas (sem as aspas):
  a. "Install-Package Microsoft.EntityFrameworkCore.SqlServer"
  b. "Install-Package Microsoft.EntityFrameworkCore.Tools"
  c. "EntityFrameworkCore\update-database"
4. Após as instalações bem sucedidas do passo anterior, pressionar Ctrl+Shift-B;
