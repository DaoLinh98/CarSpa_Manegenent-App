using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;

namespace CarSpa.Module.BusinessObjects {
	public class CarSpaContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(CarSpaDbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(CarSpaContextInitializer))]
	public class CarSpaDbContext : DbContext {
		public CarSpaDbContext(String connectionString)
			: base(connectionString) {
		}
		public CarSpaDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public CarSpaDbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	   public DbSet<PermissionPolicyRole> Roles { get; set; }
		public DbSet<PermissionPolicyTypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<PermissionPolicyUser> Users { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Machine> Machines { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Inventory> Inventories { get; set; }
		public DbSet<Permission> Permissions { get; set; }
		//public DbSet<ServiceRequest> ServiceRequests { get; set; }
		public DbSet<DetailServiceRequest> DetailServiceRequests { get; set; }
		public DbSet<Status> Statuses { get; set; }
		//public DbSet<Account> Accounts { get; set; }
		//public DbSet<CarSpa.Module.BusinessObjects.CarSpaDbContext> Userss { get; set; }
		//public DbSet<CarSpa.Module.BusinessObjects.CarSpaDbContext> UserLoginInfos { get; set; }




	}
}