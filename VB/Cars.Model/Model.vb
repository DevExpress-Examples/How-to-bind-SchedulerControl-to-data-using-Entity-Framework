Imports Microsoft.EntityFrameworkCore
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class CarsContext
    Inherits DbContext

    Public Overridable Property Cars As DbSet(Of Car)
    Public Overridable Property CarSchedulings As DbSet(Of CarScheduling)

    Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlite("Data Source=cars.db")
    End Sub
End Class

Partial Public Class Car
    Public Property ID As Integer
    <StringLength(50)>
    Public Property Trademark As String
    <StringLength(50)>
    Public Property Model As String
    Public Property HP As Short?
    Public Property Liter As Double?
    Public Property Cyl As Byte?
    Public Property TransmissSpeedCount As Byte?
    <StringLength(3)>
    Public Property TransmissAutomatic As String
    Public Property MPG_City As Byte?
    Public Property MPG_Highway As Byte?
    <StringLength(7)>
    Public Property Category As String
    <StringLength(50)>
    Public Property Hyperlink As String
    <Column(TypeName:="money")>
    Public Property Price As Decimal?
End Class

<Table("CarScheduling")>
Partial Public Class CarScheduling
    Public Property ID As Integer
    Public Property CarId As Integer?
    Public Property UserId As Integer?
    Public Property Status As Integer?
    <StringLength(50)>
    Public Property Subject As String
    Public Property Description As String
    Public Property Label As Integer?
    Public Property StartTime As DateTime?
    Public Property EndTime As DateTime?
    <StringLength(50)>
    Public Property Location As String
    Public Property AllDay As Boolean
    Public Property EventType As Integer
    Public Property PatternId As String
    Public Property RecurrenceRule As String
    Public Property RecurrenceIndex As Integer
    Public Property ReminderInfo As String
    <Column(TypeName:="smallmoney")>
    Public Property Price As Decimal?
    Public Property ContactInfo As String
End Class