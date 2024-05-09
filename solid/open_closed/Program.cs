
public enum Colors
{
    Red,
    Green,
    Blue
}

public enum Sizes
{
    Small,
    Medium,
    Large
}

public class Product
{
    public string Name;
    public Colors Color;
    public Sizes Size;

    public Product(string name, Colors color, Sizes size)
    {
        Name = name;
        Color = color;
        Size = size;
    }
}

public class ProductFilter
{
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Colors color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Sizes size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Sizes size, Colors color)
    {
        foreach (var product in products)
        {
            if (product.Size == size && product.Color == color)
            {
                yield return product;
            }
        }
    }
}
// The above code is a simple implementation of the Open-Closed Principle.
// The ProductFilter class is open for extension but closed for modification.
// If we want to add a new filter,
// we can create a new class that implements the IFilter interface
// and pass it to the Filter method of the ProductFilter class.

public interface ISpecification<T>
{
    bool IsSatisfied(T item);
}
public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}

public class ColorSpecification : ISpecification<Product>
{
    private readonly Colors _color;

    public ColorSpecification(Colors color)
    {
        _color = color;
    }

    public bool IsSatisfied(Product item)
    {
        return item.Color == _color;
    }
}

public class SizeSpecification : ISpecification<Product>
{
    private readonly Sizes _size;

    public SizeSpecification(Sizes size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product item)
    {
        return item.Size == _size;
    }
}

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }

    public bool IsSatisfied(T item)
    {
        return _first.IsSatisfied(item) && _second.IsSatisfied(item);
    }
}

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
            {
                yield return item;
            }
        }
    }
}


// the above code is an implementation of the Open-Closed Principle using the Specification Pattern   .

class Program
{
    static void Main(string[] args)
    {
        var apple = new Product("Apple", Colors.Green, Sizes.Small);
        var tree = new Product("Tree", Colors.Green, Sizes.Large);
        var house = new Product("House", Colors.Blue, Sizes.Large);

        Product[] products = { apple, tree, house };

        var pf = new ProductFilter();
        Console.WriteLine("Green products (old):");
        foreach (var p in pf.FilterByColor(products, Colors.Green))
        {
            Console.WriteLine($" - {p.Name} is green");
        }

        // ^^ BEFORE

        // vv AFTER
        var bf = new BetterFilter();
        Console.WriteLine("Green products (new):");
        foreach (var p in bf.Filter(products, new ColorSpecification(Colors.Green)))
        {
            Console.WriteLine($" - {p.Name} is green");
        }

        Console.WriteLine("Large products");
        foreach (var p in bf.Filter(products, new SizeSpecification(Sizes.Large)))
        {
            Console.WriteLine($" - {p.Name} is large");
        }

        Console.WriteLine("Large blue items");
        foreach (var p in bf.Filter(products,
                     new AndSpecification<Product>(new ColorSpecification(Colors.Blue),
                         new SizeSpecification(Sizes.Large))))
        {
            Console.WriteLine($" - {p.Name} is large and blue");
        }
    }
}
      