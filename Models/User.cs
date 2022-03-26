using Microsoft.AspNetCore.Identity;

namespace MyBook.Models;

public class User : IdentityUser
{
    public int Year { get; set; }
}