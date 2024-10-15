// See https://aka.ms/new-console-template for more information
using TestTechnique;

Product banane = new Product(1.50m, "Banane", "Fruit");
Product pomme = new Product(1.50m, "pomme", "Fruit");
Product oignon = new Product(1.50m, "oignon", "Légume");

Panier panier = new Panier();

panier.AddProduct(banane);
panier.AddProduct(banane);
panier.AddProduct(pomme);
panier.AddProduct(pomme);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);
panier.AddProduct(oignon);

panier.AddDiscount(new BuyOneGetOneFree("Fruit"));
panier.AddDiscount(new LotDiscountable("Légume", 10, 1.00m));


Console.WriteLine($"Total sans réduction : {panier.totalPanierWithoutDiscount()}");
Console.WriteLine($"Total sans réduction : {panier.totalPanierWithDiscount()}");
