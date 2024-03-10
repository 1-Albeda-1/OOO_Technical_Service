namespace TechnicalService.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrokenTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestDate = c.DateTimeOffset(nullable: false, precision: 7),
                        EquipmentId = c.Int(nullable: false),
                        BrokenTypeId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        Description = c.String(),
                        Priority = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BrokenTypes", t => t.BrokenTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Equipments", t => t.EquipmentId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.EquipmentId)
                .Index(t => t.BrokenTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SerialNumber = c.String(),
                        EquipmentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentTypeId, cascadeDelete: true)
                .Index(t => t.EquipmentTypeId);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        CompletionDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reason = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: true)
                .Index(t => t.RequestId);
            
            CreateTable(
                "dbo.SparesCounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.String(),
                        SparesTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SparesTypes", t => t.SparesTypeId, cascadeDelete: true)
                .Index(t => t.SparesTypeId);
            
            CreateTable(
                "dbo.SparesTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeRequests",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false),
                        Request_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_Id, t.Request_Id })
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .ForeignKey("dbo.Requests", t => t.Request_Id, cascadeDelete: true)
                .Index(t => t.Employee_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.CommentRequests",
                c => new
                    {
                        Comment_Id = c.Int(nullable: false),
                        Request_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Comment_Id, t.Request_Id })
                .ForeignKey("dbo.Comments", t => t.Comment_Id, cascadeDelete: true)
                .ForeignKey("dbo.Requests", t => t.Request_Id, cascadeDelete: true)
                .Index(t => t.Comment_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.SparesCountReports",
                c => new
                    {
                        SparesCount_Id = c.Int(nullable: false),
                        Report_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SparesCount_Id, t.Report_Id })
                .ForeignKey("dbo.SparesCounts", t => t.SparesCount_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reports", t => t.Report_Id, cascadeDelete: true)
                .Index(t => t.SparesCount_Id)
                .Index(t => t.Report_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "StatusId", "dbo.Status");
            DropForeignKey("dbo.SparesCounts", "SparesTypeId", "dbo.SparesTypes");
            DropForeignKey("dbo.SparesCountReports", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.SparesCountReports", "SparesCount_Id", "dbo.SparesCounts");
            DropForeignKey("dbo.Reports", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.Requests", "EquipmentId", "dbo.Equipments");
            DropForeignKey("dbo.Equipments", "EquipmentTypeId", "dbo.EquipmentTypes");
            DropForeignKey("dbo.CommentRequests", "Request_Id", "dbo.Requests");
            DropForeignKey("dbo.CommentRequests", "Comment_Id", "dbo.Comments");
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.EmployeeRequests", "Request_Id", "dbo.Requests");
            DropForeignKey("dbo.EmployeeRequests", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Comments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Requests", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Requests", "BrokenTypeId", "dbo.BrokenTypes");
            DropIndex("dbo.SparesCountReports", new[] { "Report_Id" });
            DropIndex("dbo.SparesCountReports", new[] { "SparesCount_Id" });
            DropIndex("dbo.CommentRequests", new[] { "Request_Id" });
            DropIndex("dbo.CommentRequests", new[] { "Comment_Id" });
            DropIndex("dbo.EmployeeRequests", new[] { "Request_Id" });
            DropIndex("dbo.EmployeeRequests", new[] { "Employee_Id" });
            DropIndex("dbo.SparesCounts", new[] { "SparesTypeId" });
            DropIndex("dbo.Reports", new[] { "RequestId" });
            DropIndex("dbo.Equipments", new[] { "EquipmentTypeId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropIndex("dbo.Comments", new[] { "EmployeeId" });
            DropIndex("dbo.Requests", new[] { "StatusId" });
            DropIndex("dbo.Requests", new[] { "ClientId" });
            DropIndex("dbo.Requests", new[] { "BrokenTypeId" });
            DropIndex("dbo.Requests", new[] { "EquipmentId" });
            DropTable("dbo.SparesCountReports");
            DropTable("dbo.CommentRequests");
            DropTable("dbo.EmployeeRequests");
            DropTable("dbo.Status");
            DropTable("dbo.SparesTypes");
            DropTable("dbo.SparesCounts");
            DropTable("dbo.Reports");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Equipments");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.Comments");
            DropTable("dbo.Clients");
            DropTable("dbo.Requests");
            DropTable("dbo.BrokenTypes");
        }
    }
}
