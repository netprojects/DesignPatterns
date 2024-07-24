// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IClothesFactory clothesFactory =  new GalaClothesFactory();

IShirt sportShirt = clothesFactory.CreateShirt();
sportShirt.DesignShirt();
sportShirt.SizeShirt();
sportShirt.TypeClothes();


