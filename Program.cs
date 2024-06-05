Console.Write("Ищем идеальные числа до: ");
long range = long.Parse(Console.ReadLine());
int number = 0;
List<int> numbers = new List<int>();
int iterator = 0;
for (int i = 1; i < range; i++) {
    for(int j = 1; j < i; j++) {
        if(i % j == 0) {
            numbers.Add(j);
        }
    }
    foreach(int j in numbers) {
        number += j;
    }
    if(number == i) {
        Console.WriteLine($"Найдено совершенное число {i} ");
        Console.ReadKey();
    }
    Console.WriteLine(i);
    number = 0;
    numbers.Clear();
}