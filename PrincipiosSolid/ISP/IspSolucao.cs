namespace PrincipiosSolid.ISP;


public interface IDispositivoWifi
{
    void ConectarWifi();
}

public interface IDispositivoBluetooth
{
    void ConectarBluetooth();
}

public class CaixaSom : IDispositivoBluetooth
{
    public void ConectarBluetooth();
}

public class TvSmart : IDispositivoWifi
{
    public void ConectarWifi();
}