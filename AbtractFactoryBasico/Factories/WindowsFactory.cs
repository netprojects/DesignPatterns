public class WindowsFactory : IThemeFactory
{
   public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IDropDown CreateDropDown()
    {
        return new WindowsDropDown();
    }

    public ITextBox CreateTextBox()
    {
        return new WindowsTextBox();
    }
}