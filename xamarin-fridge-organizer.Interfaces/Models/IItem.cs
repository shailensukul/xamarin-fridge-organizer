using System;
using System.Collections.Generic;
using System.Text;

namespace xamarin_fridge_organizer.Interfaces.Models
{
    public interface IItem
    {
        Guid Id { get; set; }

        string UserCreated { get; set; }
        string UserUpdated { get; set; }

        DateTime UpdatedDate { get; set; }

        DateTime CreatedDate { get; set; }
    }
}
