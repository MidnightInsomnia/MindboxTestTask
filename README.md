# Mindbox тестовое задание (SECOND TRY)

```Kotlin
Задача №1 на создание библиотеки находится в папке FiguresTask
```
```Kotlin
Задача №2 на создание SQL запроса находится в папке SQLTask
```

## Figures

Задача реализована при помощи интерфейсов, в этот раз ничего лишнего.

### Пример работы
```c#
//Вычисление площади
var circleArea = FigureInfo.CalculateArea(2.0);
var triangleArea = FigureInfo.CalculateArea(3, 4, 5);

//Проверка треугольника на прямоугольность
var isRect = FigureInfo.IsTriangleRectangular(3, 4, 5);

Console.WriteLine($"ПЛОЩАДЬ КРУГА = {circleArea}"); 
Console.WriteLine($"ПЛОЩАДЬ ТРЕУГОЛЬНИКА = {triangleArea}"); 
Console.WriteLine($"ТРЕУГОЛЬНИК ПРЯМОУГОЛЬНЫЙ? {isRect}");
```

### Консольный вывод

![image](https://user-images.githubusercontent.com/61066851/234515651-7b33d94b-7025-4ca9-9a1a-d9f426d98c77.png)

### Новые фигуры

Для добавления новой фигуры нужно создать её класс в папке ```/Figures```<br>
Затем применить к нему один из интерфейсов, наследующих ```IFigure``` (при необходимости создать собственный)

![image](https://user-images.githubusercontent.com/61066851/234516446-e65280bc-3e8a-460d-bd27-debab55606f3.png)

И добавить перегрузку метода ```DetermineFigure()``` в классе ```FigureFactory```
Или добавить новый блок case в уже имеющийся метод для автоматического определения фигуры по входным параметрам.
```c#
internal static IFigure DetermineFigure(params double[] sides)
{
    foreach (var side in sides)
    {
	if (side <= 0)
	    throw new ArgumentException("The sides cannot be equal to or less than zero");
    }

    switch (sides.Length)
    {
	case 0:
	    throw new ArgumentException();
	case 1:
	    return new Circle(sides[0]);
	case 2:
	    throw new ArgumentException();
	case 3:
	    return new Triangle(sides[0], sides[1], sides[2]);
	//Обработка новых N-угольников
    }

    throw new ArgumentException();
}
```

### Статус Юнит-тестирования

![image](https://user-images.githubusercontent.com/61066851/234514195-034b6cd9-3339-47ae-b913-8973958926ff.png)

### Покрытие

![image](https://user-images.githubusercontent.com/61066851/234518618-cb4434cc-c88c-4dfe-ada8-04769032565e.png)

## SQL

```Ruby
ПРИМЕЧАНИЕ: Названия сущностей и атрибутов на русском языке исключительно для наглядности
```

Для хранения связи сущностей "Продукт" и "Категория" в отношении многие-ко-многим необходимо создание отдельной (промежуточной) сущности "ПродуктКатегория"

![13](https://user-images.githubusercontent.com/61066851/228298549-3a0af132-4362-474b-aefb-d3919759e7a8.png)

### Запрос на выборку всех пар «Имя продукта – Имя категории»

```sql
SELECT НазваниеПродукта AS 'Продукт', НазваниеКатегории AS 'Категория'
FROM Продукт
LEFT JOIN ПродуктКатегория
	ON (Продукт.IDПродукта = ПродуктКатегория.IDПродукта)
LEFT JOIN Категория
	ON (Категория.IDКатегории = ПродуктКатегория.IDКатегории)
```

### Консольный вывод
Выводятся в том числе продукты без категорий

![1](https://user-images.githubusercontent.com/61066851/228300813-ddea159b-fbef-495a-93cb-5afef6798d0c.png)

### Тестовые данные
<div>
  <img src="https://user-images.githubusercontent.com/61066851/228301686-ad3afdf5-5a42-4c34-b055-0a6b032f4210.png" width="250"></img>
  <img src="https://user-images.githubusercontent.com/61066851/228301428-3fbe0bd0-e81e-4188-b0d7-7bbf20a45ec1.png" width="350"></img>
  <img src="https://user-images.githubusercontent.com/61066851/228301613-dba4b70b-5a86-4d65-959f-a5681c4dd2a1.png" width="350"></img>
</div>
