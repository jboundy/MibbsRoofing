using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using MibbsRoofing.Models.Mail;
using MibbsRoofing.Settings;
using Newtonsoft.Json.Linq;

namespace MibbsRoofing.Services
{
    public class MailService
    {
        private MailjetClient _client;
        public MailService(SmtpConfiguration config)
        {
            _client = new MailjetClient(config.PublicKey, config.SecretKey);
        }

        public MailjetRequest CreateRequest(MailWrapper mail)
        {
            return new MailjetRequest
                {
                    Resource = Template.Resource
                }
                .Property(Template.ID, mail.TemplateId)
                .Property(Send.FromEmail, mail.FromAddress)
                .Property(Send.To, mail.ToAddress)
                .Property(Send)
        }

        public async Task<MailjetResponse> SendMailAsync(MailjetRequest request)
        {
            return await _client.PostAsync(request);
        }
    }
}
