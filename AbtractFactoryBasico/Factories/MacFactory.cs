public class MacFactory : IThemeFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public IDropDown CreateDropDown()
    {
        return new MacDropDown();
    }

    public ITextBox CreateTextBox()
    {
        return new MacTextBox();
    }
}