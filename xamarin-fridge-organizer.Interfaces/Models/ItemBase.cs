using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace xamarin_fridge_organizer.Interfaces.Models
{
    public abstract class ItemBase : IItem
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string UserCreated { get; set; }

        [DataMember]
        public string UserUpdated { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }
    }
}
