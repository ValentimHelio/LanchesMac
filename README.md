
- Gerenciando certificados auto assinados:

-> dotnet dev-certs https --check (Verifica a existência do certificado de desenvolvimento, mas não executa nenhuma ação.)

-> dotnet dev-certs https (Gera um certificado auto assinado para https no desenvolvimento)

-> dotnet dev-certs https --trust (Confia no certificado na máquina local)
