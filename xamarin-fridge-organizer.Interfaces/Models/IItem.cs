using System;
using System.Collections.Generic;
using System.Text;

namespace xamarin_fridge_organizer.Interfaces.Models
{
    public interface IItem
    {
        Guid Id { get; set; }

        string User { get; set; }

        DateTime UpdatedDate { get; set; }
    }
}
