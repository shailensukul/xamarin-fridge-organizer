namespace xamarin_fridge_organizer.Models
{
    using System;
    using System.Runtime.Serialization;
    using xamarin_fridge_organizer.Interfaces.Models;

    [DataContract(Name = "FridgeItem", Namespace ="urn:DataModels")]
    public sealed class FridgeItem : IItem
    {
        [DataMember]
        public Guid Id { get; set; }

        public string User { get; set; }

        public  DateTime UpdatedDate { get; set; }
    }
}
