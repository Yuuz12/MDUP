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
                Orders = new List<SampleOrder>()
                {
                    new SampleOrder()
                    {
                        OrderDate = new DateTime(1997, 8, 30),
                        Company = "Server A",
                        Status = "Shipped",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                    },
                    new SampleOrder()
                    {
                        OrderDate = new DateTime(1997, 8, 30),
                        Company = "Server B",
                        Status = "Shipped",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                    },
                }
            },
            new SampleCompany()
            {
                Orders = new List<SampleOrder>()
                {
                    new SampleOrder()
                    {
                        OrderDate = new DateTime(1997, 8, 30),
                        Company = "Server B",
                        Status = "Shipped",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                    },
                    new SampleOrder()
                    {
                        OrderDate = new DateTime(1997, 8, 30),
                        Company = "Server B",
                        Status = "Shipped",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                    },
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
