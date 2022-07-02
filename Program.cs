﻿// 1. Создать базовый массив
// 2. Создать основной массив
// 3. Заполнить основной массив случайными элементами из базового
// 4. Решить основную задачу (по блок-схеме)
// 5. Вывести результат в консоль

string[] baseArray = new string[]
{
    "Самара", "Омск", "Казань", "Челябинск", "Ростов-на-Дону", "Уфа",
    "Волгоград", "Пермь", "арм", "бел", "боп", "газ", "дук", "ева",
    "зов", "орс", "чаж", "эра", "Красноярск", "Воронеж", "Саратов",
    "Краснодар", "Тольятти", "Ижевск", "Ульяновск", "Барнаул",
    "Владивосток", "бег", "гад", "ира", "лях", "мит", "мод", "сад",
    "уок", "хек", "циф", "аш", "ло", "но", "од", "он", "ра", "ре",
    "хи", "цы", "ял", "Томск", "Пенза", "Липецк", "Тула", "Киров",
    "Брянск", "Курск", "Иваново", "Сочи", "Курган", "Смоленск"
};

string[] CreateArray(int count)
{
    return new string[count];
}

void FillArray(string[] array, string[] basic, int min, int max)
{
    int length = array.Length;
    Random randomElement = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = basic[randomElement.Next(min, max)];
    }
}

string Print(string[] array)
{
    string result = String.Empty;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {  
        result += $"{array[i]} ";
    }
    return result;
}

var createdArray = CreateArray(5);
FillArray(createdArray, baseArray, 1, baseArray.Length);
Console.WriteLine($"Основной массив -> {Print(createdArray)}");
