using System;

namespace Palgakalkulaator_FormApp.Interfaces
{
public interface IMainForm
{
    event EventHandler OpenProgrammInfo;
    event EventHandler KogumispensionEvent;
    event EventHandler MaksuvabatuluEvent;
    event EventHandler Töötuskindlustusmakse_TöötajaEvent;
    event EventHandler Töötuskindlustusmakse_TööandjaEvent;
    event EventHandler BrutopalkEvent;

    string Bruto
    {
        get;
        set;
    }
    bool MaksuvabatuluChecked();
    bool TöötuskindlustusmakseTööandjaChecked();
    bool TöötuskindlustusmakseTöötajaChecked();
    bool KogusmispensionChecked();
    string Brutopalk
    {
        get;
        set;
    }
    string Kogumispension
    {
        get;
        set;
    }
    string Töötuskindlustusmakse_Töötaja
    {
        get;
        set;
    }
    string Töötuskindlustusmakse_Tööandja
    {
        get;
        set;
    }
    string Tulumaks
    {
        get;
        set;
    }
    string Netopalk
    {
        get;
        set;
    }
    string Sotsiaalmaks
    {
        get;
        set;
    }
    string KuluKokku
    {
        get;
        set;
    }

}
}
