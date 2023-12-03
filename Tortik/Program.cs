using System;
using System.IO;
public static class ArrowMenu
{
    public static int ShowMenu(string[] options)
    {
        int Vibor = 0;

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + options.Length) % options.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % options.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                return Vibor;
            }
        }
    }
}
public class ZakazTorta
{
    private double chena;
    private string vibortortika;
    private string infazakaz;

    public static int ShowSubMenu(string[] options)
    {
        return ArrowMenu.ShowMenu(options);
    }
    public ZakazTorta()
    {
        chena = 0;
        vibortortika = "";
        infazakaz = "";
    }
    public void PlaceOrder()
    {
        int Vibor = 0;
        string[] options = { "Форма торта", "Размер торта", "Вкус коржей", "Количество коржей", "Глазурь", "Декор", "Завершить заказ" };

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" Заказ тортов в Глазурька , торты на ваш выбор");
            Console.WriteLine("Выберите параметр торта");

            for (int i = 0; i < options.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine(options[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Цена: " + chena);
            Console.Write("Ваш торт: ");
            Console.WriteLine(vibortortika);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + options.Length) % options.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % options.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (Vibor == 0)
                {
                    generationzakaza();
                    break;
                }
                else
                {
                    if (!string.IsNullOrEmpty(vibortortika))
                    {
                        vibortortika += "; ";
                    }
                    if (Vibor == 6)
                    {
                        vibortortika += ChooseCakeForm(out double formPrice);
                        chena += formPrice;
                    }
                    else if (Vibor == 1)
                    {
                        vibortortika += ChooseCakeSize(out double sizePrice);
                        chena += sizePrice;
                    }
                    else if (Vibor == 2)
                    {
                        vibortortika += ChooseCakeTaste(out double tastePrice);
                        chena += tastePrice;
                    }
                    else if (Vibor == 3)
                    {
                        vibortortika += ChooseCakeQuantity(out double quantityPrice);
                        chena += quantityPrice;
                    }
                    else if (Vibor == 4)
                    {
                        vibortortika += ChooseCakeGlaze(out double glazePrice);
                        chena += glazePrice;
                    }
                    else if (Vibor == 5)
                    {
                        vibortortika += ChooseCakeDecor(out double decorPrice);
                        chena += decorPrice;
                    }
                }


            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                Vibor = 0;
            }
        }
    }
    private string ChooseCakeForm(out double formPrice)
    {
        string[] formOptions = { "Круг", "Квадрат", "Прямоугольник", "Сердечко" };
        double[] formPrices = { 500, 500, 500, 700 };

        int Vibor = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите форму торта:");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < formOptions.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{formOptions[i]} - {formPrices[i]} ");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + formOptions.Length) % formOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % formOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                formPrice = formPrices[Vibor];
                return formOptions[Vibor];
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                formPrice = 0;
                return "Не выбрано";
            }
        }
    }
    private string ChooseCakeSize(out double sizePrice)
    {
        string[] sizeOptions = { "Маленький (Диаметр - 16 см, 8 порций)", "Обычный (Диаметр - 18 см, 10 порций)", "Большой (Диаметр - 28 см, 24 порции)" };
        double[] sizePrices = { 1000, 1200, 2000 };

        int Vibor = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите размер торта:");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < sizeOptions.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{sizeOptions[i]} - {sizePrices[i]} ");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + sizeOptions.Length) % sizeOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % sizeOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                sizePrice = sizePrices[Vibor];
                return sizeOptions[Vibor];
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                sizePrice = 0;
                return "Не выбрано";
            }
        }
    }
    private string ChooseCakeTaste(out double tastePrice)
    {
        string[] tasteOptions = { "Ванильный", "Шоколадный", "Карамельный", "Ягодный", "Кокосовый" };
        double[] tastePrices = { 100, 100, 150, 200, 250 };

        int Vibor = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите вкус коржей:");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < tasteOptions.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{tasteOptions[i]} - {tastePrices[i]} ");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + tasteOptions.Length) % tasteOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % tasteOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                tastePrice = tastePrices[Vibor];
                return tasteOptions[Vibor];
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                tastePrice = 0;
                return "Не выбрано";
            }
        }
    }
    private string ChooseCakeQuantity(out double quantityPrice)
    {
        string[] quantityOptions = { "1 корж", "2 коржа", "3 коржа", "4 коржа" };
        double[] quantityPrices = { 200, 400, 600, 800 };

        int Vibor = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите количество коржей:");
           
            for (int i = 0; i < quantityOptions.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{quantityOptions[i]} - {quantityPrices[i]} ");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + quantityOptions.Length) % quantityOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % quantityOptions.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                quantityPrice = quantityPrices[Vibor];
                return quantityOptions[Vibor];
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                quantityPrice = 0;
                return "Не выбрано";
            }
        }
    }
    private string ChooseCakeGlaze(out double glazePrice)
    {
        string[] glazyr = { "Шоколад", "Крем", "Бизе", "Драже", "Ягоды" };
        double[] glazePrices = { 100, 100, 150, 150, 200 };

        int Vibor = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите глазурь:");

            for (int i = 0; i < glazyr.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{glazyr[i]} - {glazePrices[i]} ");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();


            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + glazyr.Length) % glazyr.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % glazyr.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                glazePrice = glazePrices[Vibor];
                return glazyr[Vibor];
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                glazePrice = 0;
                return "Не выбрано";
            }
        }
    }
    private string ChooseCakeDecor(out double decorPrice)
    {
        string[] decor = { "Шоколадная", "Ягодная", "Кремовая" };
        double[] decorPrices = { 150, 150, 150 };

        int Vibor = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите декор:");

            for (int i = 0; i < decor.Length; i++)
            {
                if (i == Vibor)
                {
                    Console.Write("-> ");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{decor[i]} - {decorPrices[i]} ");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                Vibor = (Vibor - 1 + decor.Length) % decor.Length;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                Vibor = (Vibor + 1) % decor.Length;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                decorPrice = decorPrices[Vibor];
                return decor[Vibor];
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                decorPrice = 0;
                return "Не выбрано";
            }
        }
    }
    private void generationzakaza()
    {
        Console.WriteLine("Заказ завершен. Цена: " + chena);
        Console.WriteLine("Ваш торт: " + vibortortika);

        DateTime vremy = DateTime.Now;
        string vremyzakaza = vremy.ToString("dd.MM.yyyy HH:mm:ss");

        infazakaz = "Время завершения заказа: " + vremyzakaza + Environment.NewLine +
                    "Из чего сделан торт: " + vibortortika + Environment.NewLine +
                    "Окончательная цена: " + chena.ToString("C");

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "История заказов.txt");

        try
        {
            File.AppendAllText(filePath, infazakaz + Environment.NewLine);
            Console.WriteLine("Информация о заказе сохранена в файле История заказов.txt на рабочем столе.");
        }
        catch (IOException e)
        {
            Console.WriteLine("Произошла ошибка при сохранении файла: " + e.Message);
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            ZakazTorta order = new ZakazTorta();
            order.PlaceOrder();

            Console.WriteLine("Желаете оформить еще один заказ? (Да Нет)");
            string response = Console.ReadLine();
            if (response.ToLower() != "да")
            {
                break;
            }
        }
    }

}
