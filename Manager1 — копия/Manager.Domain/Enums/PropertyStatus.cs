using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public enum PropertyStatus
    {
        Available,      // Property is available for deal
        UnderOffer,     // Property has an offer pending
        Sold,           // Property is sold
        Rented,         // Property is rented
        UnderMaintenance, // Property is currently under maintenance
        Inactive,       // Property is inactive/unavailable
        Foreclosed      // Property is foreclosed
    }
}