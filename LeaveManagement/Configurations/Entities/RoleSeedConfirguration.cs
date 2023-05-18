using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class RoleSeedConfirguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                } 
                );
        }
    }
} 