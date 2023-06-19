// See https://aka.ms/new-console-template for more information
using CSharpSecond;

static async Task WorkAsync()
{
    await Task.Run(() => {
        Console.WriteLine("Task Started");
        Thread.Sleep(5000);
        //имитация выполнения кода
        Console.WriteLine("Some resuilt");
        Console.WriteLine("Task Ended");
    }) ;
}
//  2 3 6   
//  2 6 9   
//  4 9 15  


List<int> list = new List<int>();
static async Task Work2Async()
{
    await Task.Run(() => {
        Console.WriteLine("Work2Async Started");
        Thread.Sleep(5000);
        //имитация выполнения кода
        Console.WriteLine("Some resuilt2");
        Console.WriteLine("Work2Async Ended");
    });
}

static void Work()
{
    Console.WriteLine("Work2Async Started");
    Thread.Sleep(5000);
    //имитация выполнения кода
    Console.WriteLine("Some resuilt2");
    Console.WriteLine("Work2Async Ended");
}


Console.WriteLine("Main start");
GenericClass<string> gClass = new GenericClass<string>();
gClass.GenegicField = "ddd";
Console.WriteLine(gClass.GenegicField.GetType().Name);

Console.WriteLine("Main end");




