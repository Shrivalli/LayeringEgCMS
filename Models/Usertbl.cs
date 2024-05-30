using System;
using System.Collections.Generic;

namespace DBFirstEg.Models;

public partial class Usertbl
{
    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Username { get; set; }
}
