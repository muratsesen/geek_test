// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main(string[] args)
    {
        Assessment ass = new Assessment();
        var rez = ass.Deneme();
        Console.WriteLine($"Deneme: {rez}");

        // //Merge
        // IEnumerable<int> b = new int[]{4,5,6};
        // IEnumerable<int> a = new int[]{1,2,3};

        // var res = ass.Merge(a,null);

        // Console.WriteLine($"Result: {res}");
        // foreach (var item in res)
        // {
        //     Console.WriteLine($"{item}");
        // }

        //----------------------------------------------------

        // //WithMax score
        // Score a = new Score();
        // Score b = new Score();
        // Score c = new Score();
        // a.Value = 1;
        // b.Value = int.MinValue;
        // c.Value = int.MaxValue;

        // var res = ass.WithMax(null);
        // Console.WriteLine($"{res?.Value}");

        //----------------------------------------------------
        // //GetAverageOrDefault
        // var res1 = ass.GetAverageOrDefault(new int[]{1,5,9,4,11,6});
        // Console.WriteLine($"{res1}");

        //----------------------------------------------------

        // //WithSuffix
        // var res = ass.WithSuffix(null,"second");
        // Console.WriteLine($"{res}");

        //----------------------------------------------------

        // //GetAllScoresFrom
        // IDataProvider<Score> source = new IDataProvider<Score>();

        // var res = ass.GetAllScoresFrom(null,"second");
        // Console.WriteLine($"{res}");


        //----------------------------------------------------

        // //GetFullName
        // IHierarchy aa = new Hierarchy("Rahime",null);
        // IHierarchy a = new Hierarchy("Elif",aa);
        // IHierarchy c = new Hierarchy("Murat",a);


        // var res = ass.GetFullName(a,null);
        // Console.WriteLine($"{res}");

        //----------------------------------------------------

        // //ClosestToAverageOrDefault        

        // var res = ass.ClosestToAverageOrDefault(new int[]{1,5,9,4,11,6});
        // Console.WriteLine($"{res}");

        //----------------------------------------------------

        // Group

        Booking[] p = {
             new Booking {Project="HR",   Date = Convert.ToDateTime("01/02/2020") , Allocation= 10},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("01/02/2020") , Allocation= 15},
             new Booking {Project="HR",   Date = Convert.ToDateTime("02/02/2020") , Allocation= 10},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("02/02/2020") , Allocation= 15},
             new Booking {Project="HR",   Date = Convert.ToDateTime("03/02/2020") , Allocation= 15},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("03/02/2020") , Allocation= 15},
             new Booking {Project="HR",   Date = Convert.ToDateTime("04/02/2020") , Allocation= 15},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("04/02/2020") , Allocation= 15},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("05/02/2020") , Allocation= 15},
             new Booking {Project="HR",   Date = Convert.ToDateTime("05/02/2020") , Allocation= 15},
             new Booking {Project="ECom", Date = Convert.ToDateTime("05/02/2020") , Allocation= 15},
             new Booking {Project="ECom", Date = Convert.ToDateTime("06/02/2020") , Allocation= 10},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("06/02/2020") , Allocation= 15},
             new Booking {Project="ECom", Date = Convert.ToDateTime("07/02/2020") , Allocation= 10},
             new Booking {Project="CRM",  Date = Convert.ToDateTime("07/02/2020") , Allocation= 15}
        };

        var res = ass.Group(p);

        foreach (var item in res)
        {
            System.Console.WriteLine("");
            System.Console.Write("From:" + item.From.ToShortDateString() + " - ");
            System.Console.Write("To:" + item.To.ToShortDateString());
            foreach (var i in item.Items)
            {
                System.Console.Write($" {{ Project: {i.Project}, Allocation:{i.Allocation} }}");
            }
        }
        System.Console.WriteLine();

        
        //----------------------------------------------------

        // GetAllScoresFrom
        IDataProvider<Score> dp = new DataProvider();

        ass.GetAllScoresFrom(dp);
    }
}

public class DataProvider : IDataProvider<Score>
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IDataProvider<Score>.IDataProviderResponse GetData(string nextPageToken)
    {
        throw new NotImplementedException();
    }
}
public class TempBook
{

}

public class Hierarchy : IHierarchy
{
    public Hierarchy(string name, IHierarchy parent)
    {
        this.Parent = parent;
        this.Name = name;
    }
    public IHierarchy Parent { get; }

    public string Name { get; }
}