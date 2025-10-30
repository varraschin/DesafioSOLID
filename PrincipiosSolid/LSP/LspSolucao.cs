namespace PrincipiosSolid.LSP;

public class AnimalTerrestre
{
    public void Andar();
}
public class AnimalAquatico
{
    public void Nadar();
}

public class Elefante : AnimalTerrestre
{
    public void Andar();
}

public class Peixe : AnimalAquatico
{
    public void Nadar();
}
