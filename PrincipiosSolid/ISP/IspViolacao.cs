namespace PrincipiosSolid.ISP;

public interface IDispositivoEletronico
{
    void Ligar();
    void Desligar();
    void ConectarWifi();
    void ConectarBluetooth();
}


public class Fogao : IDispositivoEletronico
{
    //nao tem wifi nem bluetooth
}