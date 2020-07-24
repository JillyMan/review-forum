using System;

namespace ReviewManagement.App.Models
{
    public interface IUpdateCommand
    {
        DateTime UpdatedAt { get; set; }
    }
}
