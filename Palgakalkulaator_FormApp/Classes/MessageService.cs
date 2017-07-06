using System.Windows.Forms;
using Palgakalkulaator_FormApp.Interfaces;

namespace Palgakalkulaator_FormApp
{

public class MessageService : IMessageService
{
    public void ShowMessage(string message, string caption)
    {
        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowExclamation(string exclamation, string caption)
    {
        MessageBox.Show(exclamation, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    public void ShowError(string error, string caption)
    {
        MessageBox.Show(error, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public void ProgrammInfo(string message, string caption)
    {
        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
}
