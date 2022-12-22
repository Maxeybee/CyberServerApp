using Microsoft.AspNetCore.Identity;

namespace CyberServerApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CyberServerAppUser class
public class CyberServerAppUser : IdentityUser
{
    public string CyberUserName { get; set; }
}

