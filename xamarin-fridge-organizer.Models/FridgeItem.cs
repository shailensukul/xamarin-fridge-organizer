﻿namespace xamarin_fridge_organizer.Models
{
    using System;
    using System.Runtime.Serialization;
    using xamarin_fridge_organizer.Interfaces.Models;

    [DataContract(Name = "FridgeItem", Namespace ="urn:DataModels")]
    public sealed class FridgeItem : IItem
    {
        [DataMember]
        public string User { get; set; }

        [DataMember]
        public string BarCode { get; set; }

        [DataMember]
        public string Related { get; set; }

        [DataMember]
        public string Category { get; set; }

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
