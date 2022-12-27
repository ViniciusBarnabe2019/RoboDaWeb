using HtmlAgilityPack; 

public class Scraping {
    //Atributo
    private HtmlWeb web = new HtmlWeb(); 

    //Construtor
    public Scraping(){}      

    //Métodos
    public string Dolar(){
        var url = @"https://www.melhorcambio.com/dolar-hoje";
        var doc = web.Load(url);   //baixa o documento da 'pagina' do site

        return doc.DocumentNode.SelectSingleNode("//input[@id='comercial']").GetAttributeValue("value", "default").ToString();
    }

    public string Euro(){
        var url = @"https://www.melhorcambio.com/euro-hoje";
        var doc = web.Load(url);//baixa o documento da 'página' site

        return doc.DocumentNode.SelectSingleNode("//input[@id='comercial']").GetAttributeValue("value", "default").ToString();
    }

    public string Bitcoin(){
        var url = @"https://www.infomoney.com.br/cotacoes/cripto/ativo/bitcoin-btc/grafico/";
        var doc = web.Load(url);

        var div = doc.DocumentNode.SelectSingleNode("//div[@class='value']");
        string elemento = div.SelectSingleNode("p").InnerText;

        return elemento;
    }

    public string Clima(){
        var url = @"https://www.climatempo.com.br/previsao-do-tempo/cidade/2351/itapui-sp";
        var doc = web.Load(url);
        
        //Previsão
        string previsao = doc.DocumentNode.SelectSingleNode("//h1[@class='-bold -font-18 -dark-blue _margin-r-10 _margin-b-sm-5']").InnerText;
        
        //Legenda
        string legenda = doc.DocumentNode.SelectSingleNode("//p[@class='-gray -line-height-24 _center']").InnerText;
        
        //Temperatura Mínima
        string min = "Temperatura Mínima: " + doc.DocumentNode.SelectSingleNode("//span[@id='min-temp-1']").InnerHtml.ToString();
        
        //Temperatura Máxima
        string max = "Temperatura Máxima: " + doc.DocumentNode.SelectSingleNode("//span[@id='max-temp-1']").InnerHtml.ToString();
        
        //Chuva
        string chuva = "Chuva : " + doc.DocumentNode.SelectSingleNode("//span[@class='_margin-l-5']").InnerHtml.ToString();
        
        //Arco-íris
        string arco = doc.DocumentNode.SelectSingleNode("//p[@class='-gray _flex _align-center']").InnerText;
        
        return previsao + "\n" + 
            legenda  + "\n" +
            min      + "\n" +
            max      + "\n" +
            chuva    + "\n" +
            arco;
    }

    public List<string> Noticia(){ 
        var url = @"https://www.uol.com.br/";	//url
		var doc = web.Load(url);//documento do site

        List<string> noticias = new List<string>(); //cria lista

		var links = doc.DocumentNode.SelectNodes("//a[@class='hyperlink headlineSub__link']"); //pega lista de noticiais do documento
		
		foreach(HtmlNode node in links){
            //adiciona uma notícia por vez na lista
			noticias.Add("\n" + "Notícia: " + node.InnerText.Trim() + "\n" + " Link: " + node.GetAttributeValue("href", "Sem Link") + "\n");
		}
        return noticias; //retorna a lista
    }
}