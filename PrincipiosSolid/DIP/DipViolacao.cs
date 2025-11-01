namespace PrincipiosSolid.DIP;

public class CozinhaItaliana
{
    public void PrepararPrato();
}

public class Restaurante
{
    private CozinhaItaliana _cozinha = new CozinhaItaliana();

    public void ServirPrato()
    {
        _cozinha.PrepararPrato();
        Console.WriteLine("Servindo prato");
    }
}

