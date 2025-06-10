using System;
using Manager.Domain.Entities;
using Manager.ValueObjects;
using Manager.Domain.Enums;
using Manager.Domain.Exceptions;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== TESTING ENTITY FUNCTIONALITY ===");

        try
        {
            Console.WriteLine("\n→ Создаём клиента...");
            var client = new Client("Иван", new ContactInfo("ivan@example.com"));
            client.AddRequest(Guid.NewGuid());
            client.SetVipStatus(true);
            Console.WriteLine("Клиент создан успешно!");

            Console.WriteLine("\n→ Создаём менеджера...");
            var manager = new ManagerEntity("Анна", "Отдел продаж");
            manager.ChangeName("Анна Петрова");
            Console.WriteLine("Менеджер создан и имя обновлено!");

            Console.WriteLine("\n→ Пытаемся создать менеджера с пустым именем...");
            manager.ChangeName("   "); // должна выброситься кастомная ошибка
        }
        catch (ManagerNameIsEmptyException ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[ОШИБКА]: {ex.Message}");
            Console.ResetColor();
        }

        try
        {
            Console.WriteLine("\n→ Создаём недвижимость и применяем скидку 120%...");
            var property = new Property(
                "Квартира в центре", "Уютная и светлая", new Address("ул. Ленина, д. 10"),
                PropertyType.Apartment, 52.5, 2, 3, 5, 12000000m, Guid.NewGuid());

            property.ApplyDiscount(120); // ожидается исключение
        }
        catch (PropertyDiscountOutOfRangeException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ОШИБКА]: {ex.Message}");
            Console.ResetColor();
        }

        try
        {
            Console.WriteLine("\n→ Создаём сделку и закрываем её без оплаты...");
            var deal = new Deal(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(),
                DealType.Sale, 5_000_000m, "CNT-2024/01");

            deal.CloseDeal(); // должен выбросить исключение
        }
        catch (DealCannotBeClosedException ex)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[ОШИБКА]: {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine("\n=== ТЕСТ ЗАВЕРШЁН ===");
    }
}
