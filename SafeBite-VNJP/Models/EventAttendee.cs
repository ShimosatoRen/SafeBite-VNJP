using System;
using System.Collections.Generic;

namespace SafeBite_VNJP.Models;

public partial class EventAttendee
{
    public int AttendeesId { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string? Email { get; set; }

    public DateTime? RegisteredAt { get; set; }
}
