using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public enum PropertyType
    {
        Apartment,      // Apartment unit
        House,          // Single-family house
        Townhouse,      // Townhouse
        Condo,          // Condominium
        Commercial,     // Commercial property (office, retail)
        Land,           // Vacant land
        Industrial,     // Industrial property (warehouse, factory)
        Farm,           // Farm property
        Other           // Other property types
    }
}