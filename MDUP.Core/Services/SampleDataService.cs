using MDUP.Core.Contracts.Services;
using MDUP.Core.Models;

namespace MDUP.Core.Services;

// This class holds sample data used by some generated pages to show how they can be used.
// TODO: The following classes have been created to display sample data. Delete these files once your app is using real data.
// 1. Contracts/Services/ISampleDataService.cs
// 2. Services/SampleDataService.cs
// 3. Models/SampleCompany.cs
// 4. Models/SampleOrder.cs
// 5. Models/SampleOrderDetail.cs
public class SampleDataService : ISampleDataService
{
    private List<SampleOrder> _allOrders;

    public SampleDataService()
    {
    }

    private static IEnumerable<SampleOrder> AllOrders()
    {
        // The following is order summary data
        var companies = AllCompanies();
        return companies.SelectMany(c => c.Orders);
    }

    private static IEnumerable<SampleCompany> AllCompanies()
    {
        return new List<SampleCompany>()
        {
            new SampleCompany()
            {
                CompanyID = "ALFKI",
                CompanyName = "Server A",
                ContactName = "Maria Anders",
                Orders = new List<SampleOrder>()
                {
                    new SampleOrder()
                    {
                        OrderDate = new DateTime(1997, 8, 25),
                        ShipperName = "Speedy Express",
                        ShipperPhone = "(503) 555-9831",
                        Freight = 29.46,
                        Company = "Server A",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        Status = "Shipped",
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                        Details = new List<SampleOrderDetail>()
                        {
                            new SampleOrderDetail()
                            {
                                ProductID = 28,
                                ProductName = "Rössle Sauerkraut",
                                Quantity = 15,
                                Discount = 0.25,
                                QuantityPerUnit = "25 - 825 g cans",
                                UnitPrice = 45.60,
                                CategoryName = "Produce",
                                CategoryDescription = "Dried fruit and bean curd",
                                Total = 513.00
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 39,
                                ProductName = "Chartreuse verte",
                                Quantity = 21,
                                Discount = 0.25,
                                QuantityPerUnit = "750 cc per bottle",
                                UnitPrice = 18.0,
                                CategoryName = "Beverages",
                                CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
                                Total = 283.50
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 46,
                                ProductName = "Spegesild",
                                Quantity = 2,
                                Discount = 0.25,
                                QuantityPerUnit = "4 - 450 g glasses",
                                UnitPrice = 12.0,
                                CategoryName = "Seafood",
                                CategoryDescription = "Seaweed and fish",
                                Total = 18.00
                            }
                        }
                    },
                    new SampleOrder()
                    {
                        OrderID = 10952, // Symbol Calendar
                        OrderDate = new DateTime(1998, 3, 16),
                        RequiredDate = new DateTime(1998, 4, 27),
                        ShippedDate = new DateTime(1998, 3, 24),
                        ShipperName = "Speedy Express",
                        ShipperPhone = "(503) 555-9831",
                        Freight = 40.42,
                        Company = "Server B",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 471.20,
                        Status = "Closed",
                        SymbolCode = 57699,
                        SymbolName = "Calendar",
                        Details = new List<SampleOrderDetail>()
                        {
                            new SampleOrderDetail()
                            {
                                ProductID = 6,
                                ProductName = "Grandma's Boysenberry Spread",
                                Quantity = 16,
                                Discount = 0.05,
                                QuantityPerUnit = "12 - 8 oz jars",
                                UnitPrice = 25.0,
                                CategoryName = "Condiments",
                                CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
                                Total = 380.00
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 28,
                                ProductName = "Rössle Sauerkraut",
                                Quantity = 2,
                                Discount = 0,
                                QuantityPerUnit = "25 - 825 g cans",
                                UnitPrice = 45.60,
                                CategoryName = "Produce",
                                CategoryDescription = "Dried fruit and bean curd",
                                Total = 91.20
                            }
                        }
                    }
                }
            },
            new SampleCompany()
            {
                CompanyID = "ANATR",
                CompanyName = "Company F",
                ContactName = "Ana Trujillo",
                ContactTitle = "Owner",
                Address = "Avda. de la Constitución 2222",
                City = "México D.F.",
                PostalCode = "05021",
                Country = "Mexico",
                Phone = "(5) 555-4729",
                Fax = "(5) 555-3745",
                Orders = new List<SampleOrder>()
                {
                    new SampleOrder()
                    {
                        OrderID = 10625, // Symbol Camera
                        OrderDate = new DateTime(1997, 8, 8),
                        RequiredDate = new DateTime(1997, 9, 5),
                        ShippedDate = new DateTime(1997, 8, 14),
                        ShipperName = "Speedy Express",
                        ShipperPhone = "(503) 555-9831",
                        Freight = 43.90,
                        Company = "Server C",
                        ShipTo = "Company F, Avda. de la Constitución 2222, 05021, México D.F., Mexico",
                        OrderTotal = 469.75,
                        Status = "Shipped",
                        SymbolCode = 57620,
                        SymbolName = "Camera",
                        Details = new List<SampleOrderDetail>()
                        {
                            new SampleOrderDetail()
                            {
                                ProductID = 14,
                                ProductName = "Tofu",
                                Quantity = 3,
                                Discount = 0,
                                QuantityPerUnit = "40 - 100 g pkgs.",
                                UnitPrice = 23.25,
                                CategoryName = "Produce",
                                CategoryDescription = "Dried fruit and bean curd",
                                Total = 69.75
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 42,
                                ProductName = "Singaporean Hokkien Fried Mee",
                                Quantity = 5,
                                Discount = 0,
                                QuantityPerUnit = "32 - 1 kg pkgs.",
                                UnitPrice = 14.0,
                                CategoryName = "Grains/Cereals",
                                CategoryDescription = "Breads, crackers, pasta, and cereal",
                                Total = 70.00
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 60,
                                ProductName = "Camembert Pierrot",
                                Quantity = 10,
                                Discount = 0,
                                QuantityPerUnit = "15 - 300 g rounds",
                                UnitPrice = 34.00,
                                CategoryName = "Dairy Products",
                                CategoryDescription = "Cheeses",
                                Total = 340.00
                            }
                        }
                    },
                    new SampleOrder()
                    {
                        OrderID = 10926, // Symbol Clock
                        OrderDate = new DateTime(1998, 3, 4),
                        RequiredDate = new DateTime(1998, 4, 1),
                        ShippedDate = new DateTime(1998, 3, 11),
                        ShipperName = "Federal Shipping",
                        ShipperPhone = "(503) 555-9931",
                        Freight = 39.92,
                        Company = "Server D",
                        ShipTo = "Company F, Avda. de la Constitución 2222, 05021, México D.F., Mexico",
                        OrderTotal = 507.20,
                        Status = "Shipped",
                        SymbolCode = 57633,
                        SymbolName = "Clock",
                        Details = new List<SampleOrderDetail>()
                        {
                            new SampleOrderDetail()
                            {
                                ProductID = 11,
                                ProductName = "Queso Cabrales",
                                Quantity = 2,
                                Discount = 0,
                                QuantityPerUnit = "1 kg pkg.",
                                UnitPrice = 21.0,
                                CategoryName = "Dairy Products",
                                CategoryDescription = "Cheeses",
                                Total = 42.00
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 13,
                                ProductName = "Konbu",
                                Quantity = 10,
                                Discount = 0,
                                QuantityPerUnit = "2 kg box",
                                UnitPrice = 6.0,
                                CategoryName = "Seafood",
                                CategoryDescription = "Seaweed and fish",
                                Total = 60.00
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 19,
                                ProductName = "Teatime Chocolate Biscuits",
                                Quantity = 7,
                                Discount = 0,
                                QuantityPerUnit = "10 boxes x 12 pieces",
                                UnitPrice = 9.20,
                                CategoryName = "Confections",
                                CategoryDescription = "Desserts, candies, and sweet breads",
                                Total = 64.40
                            },
                            new SampleOrderDetail()
                            {
                                ProductID = 72,
                                ProductName = "Mozzarella di Giovanni",
                                Quantity = 10,
                                Discount = 0,
                                QuantityPerUnit = "24 - 200 g pkgs.",
                                UnitPrice = 34.80,
                                CategoryName = "Dairy Products",
                                CategoryDescription = "Cheeses",
                                Total = 340.80
                            }
                        }
                    }
                }
            },
        };
    }

    public async Task<IEnumerable<SampleOrder>> GetContentGridDataAsync()
    {
        _allOrders ??= new List<SampleOrder>(AllOrders());

        await Task.CompletedTask;
        return _allOrders;
    }

    public async Task<IEnumerable<SampleOrder>> GetGridDataAsync()
    {
        _allOrders ??= new List<SampleOrder>(AllOrders());

        await Task.CompletedTask;
        return _allOrders;
    }
}
