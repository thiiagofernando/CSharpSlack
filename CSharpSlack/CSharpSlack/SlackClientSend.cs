namespace CSharpSlack
{
    public class SlackClientSend
    {
        public static void PostMessage(string message, string token,string userName,string Channel)
        {
            string acessToken = $"http://hooks.slack.com/services/{token}";
            SlackClient client = new SlackClient(acessToken);

            client.PostMessage(username: userName,
                    text: message,
                    channel: Channel);

        }
    }
}
