using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CowFarm
{

    internal class Program
    {
        class Animal
        {
            public string name;
            public string type;
            public string gender;
            public int maxAge;
            public int age;
            public string foodType;
            public double foodVolume;

            public Animal(string name, string type, string gender, int maxAge, int age, string foodType, double foodVolume)
            {
                this.name = name;
                this.type = type;
                this.gender = gender;
                this.maxAge = maxAge;
                this.age = age;
                this.foodType = foodType;
                this.foodVolume = foodVolume;
            }
        }

        class Product
        {
            public string name;
            public string unit;
            public double price;
            public double dailyAmount;
            public string disease;
            public string skin;
            public double milk;
            public double weight;
            public double fatWeight;
            public double dailyFeces;

            public Product(string name, string unit, double price, double dailyAmount, string disease, string skin, double milk, double weight, double fatWeight, double dailyFeces)
            {
                this.name = name;
                this.unit = unit;
                this.price = price;
                this.dailyAmount = dailyAmount;
                this.disease = disease;
                this.skin = skin;
                this.milk = milk;
                this.weight = weight;
                this.fatWeight = fatWeight;
                this.dailyFeces = dailyFeces;
            }
        }
        class Income
        {
            public double productIncome;
            public double fecesIncome;
            public double meatIncome;
            public double dailyCost;
            public double dailyProfit;
            public double estimatedNetWorth;
            public double profitInNYears;

            public Income(double productIncome, double fecesIncome, double meatIncome, double dailyCost, double dailyProfit, double estimatedNetWorth, double profitInNYears)
            {
                this.productIncome = productIncome;
                this.fecesIncome = fecesIncome;
                this.meatIncome = meatIncome;
                this.dailyCost = dailyCost;
                this.dailyProfit = dailyProfit;
                this.estimatedNetWorth = estimatedNetWorth;
                this.profitInNYears = profitInNYears;
            }
        }
        class CowFarm
        {
            public List<Animal> animals;
            public List<Product> product;
            public Income income;

            public CowFarm()
            {
                animals = new List<Animal>();
                product = new List<Product>();
                income = new Income(0, 0, 0, 0, 0, 0, 0);
            }


            public void AddAnimal(Animal animal)
            {
                animals.Add(animal);
            }

            public void AddProduct(Product product)
            {
                this.products.Add(product);
            }
            public void CalculateIncome(Income income)

            {
                income.productIncome = 0;
                for (int i = 0; i < product.Count; i++)
                {
                    income.productIncome += this.products[i].dailyAmount * this.products[i].price;
                }
                income.fecesIncome = 0;
            }

        }
    }
}

