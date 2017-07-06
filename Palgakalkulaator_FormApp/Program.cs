using System;
using System.Windows.Forms;
using Palgakalkulaator_FormApp.BL;

namespace Palgakalkulaator_FormApp
{
static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Palgakalkulaator kalkulaator = new Palgakalkulaator();
        MessageService service = new MessageService();
        MainForm form = new MainForm();

        MainPresenter presenter = new MainPresenter(form, service, kalkulaator);

        Application.Run(form);
    }
}
}
