using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net.NetworkInformation;
namespace DatabaseDiary
{
    public partial class SendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("[email-id@host.com]", TextBox1.Text, TextBox2.Text, TextBox3.Text);
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential(TextBox1.Text, [password]);
            smtp.UseDefaultCredentials = true;
           // SmtpDeliveryMethod.Network;
            smtp.Port = 587;
            smtp.Send(mail);
        }
    }
}
