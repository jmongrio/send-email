using System.Net.Mail;

string Origin = "email"; // Email out.
string Destiny = "email"; // Email in.
string Password = "password"; // Password of email out.

string EmailTemplate = //template html
@"
<html>
<head>
    <style>
        *{
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .container{
            margin: 0 10vw;
        }
         .h1{
            font-size: 2rem;
            font-weight: bold;
         }
         .text-center{
            text-align: center;
         }
         .align-items-center{
            align-items: center;
         }
         .justify-content-center{
            justify-content: center;
         }
         .btn{
            text-decoration: none;
         }
         .btn-secondary{
            background-color: #808080;
            border-radius: 5px;
         }
         .w-25{
            padding: 1% 5%;
         }
         .text-white{
            color: white;
         }
         .mt-2{
            margin-top: 25px;
         }
         p{
            margin-bottom: 25px;
         }
    </style>
</head>
<body>
    <div class=""container"">
        <h1 class=""h1 text-center"">Esto es un test de template</h1>
    </div>
    <div class=""container"">
        <div class=""row align-items-center justify-content-center"">
            <p class=""text-secondary"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit laboriosam officiis fugiat cum excepturi et
                explicabo pariatur iure eveniet autem architecto voluptates odio illum repellat, nesciunt incidunt delectus
                itaque eligendi. Ex aspernatur autem quos doloremque sequi magni et rem animi quaerat asperiores? Natus quas
                aliquam ab illo necessitatibus! Ad officia architecto ullam ab incidunt, vero sapiente ducimus earum soluta
                quidem impedit quam adipisci non et neque magni reprehenderit cum alias? Praesentium expedita officia
                architecto eos omnis.</p>
            <a class=""btn btn-secondary text-white w-25"" href=""https://google.com"">Test</a>
        </div>
    </div>
    <div class=""container mt-2"">
        <span class=""text-center"">Jason Mongrillo | all right reserved | 2023</span>
    </div>
</body>
</html>
";

MailMessage ms = new MailMessage(Origin, Destiny, "Test", EmailTemplate);
ms.IsBodyHtml = true;

SmtpClient smtp = new SmtpClient("smtp.gmail.com"); // Gmail server, you can change to another email server.
smtp.EnableSsl = true;
smtp.UseDefaultCredentials = false;
smtp.Host = "smtp.gmail.com"; // Gmail server host
smtp.Port = 587; // Port of gmail server.
smtp.Credentials = new System.Net.NetworkCredential(Origin, Password);

smtp.Send(ms);

smtp.Dispose();