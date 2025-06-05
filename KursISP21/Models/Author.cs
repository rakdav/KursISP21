using KursISP21.ViewModels;
using System;
using System.Collections.Generic;

namespace KursISP21.Model;

public partial class Author:BaseViewModel
{
    public int IdAuthor { get; set; }

    private string? surname;
    public string? Surname 
    {
        get { return surname; }
        set
        {
            surname = value;
            OnPropertyChanged(nameof(Surname));
        }
    }
    private string? firstName;
    public string? FirstName 
    {
        get { return firstName; }
        set
        {
            firstName = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }
    private string? lastName;
    public string? LastName 
    {
        get { return lastName; }
        set
        {
            lastName = value;
            OnPropertyChanged(nameof(LastName));
        }
    }
    private string? address;
    public string? Address 
    {
        get { return address; }
        set
        {
            address = value;
            OnPropertyChanged(nameof(Address));
        }
    }
    private string? phone;
    public string? Phone 
    {
        get { return phone; }
        set
        {
            phone = value;
            OnPropertyChanged(nameof(Phone));
        }
    }
    private string? additionalInformation;

    public string? AdditionalInformation 
    {
        get { return additionalInformation; }
        set
        {
            additionalInformation = value;
            OnPropertyChanged(nameof(AdditionalInformation));
        }
    }
    public virtual ICollection<Edition> Editions { get; set; } = new List<Edition>();
}
