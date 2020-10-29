namespace xamarin_fridge_organizer.Models
{
    using System;
    using System.Runtime.Serialization;
    using xamarin_fridge_organizer.Interfaces.Models;

    public sealed class Category : IItem
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string UserCreated { get; set; }

        [DataMember]
        public string UserUpdated { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }
    }
}
