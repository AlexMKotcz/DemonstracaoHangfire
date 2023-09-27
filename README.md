# DemonstracaoHangfire

Repositório criado para minha palestra no *8º encontro .NET Curitiba*, que aconteceu dia 27/09/2023 19h na UFPR (Universidade Federal do Paraná).

## *Hangfire*
*Hangfire* é uma biblioteca/ferramenta de código-fonte livre que ajuda a gerenciar processamento em segundo plano em aplicações .NET.

### A bibilioteca
Convido você a consultar [o link oficial do *Hangfire*](https://www.hangfire.io/).

## Instalação
Para que o *Hangfire* funcione, é preciso configurar a string de conexão ao banco de dados do *Hangfire*. Para isso, altere o arquivo ***appsettings.json***, alterando a propriedade **HangfireDatabase** com a sua string de conexão.

> **Importante:**
> O banco de dados do *Hangfire* já deve estar criado. Um simples ``CREATE DATABASE [NOMEDOBANCO]`` deve resolver.

## Utilização
Com o *Hangfire* configurado, você pode executar sua aplicação. Se não houverem erros e o *swagger* aparecer normalmente, está tudo bem.

Para acompanhar a utilização do **Hangfire**, você pode acessar *[SeuLinkLocalHost]/Hangfire*.

## Métodos e *Controllers*
No repositório, foram criadas duas *controllers*, uma *normal* e uma que utiliza o *Hangfire* na execução.

Nas controllers, existe um método específico para:
- Execução lenta (1 minuto);
- Execução com erro *sempre*;
- Execução com erro *intermitente*.

O intuito é que exista uma comparação da execução normal com a execução utilizando a ferramenta *Hangfire*. No contexto de uma aplicação real, espera-se que seja evidente os benefícios de utilização do *Hangfire*.

## Dúvidas e sugestões
Você pode entrar em contato comigo através do [meu LinkedIn](https://www.linkedin.com/in/alexmkotcz/).

Também sinta-se livre para melhorias neste repositório em si.

## Sobre o .NET Curitiba
*.NET Curitiba* é um encontro que acontece mensalmente em Curitiba e região, aberto à toda comunidade de TI. Caso queira saber mais, acompanhe [o Instagram da comunidade](https://www.instagram.com/dotnetcuritiba/).
