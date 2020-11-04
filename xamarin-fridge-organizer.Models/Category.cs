namespace xamarin_fridge_organizer.Models
{
    using System;
    using System.Runtime.Serialization;
    using xamarin_fridge_organizer.Interfaces.Models;

    public sealed class Category : ItemBase
    {
        [DataMember]
        public string Name { get; set; }
    }
}
