// See https://aka.ms/new-console-template for more information
using CSharpSecond;
using System.Reflection;

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

static void GMethod<T>(T value)
{
    switch (value)
    {
        case int a:
            {
                int res = 1;
                for (int i = 1; i <= a; i++)
                {
                    res = res * i;
                }
                Console.WriteLine(res);
            }

            break;
        case string s:
            Console.WriteLine(s.Length);
            break;
            default:
            Console.WriteLine(value.GetType());
            break;
    }

}


Console.WriteLine("Main start");

User user = new User("Ivan", 22);
//Type type = Type.GetType("CSharpSecond.User");
//Console.WriteLine(type.Name);
//Type type = user.GetType();
Type type = typeof(User);
var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance); 
foreach (FieldInfo field in fields)
{
    if(field.Name == "_name")
    {
        field.SetValue(user, "Boris");
    }
}
Console.WriteLine(user.Name);

Console.WriteLine("Main end");




