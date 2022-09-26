/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10 */

/* System.Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

for( int i = 1; i <= number; i++ ){
    result = result + i;
}
System.Console.Write($"{number} -> {result}"); */

/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number_count = number;
int i = 0;
while (number_count > 0){
        number_count = number_count / 10;
        i++;
    }

System.Console.Write($"{number} -> {i}"); */



/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

/* System.Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for( int i = 1; i <= number; i++ ){
    result = result * i;
}

System.Console.Write($"{number} -> {result}"); */

/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

/* int[] array = new int[8];

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0, 2);
    System.Console.Write($"{array[i]}, ");
}
 */
/* У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
	​Необходимо составить код, который находит их пересечение.
	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».
 */


int[] number = new int[4];

// записываем в массив 2 отрезка
for( int i = 0; i < number.Length; i++ ){
    number[i] = new Random().Next(0, 100);
}

// проверяем на то, чтобы в первой ячейке лежало меньшее значение
if (number[0] > number[1]){
    int temp = number[0];
    number[0] = number[1];
    number[1] = temp;
}
System.Console.Write($"точка 1 ({number[0]}, {number[1]}), ");

if (number[2] > number[3]){
    int temp = number[2];
    number[2] = number[3];
    number[3] = temp;
}
System.Console.WriteLine($"точка 2 ({number[2]}, {number[3]})");

