using Manager.Domain.Entities.Base;
using Manager.Domain.ValueObjects;
using Manager.ValueObjects;
using Manager.Domain.Enums;
using Manager.Domain.Exceptions;

namespace Manager.Domain.Entities;

public class Property : Entity<Guid>
{
    public Title Title { get; private set; }
    public Title Description { get; private set; }
    public Address Address { get; private set; }
    public PropertyType PropertyType { get; private set; }
    public Area Area { get; private set; }
    public Quantity Rooms { get; private set; }
    public Quantity Floor { get; private set; }
    public Quantity TotalFloors { get; private set; }
    public Money Price { get; private set; }
    public Guid OwnerId { get; private set; }

    private readonly ICollection<string> _photos = new List<string>();
    public ICollection<string> Photos => _photos;

    public PropertyStatus Status { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime? PublicationDate { get; private set; }

    public Property(string title, string description, Address address, PropertyType propertyType,
                    double area, int rooms, int floor, int totalFloors, decimal price, Guid ownerId)
        : this(Guid.NewGuid(), new Title(title), new Title(description), address, propertyType,
               new Area(area.ToString()), new Quantity(rooms), new Quantity(floor),
               new Quantity(totalFloors), new Money(price), ownerId)
    { }

    protected Property(Guid id, Title title, Title description, Address address,
                       PropertyType propertyType, Area area, Quantity rooms,
                       Quantity floor, Quantity totalFloors, Money price, Guid ownerId)
        : base(id)
    {
        Title = title;
        Description = description;
        Address = address;
        PropertyType = propertyType;
        Area = area;
        Rooms = rooms;
        Floor = floor;
        TotalFloors = totalFloors;
        Price = price;
        OwnerId = ownerId;
        CreatedDate = DateTime.UtcNow;
        Status = PropertyStatus.Available;
    }

    /// <summary>Конструктор для EF</summary>
    protected Property() : base(Guid.NewGuid()) { }


    public void Publish()
    {
        if (!IsValidForPublication())
            throw new PropertyNotReadyForPublicationException(Id);

        PublicationDate = DateTime.UtcNow;
        Update();
    }

    public void Reserve(Guid clientId)
    {
        if (Status != PropertyStatus.Available)
            throw new PropertyNotAvailableForReservationException(Id, Status);

        Status = PropertyStatus.Rented;
        Update();
    }

    public void MarkAsSold()
    {
        if (Status == PropertyStatus.Sold)
            throw new PropertyAlreadySoldException(Id);

        Status = PropertyStatus.Sold;
        Update();
    }

    public void ReturnToAvailable()
    {
        Status = PropertyStatus.Available;
        Update();
    }

    public void AddPhoto(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new PropertyPhotoUrlIsEmptyException(nameof(url));

        _photos.Add(url);
        Update();
    }

    public bool RemovePhoto(int index)
    {
        if (index < 0 || index >= _photos.Count) return false;

        var element = _photos.ElementAt(index);
        _photos.Remove(element);
        Update();
        return true;
    }

    public virtual string? GenerateVirtualTour()
    {
        if (_photos.Count < 3) return null;

        return "https://example.com/virtual-tour";
    }

    public virtual decimal CalculateTax()
    {
        return Price.Value * 0.13m;
    }

    public void ApplyDiscount(decimal percent)
    {
        if (percent < 0 || percent > 100)
            throw new PropertyDiscountOutOfRangeException(percent);

        var discount = Price.Value * (percent / 100);
        Price = new Money(Price.Value - discount);
        Update();
    }

    public bool IsValidForPublication()
    {
        return Title != null && Description != null && Address != null && _photos.Any();
    }

    public bool HasEssentialAmenities()
    {
        return _photos.Count >= 3 && Description != null;
    }

    private void Update()
    {

    }
}
