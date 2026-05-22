using System;
using System.Collections.Generic;

namespace SafeBite_VNJP.Models;

public partial class Customer1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }
}
