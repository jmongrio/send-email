using System.Net.Mail;

string Origin = "email"; // Email out.
string Destiny = "email"; // Email in.
string Password = "email"; // Password of email out.

MailMessage ms = new MailMessage(Origin, Destiny, "Test", "It's a test message <b>automático</b>.");
ms.IsBodyHtml = true;

SmtpClient smtp = new SmtpClient("smtp.gmail.com"); // Gmail server, you can change to another email server.
smtp.EnableSsl = true;
smtp.UseDefaultCredentials = false;
smtp.Host = "smtp.gmail.com"; // Gmail server host
smtp.Port = 587; // Port of gmail server.
smtp.Credentials = new System.Net.NetworkCredential(Origin, Password);

smtp.Send(ms);

smtp.Dispose();