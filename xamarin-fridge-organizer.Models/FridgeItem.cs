namespace xamarin_fridge_organizer.Models
{
    using System;
    using System.Runtime.Serialization;
    using xamarin_fridge_organizer.Interfaces.Models;

    [DataContract(Name = "FridgeItem", Namespace ="urn:DataModels")]
    public sealed class FridgeItem : ItemBase
    {
        [DataMember]
        public string User { get; set; }

        [DataMember]
        public string BarCode { get; set; }

        [DataMember]
        public string Related { get; set; }

        [DataMember]
        public string Category { get; set; }
    }
}
