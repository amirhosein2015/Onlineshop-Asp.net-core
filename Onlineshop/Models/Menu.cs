using System;
using System.Collections.Generic;

namespace Onlineshop.Models;

public partial class Menu
{
    public string Id { get; set; } = null!;

    public string? TitleMenu { get; set; }

    public string? Link { get; set; }

    public string? Type { get; set; }
}
