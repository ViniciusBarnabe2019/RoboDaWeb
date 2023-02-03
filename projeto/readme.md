## Sobre o Robo:

![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/ViniciusBarnabe2019/RoboDaWeb?label=Tamanho%20do%20Repositorio)
![GitHub last commit](https://img.shields.io/github/last-commit/ViniciusBarnabe2019/RoboDaWeb?label=%C3%9Altimo%20Commit%20)

Esse Robo da Web (Web Scraping) vem com o intuito de acessar sites pré-definidos das categorias referentes a Economia, Climas e Notícias.

Em seguida, ao raspar os dados presentes nos sites pré-definidos em nosso script, nosso robo notificará via email o usuário que assim quiser ser notificado!

## Modo de Uso:

Antes de sair usando o Robo, você tem que dizer ao Robo o email que irá enviar as informações raspadas.
Para isso, basta modificar o Parâmetro da Classe Mail Adress e o Parâmetro da Função Add:

```
//Endereços da Msg
mail.From = new MailAddress("de@email.com"); //de
mail.To.Add("para@email.com"); //para
```

Em seguida, 

## Dependências:
![Nuget](https://img.shields.io/nuget/dt/HtmlAgilityPack?label=HtmlAgilityyPack)
