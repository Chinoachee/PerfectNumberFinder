Console.Write("Ищем идеальные числа до: ");
int range = int.Parse(Console.ReadLine());
int number = 0;
int[] numbers = new int[range];
int iterator = 0;
for (int i = 1; i < range; i++) {
    for(int j = 1; j < i; j++) {
        if(i % j == 0) {
            numbers[iterator++] = j;
        }
    }
    for(int it = 0; it <= iterator; it++) {
        number += numbers[it];
    }
    if(number == i) {
        Console.WriteLine($"Найдено совершенное число {i} ");
        Console.ReadKey();
    }
    Console.WriteLine(i);
    iterator = 0;
    number = 0;
    numbers = new int[range / 10];
}