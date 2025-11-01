namespace PrincipiosSolid.DIP;

public interface ICozinha
{
    void PrepararPrato();
}

public class CozinhaItaliana : ICozinha
{
    public void PrepararPrato();
}

public class CozinhaJaponesa : ICozinha
{
    public void PrepararPrato();
}

public class Restaurante
{
    private readonly ICozinha _cozinha;

    public Restaurante(ICozinha cozinha);

    public void ServirPrato()
    {
        _cozinha.PrepararPrato();
        Console.WriteLine("Servindo prato");
    }
}


