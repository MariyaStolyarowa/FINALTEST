# Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Описание общего алгоритма:
Программа разбита на блоки - методы.
1. Метод заполнения массива FillArray;
2. Метод Count
подсчета количества
элементов массива с длинной <=3 символа;
3. Метод заполнения
 нового массива элементами длинной <=3 символа из исходного массива;
4. Метод печати массива на экран.

Сначала запрашиваем у пользователя число элементов массива. Инициализируем исходный массив array1 с таким размером. Затем считываем элементы массива, которые пользователь вводит с клавиатуры и заполняем исходный массив с помощью метода FillArray.
С помощью метода Count узнаем сколько в исходном массиве элементов с длинной <=3 символа.
Затем инициализируем новый массив размером равным количеству элементов исходного массива с длинной <=3 символа, определенному с помощью метода Count. 
Заполняем новый массив с помощью метода StayWithout.
Выводим на экран массивы: исходный и полученный массив с помощью метода PrintArray.
### Описание алгоритма метода заполнения нового массива array2 элементами длинной <=3 из исходного массива array1 "StayWithout"

В качестве аргументов данному методу передаются массивы array1 и array2. Запускаем цикл длинной, равной длине исходного массива array1. Внутри цикла проверяем условие (<=3). Если условие выполняется, то текущий элемент исходного массива заносим во второй массив. Счетчик элементов с длинной <= 3 символам - Count увеличиваем на 1, счетчик элементов исходного массива увеличиваем на 1. Если условие не выполняется, то просто увеличиваем счетчик элементов исходного массива на 1. Так проверяем все элементы исходного массива и отвечающие условию заносим во второй массив.    