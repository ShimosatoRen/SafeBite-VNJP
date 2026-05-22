using System;
using System.Collections.Generic;

namespace SafeBite_VNJP.Models;

public partial class TodoItem
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool IsComplete { get; set; }
}
