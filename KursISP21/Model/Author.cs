using System;
using System.Collections.Generic;

namespace KursISP21.Model;

public partial class Author
{
    public int IdAuthor { get; set; }

    public string Surname { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? AdditionalInformation { get; set; }

    public virtual ICollection<Edition> Editions { get; set; } = new List<Edition>();
}
