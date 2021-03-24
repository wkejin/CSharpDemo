using System;
using System.Collections.Generic;

namespace Demo19_委托使用
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = productFactory.MakePizza;
            Func<Product> func2 = productFactory.MakeToyCar;

            Box box1 = wrapFactory.WrapProduct(func1);
            Box box2 = wrapFactory.WrapProduct(func2);

            Console.WriteLine(box1.Product.ProductName);
            Console.WriteLine(box2.Product.ProductName);
        }
    }

    class Product
    {
        public string ProductName { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();
            box.Product = getProduct.Invoke();
            return box;
        }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.ProductName = "Pizza";
            return product;
        }

        public Product MakeToyCar()
        {
            Product product = new Product();
            product.ProductName = "Toy Car";
            return product;
        }
    }

}
