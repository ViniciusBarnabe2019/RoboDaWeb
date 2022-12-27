while(true){
    Console.WriteLine("Economia [1] - Clima [2] - Notícias [3] - SAIR [0]");
    var opcao = Console.ReadLine();

    if(opcao == "1"){
        //Economia
        while(true){
            Console.WriteLine("Dólar [1] - Euro [2] - Bitcoin [3] - Voltar [0]");
            var entrada = Console.ReadLine();

            if(entrada == "1"){
                var dolar = new Scraping();//novo objeto
                var retorno = dolar.Dolar(); //cotação dolar
                
                var email = new Email("Cotação Dólar em R$: " + retorno);
                email.Enviar();
            }
            else if(entrada == "2"){
                var euro = new Scraping();//novo objeto
                var retorno = euro.Euro(); //cotação euro
                
                var email = new Email("Cotação Euro em R$: " + retorno);
                email.Enviar();
            }
            else if(entrada == "3"){
                var bitcoin = new Scraping();//novo objeto
                var retorno = bitcoin.Bitcoin(); //cotação bitcoin
                
                var email = new Email("Valor do Bitcoin: " + retorno);
                email.Enviar();
            }
            else if(entrada == "0"){
                Console.Clear();
                break;
            }
            else {
                Console.Clear();
                Console.WriteLine("Digite Uma Opção Válida...!");
            }
        }
    }
    else if(opcao == "2"){
        //Clima
        var clima = new Scraping();//novo objeto
        var retorno = clima.Clima(); //dados do clima
        
        var email = new Email(retorno);
        email.Enviar();
    }
    else if(opcao == "3"){
        //Notícia
        var noticias = new Scraping();//novo objeto
        var retorno = noticias.Noticia();    // LISTA de notícias     
        string texto = "";

        for(var f = 0; f < retorno.Count; f++){
            texto += retorno[f] + "\n";
        }

        var email = new Email(texto);
        email.Enviar();
    }
    else if(opcao == "0"){
        Console.WriteLine("Até Mais...");
        break;
    }
    else {
        Console.Clear();
        Console.WriteLine("Digite Uma Opção Válida...!");
    }
}