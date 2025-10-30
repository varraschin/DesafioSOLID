namespace PrincipiosSolid.OCP;

public class Notificador
{
    public void Notificar(string tipo)
    {
        if (tipo == "email")
            Console.WriteLine("Enviando email...");
        else if (tipo == "sms")
            Console.WriteLine("Enviando SMS...");
    }
}
