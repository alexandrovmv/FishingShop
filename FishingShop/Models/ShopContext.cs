using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DAL.Shop;

namespace FishingShop.Models
{
    public class ShopContext: IContext
    {
        FShopContext context;
        public ShopContext()
        {
            context = new FShopContext();
            AddProduct("Крючок Decoy Kg Hook Worm 17 №4", "Крючки", 
                new Random(0).Next(0, 1000), new Random(0).NextDouble(), "Decoy",new string []
                { "https://i.flagman.kiev.ua/goods/1137/1137055.jpg",
                "https://i.flagman.kiev.ua/goods/1137/1137060.jpg"});
            AddProduct("Крючки Owner Carp Down 51455 №1", "Крючки", new Random(0).Next(0, 1000), new Random(0).NextDouble(),
                "Owner", new string[] {
                "https://i.flagman.kiev.ua/goods/1137/1137055.jpg",
                "https://i.flagman.kiev.ua/goods/1137/1137060.jpg"});
            AddProduct("Спиннинговое удилище Flagman Blackfire 1.83м 0.5-6г", "Спиннинговые удилища",
              new Random(0).Next(0, 1000), new Random(0).NextDouble(),
              "Flagman", new string[]
              { "https://i.flagman.kiev.ua/goods/1284/1284779.jpg",
                "https://i.flagman.kiev.ua/goods/1284/1284764.jpg",
              "https://i.flagman.kiev.ua/goods/1284/1284769.jpg"});
            AddProduct("Спиннинговое удилище Shimano Sustain SSUS19515 1.90м 5-15г", "Спиннинговые удилища",
           new Random(0).Next(0, 1000), new Random(0).NextDouble(),
           "Shimano", new string[]
           { "https://i.flagman.kiev.ua/goods/1303/1303319.jpg",
                "https://i.flagman.kiev.ua/goods/1303/1303324.jpg",
              "https://i.flagman.kiev.ua/goods/1303/1303329.jpg"});
            AddProduct("Виброхвост Flagman Sakana 2.25'' #11 Cola", "Виброхвост",
          new Random(0).Next(0, 1000), new Random(0).NextDouble(),
          "Flagman", new string[]
          { "https://i.flagman.kiev.ua/goods/1310/1310554.jpg" });
            AddProduct("Твистер Bait Breath Micro Grub 2 Ur27", "Твистеры",
 new Random(0).Next(0, 1000), new Random(0).NextDouble(),
 "Bait Breath", new string[]
 { "https://i.flagman.kiev.ua/goods/1084/1084352.jpg" });

        }
        void AddProduct(string ProductName, string Category,int Quant, double Price, string newProducer,string[] Photos)
        {
            if (context.Products.Find(x => { return x.Name == ProductName; }) == null)
            {
                if (context.Categories.Find(x => { return x.Name == Category; }) == null)
                {
                    context.Categories.Add(new Category { Name = Category });
                    context.SaveChanges();
                }
                if (context.Producers.Find(x => { return x.Name == Category; }) == null)
                {
                    context.Producers.Add(new Producer { Name = newProducer });
                    context.SaveChanges();
                }
                context.Products.Add(new Product
                {
                    Name = ProductName,
                    ProducerId = context.Producers.FirstOrDefault(x => { return x.Name == "Decoy"; }).PoducerId,
                    CategoryId = context.Categories.FirstOrDefault(x => { return x.Name == "Крючки"; }).CategoryId,
                    Quantity = new Random(0).Next(0, 1000),
                    Price = new Random(0).NextDouble(),
                    Photos = new List<Photo>()
                });
                context.SaveChanges();
                foreach(string item in Photos)
                {
                    context.Photos.Add(new Photo
                    {
                        Path = item,
                        ProductId = context.Products.FirstOrDefault(z => { return z.Name == ProductName; }).PoductId
                    });
                }
                context.SaveChanges();
            }
        }
public IEnumerable<Category> GetCategories()
        {
            return context.Categories;
        }

        public IEnumerable<Product> GetGoods()
        {
            return context.Products;    
        }
    }
}