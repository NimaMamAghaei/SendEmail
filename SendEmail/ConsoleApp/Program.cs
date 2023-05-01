try
{
    var smtpClient = new System.Net.Mail.SmtpClient
    {
        Credentials = new System.Net.NetworkCredential(userName: "Your Gmail", password: "App Password Code"), // Use App Password Generated instead of Password
        Host = "smtp.gmail.com",
        Port = 587,
        EnableSsl = true,
    };

    var smtpSender = new FluentEmail.Smtp.SmtpSender(smtpClient: smtpClient);

    FluentEmail.Core.Email.DefaultSender = smtpSender;

    var response = await FluentEmail.Core.Email
        .From("Your Gamil")
        .To("Gmail recipient")
        .Subject("Subject")
        .Body("Messages")
        .SendAsync();


    if (response.Successful)
    {
        System.Console.WriteLine(value: "Email sent..");
    }
}
catch (System.Exception exception)
{
    System.Console.WriteLine(value: exception.Message);
}