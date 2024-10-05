using EmployeeManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelbuilder.Entity<LeaveApplication>()
                .HasOne(f => f.Status)
                .WithMany()
                .HasForeignKey(f => f.StatusId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<SystemCode> SystemCode { get; set; }
        public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<SystemProfile> SystemProfiles {  get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }

        public DbSet<LeaveAdjustmentEntry> LeaveAdjustmentEntries { get; set; }
        public DbSet<Audit> AuditLogs { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<RoleProfile> RoleProfiles {  get; set; }

        public DbSet<LeavePeriod> LeavePeriods { get; set; }
        public DbSet<CompanyInformation> CompanyInformations {  get; set; }
        public DbSet<ApprovalEntry>ApprovalEntries { get; set; }

        public DbSet<WorkFlowUserGroup> WorkFlowUserGroups { get; set; }

        public DbSet<ApprovalsUserMatrix> ApprovalsUserMatrixs {  get; set; }

        public DbSet<WorkFlowUserGroupMember> WorkFlowUserGroupMembers { get; set; }

        public DbSet<SecurityCompany> SecurityCompanies { get; set; }
        public DbSet<SystemAdmin> SystemAdmins { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<UserPrivilege> UserPrivileges { get; set; }
        public DbSet<SecurityOfficers> SecurityOfficers { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<TimeCardView> TimeCardViews { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Approval> Approvals { get; set; }



        public virtual async Task<int>SaveChangesAsync(string userId = null)
        {
            OnBeforeSavingChanges(userId);
            var result= await base.SaveChangesAsync();
            return result;
        }

        private void OnBeforeSavingChanges(string userId)
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Audit || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;
                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName=entry.Entity.GetType().Name;
                auditEntry.UserId = userId;
                auditEntries.Add(auditEntry);

                foreach(var property in entry.Properties)
                {
                    string propertyName=property.Metadata.Name;
                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[propertyName] = property.CurrentValue;
                        continue;
                    }
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            auditEntry.AuditType = AuditType.Create;
                            auditEntry.NewValues[propertyName]=property.CurrentValue;
                            break;
                        case EntityState.Deleted:
                            auditEntry.AuditType = AuditType.Delete;
                            auditEntry.OldValues[propertyName] = property.CurrentValue;
                            break;
                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                auditEntry.ChangedColumns.Add(propertyName);
                                auditEntry.AuditType = AuditType.Update;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;
                            }
                            
                            break;
                    }
                }
            }

            foreach (var auditEntry in auditEntries) 
            {
                AuditLogs.Add(auditEntry.ToAudit());
            }

        }
    }
}
