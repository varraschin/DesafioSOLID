namespace PrincipiosSolid.OCP;


public abstract class Notificador
{
    public abstract void Notificar(); 
}

public class EmailNotificacao : Notificador
{
    public override void Notificar()
    {
        Console.WriteLine("Enviando email...");
    }
}

public class SmsNotificacao : Notificador
{
    public override void Notificar()
    {
        Console.WriteLine("Enviando SMS...");
    }
}
