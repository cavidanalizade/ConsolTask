class Program
{
    static void Main()
    {
        Store myStore = new Store { Name = "My Store" };

        Phone phone1 = new Phone { Id = 1, Name = "13 pro", BrandName = "Iphone", Price = 1599.99, Count = 10 };
        Phone phone2 = new Phone { Id = 2, Name = "13 pro max", BrandName = "Iphone", Price = 1799.99, Count = 5 };

        myStore.AddPhone(phone1);
        myStore.AddPhone(phone2);

        myStore.ShowAllPhones();
        Console.WriteLine("");
        double minPrice = 1000.00;
        double maxPrice = 2000.00;
        myStore.ShowPhonesForPrice(minPrice, maxPrice);
        myStore.RemovePhone(2);
        Console.WriteLine();
        myStore.ShowAllPhones();


    }
}