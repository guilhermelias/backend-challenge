# Introdução
API básica para validação de senha.

# Request
Deve-se passar chave "string" e valor do tipo string no formato json conforme exemplo:
{
    "senha": "AbTp9!fok"
}

A senha deve conter:
- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial, sendo eles: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

# Response
A API irá retornar true para quando a senha for válida e false quando inválida, com o http status 200.

# Dependências
Necessário .NET 6.0 ou superior para subir a aplicação.
