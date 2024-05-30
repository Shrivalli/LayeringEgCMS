using System;
using System.Collections.Generic;

namespace DBFirstEg.NWModels;

public partial class V1
{
    public string CustomerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? City { get; set; }
}
