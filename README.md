Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Описание алгоритма решения:
Задаем 3 массива строк с примерами из условия задачи. Создаем переменную хранящую в себе максимальную длину элемента массива. Создаем новый массив такой же длины, как и массив из условия. Записываем в него элементы из первого массива, длина которых меньше, либо равна 3 символам. Изменяем размер нового массива согласно количеству находящихся в нем элементов. В случае, если количество элементов массива = 0, то печатаем что массив пустой, иначе печатаем новый массив.

Графическое представление метода в папке Scheme.jpg.

Реализация алгоритма Program.cs
