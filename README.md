# Итоговая контрольная работа
## **Задача:** 
*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## **Решение:**

+ Запрашиваем у пользователя размер массива (length).

+ В метод **CreateArray** передаём размер, создаём массив строк и заполняем его в цикле **for**.

+ Далее нам потребуется метод **CountElements** в котором мы выясним с помощью цикла *for* и свойства **Length** сколько слов в массиве с количеством символов меньше или равно трём.

+ В методе **PrintNewArr** мы создаём новый массив, перебираем его в цикле *for* и выводим на печать только если попадём в условие(*if*). Особенностью цикла является второй параметр *J*, который будет увеличиваться только в том случае, если отработало условие "if *(arr[i].Length <= 3)*", иначе возможен выход за пределы массива.