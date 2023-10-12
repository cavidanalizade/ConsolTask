class Phone
{
    private int _id;
    public int Id 
    {
        get
        {
            return _id;
        }
        set
        {
            if (value>0) 
            {
            _id = value;
            }
        }
    }
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            value = value.Trim();
            if (value.Length > 1)
            {
                _name = value;
            }

        }
    }

    private string _brandname;
    public string BrandName {
        get
        {
            return _brandname;
        }
        set
        {
            value=value.Trim();
            if (value.Length > 2)
            {
            _brandname=value;
            }

        }
    }
    private double _price; 
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value > 0)
            {
                _price = value;
            }
        }
    }
    private int _count;
    public int Count
    {
        get
        {
            return _count;
        }
        set
        {
            if (value > 0)
            {
                _count = value;
            }
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Brand: {BrandName}, Price: {Price}, Count: {Count}");
    }
}
