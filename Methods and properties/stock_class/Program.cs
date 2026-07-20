using System;

class Stock
{
    string stockName;
    string stockSymbol;
    double previousClosingPrice;
    double currentClosingPrice;

    public Stock(string name, string symbol, double previous, double current)
    {
        stockName = name;
        stockSymbol = symbol;
        previousClosingPrice = previous;
        currentClosingPrice = current;
    }

    public double GetChangePercentage()
    {
        return ((currentClosingPrice - previousClosingPrice) / previousClosingPrice) * 100;
    }

    static void Main()
    {
        Console.Write("Enter Stock Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Stock Symbol: ");
        string symbol = Console.ReadLine();

        Console.Write("Enter Previous Closing Price: ");
        double previous = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Current Closing Price: ");
        double current = Convert.ToDouble(Console.ReadLine());

        Stock stock = new Stock(name, symbol, previous, current);

        Console.WriteLine("\nStock Name : " + name);
        Console.WriteLine("Stock Symbol : " + symbol);
        Console.WriteLine("Percentage Change : " + stock.GetChangePercentage() + "%");
    }
}
