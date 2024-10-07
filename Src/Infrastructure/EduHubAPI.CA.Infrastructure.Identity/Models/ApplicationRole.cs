using Microsoft.AspNetCore.Identity;
using System;

namespace EduHubAPI.CA.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
