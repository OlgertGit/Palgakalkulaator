using System;
using System.Windows.Forms;
using Palgakalkulaator_FormApp.Interfaces;


namespace Palgakalkulaator_FormApp
{

public partial class MainForm : Form, IMainForm
{

    public MainForm()
    {
        InitializeComponent();
        tb_Brutopalk.TextChanged += Tb_Brutopalk_TextChanged;
        cb_MaksuvabaTulu.CheckedChanged += Cb_MaksuvabaTulu_CheckedChanged;
        cb_Töötuskindlustusmakse_Tööandja.CheckedChanged += Cb_Töötuskindlustusmakse_Tööandja_CheckedChanged;
        cb_Töötuskindlustusmakse_Töötaja.CheckedChanged += Cb_Töötuskindlustusmakse_Töötaja_CheckedChanged;
        cb_Kogusmispension.CheckedChanged += Cb_Kogusmispension_CheckedChanged;
        väljuToolStripMenuItem.Click += VäljuToolStripMenuItem_Click;
        programmToolStripMenuItem.Click += ProgrammToolStripMenuItem_Click;
    }

    public string Bruto
    {
        get
        {
            return tb_Brutopalk.Text;
        }
        set
        {
            tb_Brutopalk.Text = value;
        }
    }

    private void ProgrammToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (OpenProgrammInfo != null) OpenProgrammInfo(this, EventArgs.Empty);
    }

    private void VäljuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void Cb_Kogusmispension_CheckedChanged(object sender, EventArgs e)
    {
        if (KogumispensionEvent != null) KogumispensionEvent(this, EventArgs.Empty);
    }
    private void Cb_MaksuvabaTulu_CheckedChanged(object sender, EventArgs e)
    {
        if (MaksuvabatuluEvent != null) MaksuvabatuluEvent(this, EventArgs.Empty);
    }
    private void Cb_Töötuskindlustusmakse_Töötaja_CheckedChanged(object sender, EventArgs e)
    {
        if (Töötuskindlustusmakse_TöötajaEvent != null) Töötuskindlustusmakse_TöötajaEvent(this, EventArgs.Empty);
    }
    private void Cb_Töötuskindlustusmakse_Tööandja_CheckedChanged(object sender, EventArgs e)
    {
        if (Töötuskindlustusmakse_TööandjaEvent != null) Töötuskindlustusmakse_TööandjaEvent(this, EventArgs.Empty);
    }
    private void Tb_Brutopalk_TextChanged(object sender, EventArgs e)
    {
        if (BrutopalkEvent != null) BrutopalkEvent(this, EventArgs.Empty);
    }
    public bool MaksuvabatuluChecked()
    {
        return cb_MaksuvabaTulu.Checked;
    }
    public bool TöötuskindlustusmakseTööandjaChecked()
    {
        return cb_Töötuskindlustusmakse_Tööandja.Checked;
    }
    public bool TöötuskindlustusmakseTöötajaChecked()
    {
        return cb_Töötuskindlustusmakse_Töötaja.Checked;
    }
    public bool KogusmispensionChecked()
    {
        return cb_Kogusmispension.Checked;
    }
    public string Brutopalk
    {
        get
        {
            return lbl_Brutopalk_2Arv.Text;
        }
        set
        {
            lbl_Brutopalk_2Arv.Text = value;
        }
    }
    public string Kogumispension
    {
        get
        {
            return lbl_KogusmispensionArv.Text;
        }
        set
        {
            lbl_KogusmispensionArv.Text = value;
        }
    }
    public string Töötuskindlustusmakse_Töötaja
    {
        get
        {
            return lbl_Töötuskindlustusmakse_TöötajaArv.Text;
        }
        set
        {
            lbl_Töötuskindlustusmakse_TöötajaArv.Text = value;
        }
    }
    public string Töötuskindlustusmakse_Tööandja
    {
        get
        {
            return lbl_Töötuskindlustusmakse_TööandjaArv.Text;
        }
        set
        {
            lbl_Töötuskindlustusmakse_TööandjaArv.Text = value;
        }
    }
    public string Tulumaks
    {
        get
        {
            return lbl_TulumaksArv.Text;
        }
        set
        {
            lbl_TulumaksArv.Text = value;
        }
    }
    public string Netopalk
    {
        get
        {
            return lbl_NetopalkArv.Text;
        }
        set
        {
            lbl_NetopalkArv.Text = value;
        }
    }
    public string Sotsiaalmaks
    {
        get
        {
            return lbl_SotsiaalmaksArv.Text;
        }
        set
        {
            lbl_SotsiaalmaksArv.Text = value;
        }
    }
    public string KuluKokku
    {
        get
        {
            return lbl_KuluKokkuArv.Text;
        }
        set
        {
            lbl_KuluKokkuArv.Text = value;
        }
    }


    public event EventHandler OpenProgrammInfo;
    public event EventHandler KogumispensionEvent;
    public event EventHandler MaksuvabatuluEvent;
    public event EventHandler Töötuskindlustusmakse_TöötajaEvent;
    public event EventHandler Töötuskindlustusmakse_TööandjaEvent;
    public event EventHandler BrutopalkEvent;
}
}
