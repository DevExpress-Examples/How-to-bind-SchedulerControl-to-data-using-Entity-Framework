Imports Cars.Model
Imports DevExpress.Mvvm
Imports DevExpress.UI.Xaml.Scheduler

Public Class MainViewModel
    Inherits ViewModelBase

    Private db As CarsContext

    Public Sub New()
        db = New CarsContext()
        _cars = db.Cars.ToList()
        Me.SaveChangesCommand = New DelegateCommand(Of CarScheduling)(AddressOf SaveChanges)
        Me.AppointmentAddedCommand = New DelegateCommand(Of CarScheduling)(AddressOf AppointmentAdded)
        Me.AppointmentRemovingCommand = New DelegateCommand(Of IEnumerable(Of CarScheduling))(AddressOf AppointmentRemoving)
        Me.AppointmentRemovedCommand = New DelegateCommand(Of IEnumerable(Of CarScheduling))(AddressOf AppointmentRemoved)
        Me.AppointmentUpdatingCommand = New DelegateCommand(Of CarScheduling)(AddressOf AppointmentUpdating)
        appointments = db.CarSchedulings.ToList()
    End Sub

    Protected _cars As IEnumerable(Of Car)

    Public Property Cars As IEnumerable(Of Car)
        Get
            Return Me._cars
        End Get
        Set(ByVal value As IEnumerable(Of Car))
            Me.SetProperty(Me._cars, value, "Cars")
        End Set
    End Property

    Protected _appointments As IEnumerable(Of CarScheduling)

    Public Property Appointments As IEnumerable(Of CarScheduling)
        Get
            Return Me._appointments
        End Get
        Set(ByVal value As IEnumerable(Of CarScheduling))
            Me.SetProperty(Me._appointments, value, "Appointments")
        End Set
    End Property

    Public Property SaveChangesCommand As DelegateCommand(Of CarScheduling)
    Public Property AppointmentAddedCommand As DelegateCommand(Of CarScheduling)
    Public Property AppointmentRemovingCommand As DelegateCommand(Of IEnumerable(Of CarScheduling))
    Public Property AppointmentRemovedCommand As DelegateCommand(Of IEnumerable(Of CarScheduling))
    Public Property AppointmentUpdatingCommand As DelegateCommand(Of CarScheduling)
    Protected ProcessOccurranceChange As Boolean = False
    Protected RecurrenceRule As String = String.Empty

    Public Sub AppointmentUpdating(ByVal appointment As CarScheduling)
        If appointment.EventType = CInt(AppointmentType.Occurrence) Then
            ProcessOccurranceChange = True
        End If

        If appointment.EventType = CInt(AppointmentType.Pattern) Then
            RecurrenceRule = appointment.RecurrenceRule
        End If
    End Sub

    Public Sub AppointmentAdded(ByVal appointment As CarScheduling)
        db.Add(appointment)
        db.SaveChanges()
        Refresh()
    End Sub

    Public Sub AppointmentRemoving(ByVal appointments As IEnumerable(Of CarScheduling))
        For Each item In appointments

            If item.EventType <> CInt(AppointmentType.Occurrence) Then
                db.Remove(item)

                If item.EventType = CInt(AppointmentType.Pattern) Then
                    RemoveOccurrances(item.PatternId)
                End If
            End If
        Next

        db.SaveChanges()
    End Sub

    Public Sub AppointmentRemoved(ByVal appointments As IEnumerable(Of CarScheduling))
        For Each item In appointments

            If item IsNot Nothing AndAlso item.EventType = CInt(AppointmentType.DeletedOccurrence) Then
                db.Add(item)
            End If
        Next

        db.SaveChanges()
        Refresh()
    End Sub

    Private Sub RemoveOccurrances(ByVal patternId As String)
        Dim occurrances = db.CarSchedulings.Where(Function(c) c.PatternId = patternId AndAlso (c.EventType = CInt(AppointmentType.ChangedOccurrence) OrElse c.EventType = CInt(AppointmentType.DeletedOccurrence))).ToList()
        db.RemoveRange(occurrances)
    End Sub

    Public Sub SaveChanges(ByVal appointment As CarScheduling)
        If appointment IsNot Nothing AndAlso ProcessOccurranceChange Then

            If appointment.EventType = CInt(AppointmentType.ChangedOccurrence) Then
                db.Add(appointment)
            End If

            ProcessOccurranceChange = False
        End If

        If appointment.EventType = CInt(AppointmentType.Pattern) AndAlso appointment.RecurrenceRule <> RecurrenceRule Then
            RemoveOccurrances(appointment.PatternId)
            RecurrenceRule = String.Empty
        End If

        db.SaveChanges()
        Refresh()
    End Sub

    Protected Sub Refresh()
        Me.appointments = db.CarSchedulings.ToList()
    End Sub
End Class
