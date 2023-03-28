# Mindbox тестовое задание

```Kotlin
Задача №1 на создание библиотеки находится в папке FiguresTask
```
```Kotlin
Задача №2 на создание SQL запроса находится в папке SQLTask
```

## Figures

При выполнении 1-ой задачи было принято решение возвращать экземпляр фигуры вместо значений площади для более удобного получения информации о других её параметрах (проверка прямоугольности, периметр, название и тд). Вместо интерфейса используется абстрактный класс, так как существует мнение, что наличие полей у интерфейса нарушает принцип отсутствия состояния.

### Создание фигур из библиотеки и получение информации о них
```c#
//Создание фигур без указания типа фигуры
var figureOne = FigureInfo.InitiateFigure(alias:"Фигура 01", 2.0);
var figureTwo = FigureInfo.InitiateFigure(alias: "Фигура 02", 3, 4, 5);
var figureThree = FigureInfo.InitiateFigure(alias: "Фигура 03", 2, 2, 2, 2);

Console.WriteLine($"{figureOne.GetShapeName()} с именем {figureOne.GetAlias()} имеет площадь {figureOne.CalculateArea()} ");
Console.WriteLine($"{figureTwo.GetShapeName()} с именем {figureTwo.GetAlias()} имеет площадь {figureTwo.CalculateArea()} ");
//Получение информации о прямоугольности треугольника
Console.WriteLine($"{figureTwo.GetShapeName()} с именем {figureTwo.GetAlias()} прямоугольный? {figureTwo.IsRectangular()} ");
Console.WriteLine($"{figureThree.GetShapeName()} с именем {figureThree.GetAlias()} имеет площадь {figureThree.CalculateArea()} ");
```

### Консольный вывод

![17](https://user-images.githubusercontent.com/61066851/228287106-fc5f2a29-f6ae-4eff-8941-6f9bbf75cf60.png)

### Новые фигуры

Для добавления новой фигуры нужно создать её класс в папке ```/Figures```

![16](https://user-images.githubusercontent.com/61066851/228308830-53362f83-b585-46ab-90b2-614ec944754d.png)

И добавить перегрузку метода ```InitiateFigure()``` в классе ```FigureInfo```

```c#
public static Figure InitiateFigure(string alias, double radius)
{
    try
    {
        Circle circle = new Circle(alias, radius);

        return circle;
    }
    catch(NullReferenceException)
    {
        throw new NullReferenceException("Параметры не могут быть null");
    }
}
//Добавление новых перегрузок для фигур с иными параметрами
```

### Статус Юнит-тестирования

![14](https://user-images.githubusercontent.com/61066851/228288269-f4d80f5d-801e-4924-ad46-e8d33b8c6eb7.png)

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
  <img src="https://user-images.githubusercontent.com/61066851/228301613-dba4b70b-5a86-4d65-959f-a5681c4dd2a1.png" width="400"></img>
</div>

### Уважаемые MindBox, в случае если я слишком слаб для позиции Junior прошу взять меня стажёром, я готов учиться и тратить на программирование всё своё время, иначе мне вскоре придётся похоронить свои мечты, повесить клавиатуру на гвоздь и снова надеть форму гос. структуры, на этот раз из финансовых потребностей.
