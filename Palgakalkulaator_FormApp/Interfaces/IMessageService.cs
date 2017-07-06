namespace Palgakalkulaator_FormApp.Interfaces
{
public interface IMessageService
{
    void ShowMessage(string message, string caption);
    void ShowExclamation(string exclamation, string caption);
    void ShowError(string error, string caption);
    void ProgrammInfo(string message, string caption);
}
}
