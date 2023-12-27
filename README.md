INTEGRAÇÃO CHATGPT
Criei um endpoint para realizar a integração com ChatGpt

Introdução
Este projeto foi desenvolvido utilizando .NET 8 para criar uma integração com o ChatGPT da OpenAI. A aplicação utiliza uma chave de API do ChatGPT, que deve ser configurada como uma variável de ambiente.

Pré-requisitos
Certifique-se de ter instalado:

.NET 8 SDK
Conta no OpenAI para obter a chave de API do ChatGPT
Configuração
Chave de API do ChatGPT:

Registre-se no OpenAI para obter sua chave de API do ChatGPT.
Defina a chave como uma variável de ambiente chamada OPENAI_API_KEY.
Executando o projeto:

Clone este repositório.
Abra o terminal na pasta do projeto.
Execute dotnet build para compilar o projeto.
Execute dotnet run para iniciar a aplicação.
Uso
Descreva como usar sua aplicação:

Passo 1: Configure a variável de ambiente OPENAI_API_KEY.
Passo 2: Inicie a aplicação.
Passo 3: Utilizando o postman, Faça uma requisição do tipo GET, adicionando o Params com chave "promp" e a pergunta ou mensagem desejada no value.
