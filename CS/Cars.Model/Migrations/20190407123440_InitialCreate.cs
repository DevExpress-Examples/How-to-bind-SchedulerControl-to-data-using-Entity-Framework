using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cars.Model.Migrations {
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Trademark = table.Column<string>(maxLength: 50, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    HP = table.Column<short>(nullable: true),
                    Liter = table.Column<double>(nullable: true),
                    Cyl = table.Column<byte>(nullable: true),
                    TransmissSpeedCount = table.Column<byte>(nullable: true),
                    TransmissAutomatic = table.Column<string>(maxLength: 3, nullable: true),
                    MPG_City = table.Column<byte>(nullable: true),
                    MPG_Highway = table.Column<byte>(nullable: true),
                    Category = table.Column<string>(maxLength: 7, nullable: true),
                    Hyperlink = table.Column<string>(maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarScheduling",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Label = table.Column<int>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    Location = table.Column<string>(maxLength: 50, nullable: true),
                    AllDay = table.Column<bool>(nullable: false),
                    EventType = table.Column<int>(nullable: false),
                    PatternId = table.Column<string>(nullable: true),
                    RecurrenceRule = table.Column<string>(nullable: true),
                    RecurrenceIndex = table.Column<string>(nullable: false),
                    ReminderInfo = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "smallmoney", nullable: true),
                    ContactInfo = table.Column<string>(nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_CarScheduling", x => x.ID);
                });

            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Mercedes-Benz','SL500 Roadster',302,4.966000000000000e+000,8,5,'Yes',16,23,'SPORTS','http://www.mercedes.com',83800.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Mercedes-Benz','CLK55 AMG Cabriolet',342,5.439000000000000e+000,8,5,'Yes',17,24,'SPORTS','http://www.mercedes.com',79645.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Mercedes-Benz','C230 Kompressor Sport Coupe',189,1.796000000000000e+000,4,5,'Yes',21,28,'SPORTS','http://www.mercedes.com',25600.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('BMW','530i',225,3.000000000000000e+000,6,5,'No',21,30,'SALOON','http://www.bmw.com',39450.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Rolls-Royce','Corniche',325,6.750000000000000e+000,8,4,'Yes',11,16,'SALOON','http://www.rollsroyce.com',370485.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Jaguar','S-Type 3.0',235,3.000000000000000e+000,6,5,'No',18,25,'SALOON','http://www.jaguar.com',44320.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Cadillac','Seville',275,4.600000000000000e+000,8,4,'Yes',18,27,'SALOON','http://www.cadillac.com',49600.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Cadillac','DeVille',275,4.600000000000000e+000,8,4,'Yes',18,27,'SALOON','http://www.cadillac.com',47780.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Lexus','LS430',290,4.300000000000000e+000,8,5,'Yes',18,25,'SALOON','http://www.lexus.com',54900.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Lexus','GS 430',300,4.300000000000000e+000,8,5,'Yes',18,23,'SALOON','http://www.lexus.com',41242.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Ford','Ranger FX-4',135,2.300000000000000e+000,4,5,'Yes',21,25,'TRUCK','http://www.ford.com',12565.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Dodge','Ram 1500',215,3.700000000000000e+000,6,4,'Yes',15,19,'TRUCK','http://www.dodge.com',17315.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('GMC','Siera Quadrasteer',200,4.300000000000000e+000,6,4,'Yes',15,20,'TRUCK','http://www.gmc.com',17748.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Nissan','Crew Cab SE',143,2.400000000000000e+000,4,4,'Yes',20,23,'TRUCK','http://www.NissanDriven.com',12800.0000)");
            migrationBuilder.Sql("INSERT INTO [Cars] ([Trademark],[Model],[HP],[Liter],[Cyl],[TransmissSpeedCount],[TransmissAutomatic],[MPG_City],[MPG_Highway],[Category],[Hyperlink],[Price])VALUES('Toyota', 'Tacoma S-Runner', 190, 3.400000000000000e+000, 6, 5, 'No', 18, 22, 'TRUCK', 'http://www.toyota.com', 20000.0000)");

            var year = DateTime.Today.Year;
            var month = DateTime.Today.Month.ToString().PadLeft(2, '0');

            migrationBuilder.Sql("INSERT INTO [CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo]) " +
                $"VALUES(1, NULL, 3, 'Mr.Brown', 'Rent this car', 2, '{year}-{month}-12 11:00:00','{year}-{month}-12 14:30:00', 'city', 0, 0, NULL, NULL, 0, NULL, 8.0000, 'cellular: +530145961202')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $" VALUES(1, NULL, 2, 'Repair', 'Scheduled repair of this car', 4,'{year}-{month}-14 8:00:00','{year}-{month}-14 16:30:00', 'Service Center', 0, 0, NULL, NULL, 0, NULL, 90.0000, 'Contact: Paula Wilson Address: OR Elgin City Center Plaza 516 Main St.')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 3, 'Mr.White', 'Rent this car', 3, '{year}-{month}-13 10:00:00','{year}-{month}-13 17:00:00', 'city', 0, 0, NULL, NULL, 0, NULL, 7.5000, 'phone: (401) 349-4620')");

            var endRecurrenceDate = DateTime.Today.AddMonths(3);
            var recYear = endRecurrenceDate.Year;
            var recMonth = endRecurrenceDate.Month.ToString().PadLeft(2, '0');

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
            $"VALUES(2, NULL, 1, 'Wash', 'Wash this car in the garage', 1, '{year}-{month}-05 16:30:00', '{year}-{month}-05 18:00:00', 'Garage', 0, 1, '975889a8-ea37-4625-a1ec-0fb2806199e2', 'FREQ=DAILY;UNTIL={recYear}{recMonth}01T000000', 0, NULL, 7.5000, '7466 - Gas / Car Wash')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(NULL, NULL, 3, 'Tune up', 'Check up after maintenance', 5, '{year}-{month}-15 19:30:00', '{year}-{month}-15 22:30:00', 'Service', 0, 0, NULL, NULL, 0, NULL, 45.0000, 'Len Radde, 10564 W Woodward Ave, Wauwatosa WI 53444  Email: s_vanish1@servicec.com')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 3, 'Mr.Green', 'Rent this car for the all day', 3, '{year}-{month}-11 12:00:00', '{year}-{month}-12 12:00:00', 'city', 1, 0, NULL, NULL, 0, NULL, 6.0000, 'Phone: (414) 964-5861 (w); (414) 647-1231 (cell); (414) 965-5950 (fax)')");

            recYear = DateTime.Today.Year + 20;

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(NULL, NULL, -1, 'Wash', 'Wash this car in the garage', -1, '{year}-{month}-11 7:00:00', '{year}-{month}-11 9:00:00', 'Garage', 0, 1, '51c81018-53fa-4d10-925f-2ed7f8408c75', 'FREQ=YEARLY;BYMONTH=12;BYDAY=-1FR;UNTIL={recYear}1201T000000', 0, NULL, 10.0000, 'Test')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(3, NULL, 4, 'Mrs.Black', 'Rent this car', 3, '{year}-{month}-11 10:00:00', '{year}-{month}-11 11:30:00', 'out-of-town', 0, 0, NULL, NULL, 0, NULL, 7.0000, 'Phone: (262) 946-9474; w (222) 723-2678 x22, cell (253) 713-0563, fax (361) 733-2870')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(3, NULL, 4, 'Mrs.Black', 'Rent this car', 3, '{year}-{month}-12 13:00:00', '{year}-{month}-12 14:30:00', 'out-of-town', 0, 0, NULL, NULL, 0, NULL, 7.0000, 'Phone: (262) 946-9474; w (222) 723-2678 x22, cell (253) 713-0563, fax (361) 733-2870')");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(3, NULL, 4, 'Mrs.Black', 'Rent this car', 3, '{year}-{month}-13 15:30:00', '{year}-{month}-14 14:00:00', 'out-of-town', 0, 0, NULL, NULL, 0, NULL, 7.0000, 'Phone: (262) 946-9474; w (222) 723-2678 x22, cell (253) 713-0563, fax (361) 733-2870')");

            //!!! START Changed Occurrance
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 1, 'Wash', 'Wash this car in the garage', 1, '{year}-{month}-07 16:30:00', '{year}-{month}-07 18:00:00', 'Garage', 0, 3, '975889a8-ea37-4625-a1ec-0fb2806199e2', NULL, 2, NULL, 0.0000, NULL)");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 1, 'Wash', 'Wash this car in the garage', 1, '{year}-{month}-14 18:30:00', '{year}-{month}-14 20:00:00', 'Garage', 0, 3, '975889a8-ea37-4625-a1ec-0fb2806199e2', NULL, 9, NULL, 0.0000, NULL)");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 1, 'Wash', 'Wash this car in the garage', 1, '{year}-{month}-23 15:00:00', '{year}-{month}-23 16:30:00', 'Garage', 0, 3, '975889a8-ea37-4625-a1ec-0fb2806199e2', NULL, 16, NULL, 0.0000, NULL)");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 1, 'Wash', 'Wash this car in the garage', 1, '{year}-{month}-25 16:30:00', '{year}-{month}-25 17:00:00', 'Garage', 0, 3, '975889a8-ea37-4625-a1ec-0fb2806199e2', NULL, 18, NULL, 0.0000, NULL)");

            //!!! END Changed Occurrance

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 2, 'London - Brussels', 'Travel from London to Brussels by Eurostar, leaving London St Pancras at 13:00 (12:57 Fridays & Sundays), arriving Brussels Midi 16:03', 6, '{year}-{month}-23 13:00:00', '{year}-{month}-23 16:06:00', 'Eurostar', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 2, 'Brussels - Cologne', 'Travel from Brussels to Cologne by high-speed Thalys train, leaving Brussels Midi at 17:25, arriving in Cologne Hauptbahnhof at 19:45.', 6, '{year}-{month}-23 17:25:00', '{year}-{month}-23 19:45:00', 'Thalys', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 2, 'Cologne - Vienna', 'Travel from Cologne to Vienna on the excellent City Night Line hotel train ''Donau Kurier'', leaving Cologne Hauptbahnhof at 20:06 and arriving in Vienna Westbahnhof at 08:35.', 6, '{year}-{month}-23 20:06:00', '{year}-{month}-24 20:35:00', 'Donau Kurier', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 2, 'Vienna - Budapest', 'Travel from Vienna to Budapest on the air-conditioned InterCity train ''Avala'', leaving Vienna Westbahnhof at 09:52 and arriving in Budapest Keleti station at 12:53.', 6, '{year}-{month}-24 09:52:00', '{year}-{month}-24 12:53:00', 'Avala', 0, 0, NULL,NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 2, 'Budapest - Bucharest', 'Travel from Budapest to Bucharest overnight on the EuroNight sleeper train ''Ister'', leaving Budapest Keleti station at 17:45 and arriving at Bucharest (Nord station) at 08:43 next morning.', 6, '{year}-{month}-24 17:45:00', '{year}-{month}-25 08:43:00', 'Ister', 0, 0,NULL, NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(1, NULL, 2, 'Bucharest - Istanbul', 'Travel from Bucharest to Istanbul on the ''Bosphor'', leaving Bucharest (Nord) daily at 12:15 and arriving at Istanbul (Sirkeci station) at 08:00 next day.', 6, '{year}-{month}-25 12:15:00', '{year}-{month}-26 08:00:00', 'Bosphor', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(2, NULL, 2, 'Istanbul - Aleppo', 'The famous ''Toros Express'', named after the Taurus mountains through which it passes, runs 3 times a week from Istanbul (Haydarpasa station on the Asian side) to Gaziantep in southern Turkey.  Once a week on Sundays, it conveys a direct sleeping-car from Istanbul to Aleppo in Syria.', 6, '{year}-{month}-27 08:55:00', '{year}-{month}-28 14:17:00', 'Toros Express', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(3, NULL, 2, 'Aleppo - Damascus', 'Aleppo       depart  10:05    Hama         arr/dep 11:30   Homs         arr/dep 12:30   Damascus  arrive   13:30 Damascus Kadem station   ', 6, '{year}-{month}-29 10:05:00', '{year}-{month}-29 13:30:00', 'Train No.12', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");
            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(4, NULL, 2, 'Damascus - Amman', 'Damascus  (Kadem station)  depart  08:00   Deraa  (change trains)  depart 13:15  Mafraq  arrive 15:00    Amman  arrive 17:00   ', 6, '{year}-{month}-28 08:00:00', '{year}-{month}-28 17:00:00', 'Hejaz railway', 0, 0, NULL, NULL, 0, NULL, NULL, NULL)");

            endRecurrenceDate = DateTime.Today.AddMonths(3);
            recYear = endRecurrenceDate.Year;
            recMonth = endRecurrenceDate.Month.ToString().PadLeft(2, '0');

            migrationBuilder.Sql("INSERT INTO[CarScheduling] ([CarId],[UserId],[Status],[Subject],[Description],[Label],[StartTime],[EndTime],[Location],[AllDay],[EventType],[PatternId], [RecurrenceRule], [RecurrenceIndex], [ReminderInfo],[Price],[ContactInfo])" +
                $"VALUES(3, NULL, 2, 'Check oil', 'Regular Maintenance #1', 7, '{year}-{month}-21 12:00:00', '{year}-{month}-22 12:00:00', 'Parking', 0, 1, '1304e53a-a1db-4159-8de8-8ee62c7c7424', 'FREQ=WEEKLY;BYDAY=WE;INTERVAL=2;UNTIL={recYear}{recMonth}01T000000', 0, NULL, NULL, NULL)");

        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarScheduling");
        }
    }
}
