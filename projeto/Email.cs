using System.Net;
using System.Net.Mail;

public class Email {
    //Atributos
    public string conteudo; 

    //Construtor
    public Email(string corpo){
        this.conteudo = corpo;
    }

    private string getCorpo(){
        return this.conteudo;
    }

    //Métodos
    public void Enviar(){        
        //Objeto de Mensagem
        MailMessage mail = new MailMessage();

        //Endereços da Msg
        mail.From = new MailAddress("viniciusbarnabe2019@gmail.com"); //de
        mail.To.Add("viniciusbarnabe2017@hotmail.com"); //para

        //Conteudo da Msg
        mail.Subject = "Testando"; //titulo
        mail.Body = getCorpo(); //corpo

        //envia a mensagem
        SmtpClient smtp = new SmtpClient("smtp.gmail.com"){
            Port = 587, //porta de conexão
            Credentials = new NetworkCredential("viniciusbarnabe2019@gmail.com", "epnt omnq dqeo elft"), //dados acesso
            EnableSsl = true, //Criptografia
        };

        smtp.Send(mail); //envia o email
    }
}