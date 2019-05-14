Imports System
Imports Cars.Model
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure
Imports Microsoft.EntityFrameworkCore.Migrations
Imports Microsoft.EntityFrameworkCore.Storage.ValueConversion

<DbContext(GetType(CarsContext))>
<Migration("20190407123440_InitialCreate")>
Partial Class InitialCreate
    Protected Overrides Sub BuildTargetModel(ByVal modelBuilder As ModelBuilder)
        modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
        modelBuilder.Entity("Cars.Model.Car", Sub(b)
                                                  b.[Property](Of Integer)("ID").ValueGeneratedOnAdd()
                                                  b.[Property](Of String)("Category").HasMaxLength(7)
                                                  b.[Property](Of Byte?)("Cyl")
                                                  b.[Property](Of Short?)("HP")
                                                  b.[Property](Of String)("Hyperlink").HasMaxLength(50)
                                                  b.[Property](Of Double?)("Liter")
                                                  b.[Property](Of Byte?)("MPG_City")
                                                  b.[Property](Of Byte?)("MPG_Highway")
                                                  b.[Property](Of String)("Model").HasMaxLength(50)
                                                  b.[Property](Of Decimal?)("Price").HasColumnType("money")
                                                  b.[Property](Of String)("Trademark").HasMaxLength(50)
                                                  b.[Property](Of String)("TransmissAutomatic").HasMaxLength(3)
                                                  b.[Property](Of Byte?)("TransmissSpeedCount")
                                                  b.HasKey("ID")
                                                  b.ToTable("Cars")
                                              End Sub)
        modelBuilder.Entity("Cars.Model.CarScheduling", Sub(b)
                                                            b.[Property](Of Integer)("ID").ValueGeneratedOnAdd()
                                                            b.[Property](Of Boolean)("AllDay")
                                                            b.[Property](Of Integer?)("CarId")
                                                            b.[Property](Of String)("ContactInfo")
                                                            b.[Property](Of String)("Description")
                                                            b.[Property](Of DateTime?)("EndTime")
                                                            b.[Property](Of Integer?)("EventType")
                                                            b.[Property](Of Integer?)("Label")
                                                            b.[Property](Of String)("Location").HasMaxLength(50)
                                                            b.[Property](Of Decimal?)("Price").HasColumnType("smallmoney")
                                                            b.[Property](Of String)("RecurrenceInfo")
                                                            b.[Property](Of String)("ReminderInfo")
                                                            b.[Property](Of DateTime?)("StartTime")
                                                            b.[Property](Of Integer?)("Status")
                                                            b.[Property](Of String)("Subject").HasMaxLength(50)
                                                            b.[Property](Of Integer?)("UserId")
                                                            b.HasKey("ID")
                                                            b.ToTable("CarScheduling")
                                                        End Sub)
    End Sub
End Class
