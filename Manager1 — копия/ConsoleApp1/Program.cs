using Manager.Domain.Entities;
using Manager.Domain.Enums;
using Manager.ValueObjects;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ПРОВЕРКА СОЗДАНИЯ И ОБНОВЛЕНИЯ СОСТОЯНИЯ ===");

        // Клиент
        Console.WriteLine("\n→ Создаём клиента...");
        var client = new Client("Иван", new ContactInfo("ivan@example.com"));
        var requestId = Guid.NewGuid();
        var dealId = Guid.NewGuid();
        client.AddRequest(requestId);
        client.AddDeal(dealId);
        client.SetVipStatus(true);
        Console.WriteLine($"Клиент создан: {client.Id} | VIP: {client.IsVip}");

        // Менеджер
        Console.WriteLine("\n→ Создаём менеджера...");
        var manager = new ManagerEntity("Анна", "Отдел продаж");
        manager.ChangeName("Анна Петрова");
        manager.ChangeDepartment("Отдел аренды");
        Console.WriteLine($"Менеджер: {manager.Id} | Имя: {manager.Name.Value} | Отдел: {manager.Department.Value}");

        // Недвижимость
        Console.WriteLine("\n→ Создаём объект недвижимости и применяем скидку 10%...");
        var property = new Property(
            "Квартира в центре", "Уютная и светлая", new Address("ул. Ленина, д. 10"),
            PropertyType.Apartment, 52.5, 2, 3, 5, 12000000m, Guid.NewGuid());

        property.ApplyDiscount(10); // безопасно
        property.AddPhoto("https://site.ru/photo1.jpg");
        property.AddPhoto("https://site.ru/photo2.jpg");
        property.AddPhoto("https://site.ru/photo3.jpg");

        Console.WriteLine($"Недвижимость: {property.Id} | Цена со скидкой: {property.Price.Value}");

        // Сделка
        Console.WriteLine("\n→ Создаём сделку и добавляем платёж...");
        var deal = new Deal(property.Id, client.Id, manager.Id,
            DealType.Sale, 5_000_000m, "CNT-2024/01");

        deal.AddPayment(5_000_000m); // оплачено
        deal.CloseDeal(); // можно закрыть
        Console.WriteLine($"Сделка: {deal.Id} | Статус: {deal.Status} | Оплата: {deal.PaymentStatus}");

        // Запрос
        Console.WriteLine("\n→ Создаём запрос клиента на объект...");
        var request = new Request(client.Id, property.Id, "Интересует аренда на длительный срок");
        request.MarkAsInProgress();
        request.Approve("Хорошая история, одобрено.");
        Console.WriteLine($"Запрос: {request.Id} | Статус: {request.Status}");

        Console.WriteLine("\n=== ВСЁ РАБОТАЕТ ===");
    }
}