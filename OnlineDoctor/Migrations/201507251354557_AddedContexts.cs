namespace OnlineDoctor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedContexts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        SerialNo = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TimeFrom = c.DateTime(nullable: false),
                        TimeTo = c.DateTime(nullable: false),
                        Doctor_Id = c.String(maxLength: 128),
                        Patient_PatientId = c.Int(),
                        ServiceCenter_ServiceCenterId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.AspNetUsers", t => t.Doctor_Id)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .ForeignKey("dbo.ServiceCenters", t => t.ServiceCenter_ServiceCenterId)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_PatientId)
                .Index(t => t.ServiceCenter_ServiceCenterId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FathersName = c.String(),
                        MothersName = c.String(),
                        DateOfBirth = c.DateTime(),
                        NationalIdNo = c.Int(),
                        Age = c.Int(),
                        Address = c.String(),
                        Gender = c.Int(),
                        Occupation = c.String(),
                        CityId = c.Int(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        IsActive = c.Boolean(),
                        DoctorId = c.Int(identity: true),
                        DoctorName = c.String(),
                        RegistrationNo = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Area_AreaId = c.Int(),
                        DoctorRank_DoctorRankId = c.Int(),
                        Specialization_SpecializationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Area_AreaId)
                .ForeignKey("dbo.DoctorRanks", t => t.DoctorRank_DoctorRankId)
                .ForeignKey("dbo.Specializations", t => t.Specialization_SpecializationId)
                .Index(t => t.Area_AreaId)
                .Index(t => t.DoctorRank_DoctorRankId)
                .Index(t => t.Specialization_SpecializationId);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaId = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        PostCode = c.Short(nullable: false),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.AreaId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Country_CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .Index(t => t.Country_CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.ServiceCenters",
                c => new
                    {
                        ServiceCenterId = c.Int(nullable: false, identity: true),
                        ServiceCenterName = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        HospitalId = c.Int(),
                        HospitalName = c.String(),
                        ChamberId = c.Int(),
                        ChamberName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Area_AreaId = c.Int(),
                        Area_AreaId1 = c.Int(),
                        Doctor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ServiceCenterId)
                .ForeignKey("dbo.Areas", t => t.Area_AreaId)
                .ForeignKey("dbo.Areas", t => t.Area_AreaId1)
                .ForeignKey("dbo.AspNetUsers", t => t.Doctor_Id)
                .Index(t => t.Area_AreaId)
                .Index(t => t.Area_AreaId1)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.ChamberTimeTables",
                c => new
                    {
                        ChamberTimeTableId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        ChamberId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Day = c.Int(nullable: false),
                        Chamber_ServiceCenterId = c.Int(),
                        Doctor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ChamberTimeTableId)
                .ForeignKey("dbo.ServiceCenters", t => t.Chamber_ServiceCenterId)
                .ForeignKey("dbo.AspNetUsers", t => t.Doctor_Id)
                .Index(t => t.Chamber_ServiceCenterId)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoctorRanks",
                c => new
                    {
                        DoctorRankId = c.Int(nullable: false, identity: true),
                        UserCount = c.Int(nullable: false),
                        RankValue = c.Int(nullable: false),
                        Appointment_AppointmentId = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorRankId)
                .ForeignKey("dbo.Appointments", t => t.Appointment_AppointmentId)
                .Index(t => t.Appointment_AppointmentId);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        QualificationId = c.Int(nullable: false, identity: true),
                        QualificationName = c.String(),
                        Doctor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.QualificationId)
                .ForeignKey("dbo.AspNetUsers", t => t.Doctor_Id)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.Specializations",
                c => new
                    {
                        SpecializationId = c.Int(nullable: false, identity: true),
                        SpecializationName = c.String(),
                        Hospital_ServiceCenterId = c.Int(),
                    })
                .PrimaryKey(t => t.SpecializationId)
                .ForeignKey("dbo.ServiceCenters", t => t.Hospital_ServiceCenterId)
                .Index(t => t.Hospital_ServiceCenterId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        Medication = c.String(),
                        Test = c.String(),
                        PrescriptionImage = c.String(),
                        Remedy = c.String(),
                        Appointment_AppointmentId = c.Int(),
                        Doctor_Id = c.String(maxLength: 128),
                        Patient_PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Appointments", t => t.Appointment_AppointmentId)
                .ForeignKey("dbo.AspNetUsers", t => t.Doctor_Id)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .Index(t => t.Appointment_AppointmentId)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_PatientId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        DayOfWeek = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        NoOfDayPerWeek = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Prescriptions", "Doctor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Prescriptions", "Appointment_AppointmentId", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "ServiceCenter_ServiceCenterId", "dbo.ServiceCenters");
            DropForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Specializations", "Hospital_ServiceCenterId", "dbo.ServiceCenters");
            DropForeignKey("dbo.AspNetUsers", "Specialization_SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.ServiceCenters", "Doctor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ServiceCenters", "Area_AreaId1", "dbo.Areas");
            DropForeignKey("dbo.Qualifications", "Doctor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "DoctorRank_DoctorRankId", "dbo.DoctorRanks");
            DropForeignKey("dbo.DoctorRanks", "Appointment_AppointmentId", "dbo.Appointments");
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Area_AreaId", "dbo.Areas");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ChamberTimeTables", "Doctor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ChamberTimeTables", "Chamber_ServiceCenterId", "dbo.ServiceCenters");
            DropForeignKey("dbo.ServiceCenters", "Area_AreaId", "dbo.Areas");
            DropForeignKey("dbo.Cities", "Country_CountryId", "dbo.Countries");
            DropForeignKey("dbo.Areas", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Prescriptions", new[] { "Patient_PatientId" });
            DropIndex("dbo.Prescriptions", new[] { "Doctor_Id" });
            DropIndex("dbo.Prescriptions", new[] { "Appointment_AppointmentId" });
            DropIndex("dbo.Appointments", new[] { "ServiceCenter_ServiceCenterId" });
            DropIndex("dbo.Appointments", new[] { "Patient_PatientId" });
            DropIndex("dbo.Specializations", new[] { "Hospital_ServiceCenterId" });
            DropIndex("dbo.AspNetUsers", new[] { "Specialization_SpecializationId" });
            DropIndex("dbo.ServiceCenters", new[] { "Doctor_Id" });
            DropIndex("dbo.ServiceCenters", new[] { "Area_AreaId1" });
            DropIndex("dbo.Qualifications", new[] { "Doctor_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "DoctorRank_DoctorRankId" });
            DropIndex("dbo.DoctorRanks", new[] { "Appointment_AppointmentId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "Area_AreaId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.ChamberTimeTables", new[] { "Doctor_Id" });
            DropIndex("dbo.ChamberTimeTables", new[] { "Chamber_ServiceCenterId" });
            DropIndex("dbo.ServiceCenters", new[] { "Area_AreaId" });
            DropIndex("dbo.Cities", new[] { "Country_CountryId" });
            DropIndex("dbo.Areas", new[] { "City_CityId" });
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Patients");
            DropTable("dbo.Specializations");
            DropTable("dbo.Qualifications");
            DropTable("dbo.DoctorRanks");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.ChamberTimeTables");
            DropTable("dbo.ServiceCenters");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Areas");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Appointments");
        }
    }
}
