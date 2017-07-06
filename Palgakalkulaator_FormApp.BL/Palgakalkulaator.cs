namespace Palgakalkulaator_FormApp.BL
{

public class Palgakalkulaator : IPalgakalkulaator
{
    double _bruto;
    bool _maksuvabaTulu;
    bool _töötuskindlustusmakseTööandja;
    bool _töötuskindlustusmakseTöötaja;
    bool _kogumispension;

    public Palgakalkulaator() { }

    public Palgakalkulaator(double Bruto, bool MaksuvabaTulu, bool TöötuskindlustusmakseTööandja, bool TöötuskindlustusmakseTöötaja, bool Kogumispension)
    {
        _bruto = Bruto;
        _maksuvabaTulu = MaksuvabaTulu;
        _töötuskindlustusmakseTööandja = TöötuskindlustusmakseTööandja;
        _töötuskindlustusmakseTöötaja = TöötuskindlustusmakseTöötaja;
        _kogumispension = Kogumispension;
    }

    public double TöötuskindlustusmakseTööandja()
    {
        return _töötuskindlustusmakseTööandja ? _bruto * 0.8 / 100 : 0;
    }

    public double TöötuskindlustusmakseTöötaja()
    {
        return _töötuskindlustusmakseTöötaja ? _bruto * 1.6 / 100 : 0;
    }


    public double Kogumispension()
    {
        return _kogumispension ? _bruto * 2 / 100 : 0;
    }

    public double Tulumaks()
    {
        if (_maksuvabaTulu && _bruto <= 180)
            return 0;
        else
            return ((_bruto - TöötuskindlustusmakseTöötaja() - Kogumispension()) - (_maksuvabaTulu ? 180 : 0)) * 20 / 100;
    }

    public double Netopalk()
    {
        return _bruto - Kogumispension() - TöötuskindlustusmakseTöötaja() - Tulumaks();
    }

    public double Sotsiaalmaks()
    {
        return _bruto * 33 / 100;

    }

    public double KuluKokku()
    {
        return _bruto + Sotsiaalmaks() + TöötuskindlustusmakseTööandja();
    }

    public double Brutopalk()
    {
        return _bruto;
    }
}
}
