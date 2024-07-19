// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IThemeFactory themeFactory = new  WindowsFactory();
IButton  button = themeFactory.CreateButton();
button.render();