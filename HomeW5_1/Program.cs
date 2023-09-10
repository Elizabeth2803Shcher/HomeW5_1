// See https://aka.ms/new-console-template for more information
//миллиметры в сантиметры
const float sm = 0.1f;
Console.WriteLine("Введите миллиметры");
double mm = double.Parse(Console.ReadLine());
Console.WriteLine("Тогда получается, что:");
double res = sm * mm;
Console.WriteLine($"{mm} миллиметров это: {res:F2} сантиметров ");

//миллиметры в метры
const float m = 0.001f;
Console.WriteLine("Введите миллиметры");
double mm = double.Parse(Console.ReadLine());
Console.WriteLine("Тогда получается, что:");
double res = m * mm;
Console.WriteLine($"{mm} миллиметров это: {res:F2} метров");
//миллиметры в километры
const float km = 0.000001f;
Console.WriteLine("Введите миллиметры");
double mm = double.Parse(Console.ReadLine());
Console.WriteLine("Тогда получается, что:");
double res = km * mm;
Console.WriteLine($"{mm} миллиметров это: {res:F2} километров");

//миллиметры в мили
Console.WriteLine("Введите миллиметры:");
double mm = double.Parse(Console.ReadLine());
Console.WriteLine("Тогда получается, что:");
double res = mm / 1609344;
Console.WriteLine($"{mm} миллиметров это: {res:F9} миль");

//миллиметры в ярды
const float yard = 0.0011f;
Console.WriteLine("Введите миллиметры:");
double mm = double.Parse(Console.ReadLine());
Console.WriteLine("Тогда получается, что:");
double res = yard * mm;
Console.WriteLine($"{mm} миллиметров это: {res:F4} ярдов");