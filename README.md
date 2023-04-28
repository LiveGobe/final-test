# Описание программы
Данная программа принимает на вход массив строк, разделенных запятой, и создает новый массив, содержащий только те строки, длина которых меньше или равна 3 символам.

Программа использует цикл **foreach** для прохода по каждой строке в исходном массиве. Если длина строки меньше или равна 3 символам, она добавляется в новый массив с помощью метода **Array.Resize**.

Новый массив строк выводится на экран с помощью метода **Console.WriteLine**.

# Инструкции по использованию
* Запустите программу в среде разработки, например, в Visual Studio.
* Введите исходный массив строк через запятую в консольное окно.
* Нажмите клавишу Enter.
* Программа выведет новый массив строк, содержащий только те строки, длина которых меньше или равна 3 символам.

Пример ввода: **hello, world, abc, def, ghi**

Пример вывода: **abc,def,ghi**