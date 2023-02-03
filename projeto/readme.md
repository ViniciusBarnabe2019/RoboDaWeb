## Sobre o Robo:
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/ViniciusBarnabe2019/RoboDaWeb?label=Tamanho%20do%20Repositorio)
![GitHub last commit](https://img.shields.io/github/last-commit/ViniciusBarnabe2019/RoboDaWeb?label=%C3%9Altimo%20Commit%20)

ÍEsse Robo da Web (Web Scraping) vem com o intuito de acessar e pegar dados de sites já pré-definidos nas categorias referentes a Economia (Bitcoin, Euro e Dólar), Climas (Umidade, Arco-Íris, Previsão de Chuva em sua Cidade) e Notícias (Noticiais Atuais do Portal Uol).

Em seguida, ao raspar os dados presentes nos sites pré-definidos em nosso script, nosso robo notificará via email o usuário que assim quiser ser notificado!

## Modo de Uso:
Antes de sair usando o Robo, você tem que dizer ao Robo o email que irá enviar as informações raspadas.
Para isso, basta modificar o Parâmetro da Classe Mail Adress e o Parâmetro da Função Add:

```csharp
//Endereços da Msg
mail.From = new MailAddress("de@email.com"); //de
mail.To.Add("para@email.com"); //para
```

Em seguida, não se esqueça de passar suas credenciais de acesso para que seja possível acessar o SMTP do Gmail (Sua Conta)...

```csharp
Credentials = new NetworkCredential("email@email.com", "sua senha aq"), //dados acesso
```
## Avisos:
O Envio de Emails de nosso Robo só foi testado para trabalhar com o SMTP do Gmail, logo, caso você opte usar um outro SMTP, não dou garantias de seu funcionamento!

## Dependências:
![Nuget](https://img.shields.io/nuget/dt/HtmlAgilityPack?label=HtmlAgilityyPack)
