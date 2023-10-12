using System;

class Store
{
    private Phone[] Phones = new Phone[10];
    private int phoneCount = 0;

    public string Name { get; set; }

    public void AddPhone(Phone phone)
    {
        if (phoneCount == Phones.Length)
        {
            Phone[] largerArray = new Phone[Phones.Length * 2];
            Array.Copy(Phones, largerArray, Phones.Length);
            Phones = largerArray;
        }
        Phones[phoneCount] = phone;
        phoneCount++;
    }

    public void ShowAllPhones()
    {
        Console.WriteLine($"Phones in {Name} Store:");
        for (int i = 0; i < phoneCount; i++)
        {
            Phones[i].ShowInfo();
        }
    }

    public void ShowPhonesForPrice(double minPrice, double maxPrice)
    {
        Console.WriteLine($"Phones in {Name} Store within price range {minPrice} - {maxPrice}:");
        for (int i = 0; i < phoneCount; i++)
        {
            if (Phones[i].Price >= minPrice && Phones[i].Price <= maxPrice)
            {
                Phones[i].ShowInfo();
            }
        }
    }

    public void RemovePhone(int id)
    {
        for (int i = 0; i < phoneCount; i++)
        {
            if (Phones[i].Id == id)
            {
                for (int j = i; j < phoneCount - 1; j++)
                {
                    Phones[j] = Phones[j + 1];
                }
                phoneCount--;
                Console.WriteLine($"Phone with ID {id} has been removed from {Name} Store.");
                return;
            }
        }
        Console.WriteLine($"Phone with ID {id} was not found in {Name} Store.");
    }
}


