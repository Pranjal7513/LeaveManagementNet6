using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserRoleSeedConfirguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                    UserId = "18906a8b-41f2-43fc-beed-51aa12a61771"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                    UserId = "cdd405b1-0155-46ff-ad24-d4e45802b9c7"
                }
                );
        }
    }
}