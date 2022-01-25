using DesignPattern.Bridge;

Console.WriteLine("Input message");
var message = Console.ReadLine();

if (!string.IsNullOrEmpty(message))
{
    if (message.Length > 10)
    {
        var longMessage = new LongMessage(new EmailMessageSender());
        longMessage.SendMessage(message);
    } 
    else
    {
        var shortMessage = new ShortMessage(new SmsMessageSender());
        shortMessage.SendMessage(message);
    }
}

Console.ReadKey();