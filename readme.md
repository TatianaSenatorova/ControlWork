# Цель проекта
## Целью проекта является решение следующей задачи:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении обходимся исключительно массивами*
***
## Решение поставленной задачи:
1. Пользователь с клавиатуры вводит строку символов, разделенных пробелом.
2. Строка символов преобразуется в массив строк. При разбиении строки на элементы массива, разделителем является пробел . 
3. В методе **CountLengthNewMass** определяется длина нового массива, который будет состоять из строк, длина которых меньше, либо равна 3 символа. С этой целью перебирается каждый элемент первоначального массива и подсчитывается, сколько элементов массива длиной 3 символа или меньше. Длина присваивается переменной count.
4. В метод **FillNewArray** передается первоначальный массив и подсчитанная длина нового массива. В теле метода задается новый массив длиной count. Далее в цикле перебирается каждый элемент первоначального массива, если элемент состоит из 3-х символов или меньше, то данный элемент помещаем в новый массив.
5. Последний шаг - печать нового массива. С этой целью использовали метод **PrintArray**. В метод передается сформированный с помощью метода FillNewArray массив. 



