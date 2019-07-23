using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace CSharpSlack
{
    public class SlackClient
    {
        private readonly Uri _uri;
        private readonly Encoding _encoding = new UTF8Encoding();

        public SlackClient(string acesstoken)
        {
            _uri = new Uri(acesstoken);
        }

        public void PostMessage(string text,string username=null,string channel = null)
        {
            Payload payload = new Payload()
            {
                Channel = channel,
                Username = username,
                Text = text
            };
            PostMessage(payload);
        }
        public void PostMessage(Payload payload)
        {
            string payloadJson = JsonConvert.SerializeObject(payload);
            using (WebClient client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["payload"] = payloadJson;
                var response = client.UploadValues(_uri, "POST", data);

                string responseText = _encoding.GetString(response);
            }
        }
    }
}
