
- Gerenciando certificados auto assinados:<br>
  1- Verifica a existência do certificado de desenvolvimento, mas não executa nenhuma ação. -> dotnet dev-certs https --chec<br>
  2- Gera um certificado auto assinado para https no desenvolvimento. -> dotnet dev-certs https<br>
  3- Confia no certificado na máquina local. -> dotnet dev-certs https --trust<br>


- Migrations - Package Manager Console:<br>
  1- Criar Migração -> Add-migration 'NomeDaMigração' [options]<br>
  2- Aplicar Migração -> update-dataBase [options]<br>
  3- Remover Migração -> remove-migration<br>

- Instalar a ferramenta de linha de comando do EF Core.<br>
  -> dotnet tool install --global dotnet-ef<br>
   1- Criar Migração -> dotnet ef migration add 'NomeDaMigração' [option]<br>
   2- Aplicar Migração -> dotnet ef database update [option]<br>
   3- Remover Migração -> dotnet ef migrations remove<br>

 
