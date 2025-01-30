# LanchesMac

## Gerenciando Certificados auto assinados.
- dotnet dev-certs https --chek (Verifica a existência do certificado de desenvolvimento, mas não executa nenhuma ação.)
- dotnet dev-certs https (Gera um certificado auto assinado para HTTPS no desenvolvimento.)
- dotnet dev-certs https --trust (confia no certificado na máquina local.)
