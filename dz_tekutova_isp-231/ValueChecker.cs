class ValueChecker
{
    public void CheckType(object input)
    {
        if (input is null)
        {
            Console.WriteLine($"ссылочный тип ({input.GetType().Name})");
        }
        if (input is ValueType)
        {
            Console.WriteLine($"значимый тип ({input.GetType().Name})");
        }

        if (input == null)
        {
            Console.WriteLine("ссылочный тип (пусто)");
        }
        else
        {
            Type stroka = input.GetType();
            if (stroka.IsValueType)
            {
                Console.WriteLine($"значимый тип ({input.GetType().Name})");
            }
            else
            {
                Console.WriteLine($"ссылочный тип ({input.GetType().Name})");
            }
        }
    }
}