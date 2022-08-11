using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ShelteredV1.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
       
        
            public IdentityDataContext() : base("dataConnection")
            {
                
            }
            
        
    }
}