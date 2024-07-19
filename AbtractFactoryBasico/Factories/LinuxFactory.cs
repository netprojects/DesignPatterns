public class LinuxFactory : IThemeFactory
{
    public IButton CreateButton()
    {
        return new LinuxButton();
    }

    public IDropDown CreateDropDown()
    {
        return new LinuxDropDown();
    }

    public ITextBox CreateTextBox()
    {
        return new LinuxTextBox();
    }
}