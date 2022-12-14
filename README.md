# Тестове завдання — Рейтинг піц з json файлу

Мережа ресторанів піци хоче визначити найпопулярніші конфігурації піци, які у них замовляють.

В файлі pizzas.json є список піц і їх компонентів (toppings).

Потрібно визначити 10 найпопулярніших піц, відобразити список їх компонентів та скільки разів цю піцу замовляли. Список відсортувати за спаданням популярності.

Піци можуть містити подвійну кількість певного компоненту, наприклад:
```json
{
  "toppings": [
    "cheese",
    "cheese",
  ]
}
```

Такі піци вважати відмінними від аналогів з одинарним входженням компоненту, тобто піца з подвійним сиром != піці з сиром.

## Завдання

1.	Створити консольну програму (WPF застосунок для вакансій на WPF), що буде відображати 10 найпопулярніших піц зі списком їх компонентів та кількістю раз, що ці піци було замовлено. Або створити MVC/API застосунок для .NET Web/Fullstack вакансій. Це надасть додаткову перевагу під час перевірки завдання.
2.	Фреймворки, що можна використовувати:  
  a)	.NET 4.6.1+  
  b)	.NET Core 3.1+  
  c)	.NET 5+  
3.	Ім’я піци повинно складатись з перших двох літер кожного топінгу, що входить до складу піци, навіть якщо топінги дублюються.
4.	Для роботи з JSON файлом с піцами можна використовувати будь-яку бібліотеку для де/серіалізації та будь-який спосіб роботи з файлом.
5.	Усі зовнішні залежності мають бути встановлені через NuGET з використанням фіда за замовченням. Додаткові фіди використовувати не можна.
6.	Програма повинна бути передана на перевірку будь-яким зручним способом. Папки bin/obj повинні бути виключені з архіву/репозиторію.
