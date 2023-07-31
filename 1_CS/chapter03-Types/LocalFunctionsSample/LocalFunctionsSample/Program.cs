// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void IntroLocalFunctions()
{
    static int Add(int x, int y) => x + y;

    int result = Add(3, 7);
    Console.WriteLine($"called the local function with this result: {result}");

}
IntroLocalFunctions();

static void LocalFunctionWithClosure()
{
    int z = 3;


    int Add(int x, int y) => x + y + z;

    int result = Add(3, 7);
    Console.WriteLine($"called the local function with this result: {result}");
}
LocalFunctionWithClosure();