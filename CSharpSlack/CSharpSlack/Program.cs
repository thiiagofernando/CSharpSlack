namespace CSharpSlack
{
    class Program
    {
        static void Main(string[] args)
        {
            Menssage();
        }

        public static void Menssage()
        {
            //Usuário que vai enviar as mensagens
            string username = "MeuBot";
            //canal que será enviado as mensagens
            string channel = "#ChannelAlert";
            //mensagem que será enviada
            string message = "Hello World!!";
            //token de acesso no canal gerado no slack
            string token = "TL20X8PS7/BLQA4LV38/2UOSfwIRkSkFgPoX34eIL17R";

            SlackClientSend.PostMessage(message, token, username, channel);
        }
    }
}
