# NamesHistogram
Program for practicing arrays

В классе HistogramTask код подготовки данных для гистограммы частоты рождаемости в зависимости от числа (номера дня в месяце) рождения для заданного имени.

D базе данных для всех людей с неизвестной датой рождения, в качестве даты рождения используется первое число месяца. Во время работы с реальными базами данных, часто всплывают подобные особенности.

Не учитываются те, кто родился 1 числа любого месяца.

В качестве подписей (label) по оси X используйте массив размером 31 элемент со значениями от 1 до 31.

В классе HeatmapTask код подготовки данных для тепловой карты рождаемости в зависимости от дня и месяца.

По оси X — число месяца, по Y — номер месяца, а интенсивность точки (она отображается цветом и размером) обозначает количество рожденных людей в это число этого месяца. Аналогично предыдущей задаче, не учитывайте людей, родившихся первого числа любого месяца.

В качестве подписей (label) по X - массив возможных чисел месяца, кроме первого: от 2 до 31. В качестве подписей по Y - массив номеров месяцев от 1 (январь), до 12 (декабрь).

Таким образом, данные для карты интенсивностей в виде двумерного массива 30 на 12 — от 2 до 31 числа и от января до декабря.
