﻿using System;
using System.Collections.Generic;

namespace DBFirstEg.NWModels;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
