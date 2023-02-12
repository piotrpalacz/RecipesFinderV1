using System;
using Microsoft.AspNetCore.Identity;

namespace ExternalAPFI.Data.Data
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string? FullName { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        //[PersonalData]
        //public Uri GithubLink { get; set; }

        //[PersonalData]
        //public Uri LinkedInLink { get; set; }

    }
}

