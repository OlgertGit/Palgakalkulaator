using System;
using Palgakalkulaator_FormApp.BL;
using Palgakalkulaator_FormApp.Interfaces;

namespace Palgakalkulaator_FormApp
{
public class MainPresenter
{
    private readonly IMainForm _view;
    private readonly IMessageService _service;
    private readonly IPalgakalkulaator _kalkulaator;


    public MainPresenter(IMainForm View, IMessageService Service, IPalgakalkulaator Kalkulaator)
    {
        _view = View;
        _service = Service;
        _kalkulaator = Kalkulaator;

        _view.OpenProgrammInfo += _view_OpenProgrammInfo;
        _view.BrutopalkEvent += _view_BrutopalkEvent;
        _view.KogumispensionEvent += _view_KogumispensionEvent;
        _view.MaksuvabatuluEvent += _view_MaksuvabatuluEvent;
        _view.Töötuskindlustusmakse_TööandjaEvent += _view_Töötuskindlustusmakse_TööandjaEvent;
        _view.Töötuskindlustusmakse_TöötajaEvent += _view_Töötuskindlustusmakse_TöötajaEvent;
    }


    private void  _view_Töötuskindlustusmakse_TöötajaEvent(object sender, EventArgs e)
    {
        Arvutamine();
    }

    private void _view_Töötuskindlustusmakse_TööandjaEvent(object sender, EventArgs e)
    {
        Arvutamine();
    }

    private void _view_MaksuvabatuluEvent(object sender, EventArgs e)
    {
        Arvutamine();
    }

    private void _view_KogumispensionEvent(object sender, EventArgs e)
    {
        Arvutamine();
    }

    private void _view_BrutopalkEvent(object sender, EventArgs e)
    {
        Arvutamine();
    }

    private void Arvutamine()
    {

        double Bruto = Convert.ToDouble(_view.Bruto);

        IPalgakalkulaator palgakalkulaator = new Palgakalkulaator(Bruto, _view.MaksuvabatuluChecked(), _view.TöötuskindlustusmakseTööandjaChecked(), _view.TöötuskindlustusmakseTöötajaChecked(), _view.KogusmispensionChecked());

        _view.Brutopalk = palgakalkulaator.Brutopalk().ToString();
        _view.Töötuskindlustusmakse_Tööandja = palgakalkulaator.TöötuskindlustusmakseTööandja().ToString();
        _view.Töötuskindlustusmakse_Töötaja = palgakalkulaator.TöötuskindlustusmakseTöötaja().ToString();
        _view.Kogumispension = palgakalkulaator.Kogumispension().ToString();
        _view.Tulumaks = palgakalkulaator.Tulumaks().ToString();
        _view.Netopalk = palgakalkulaator.Netopalk().ToString();
        _view.Sotsiaalmaks = palgakalkulaator.Sotsiaalmaks().ToString();
        _view.KuluKokku = palgakalkulaator.KuluKokku().ToString();
    }
    private void _view_OpenProgrammInfo(object sender, EventArgs e)
    {
        _service.ProgrammInfo("Palgakalkulaator 2017", "Info");
    }
}
}
