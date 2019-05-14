Imports Cars.Model
Imports DevExpress.Mvvm.UI
Imports DevExpress.UI.Xaml.Scheduler
Imports Windows.UI.Xaml.Markup

Public Class EventArgsConverter
    Inherits MarkupExtension
    Implements IEventArgsConverter

    Protected Overrides Function ProvideValue() As Object
        Return Me
    End Function

    Public Function Convert(ByVal sender As Object, ByVal args As Object) As Object Implements IEventArgsConverter.Convert
        If TypeOf args Is AppointmentAddedEventArgs Then
            Return (TryCast(args, AppointmentAddedEventArgs)).Appointments.FirstOrDefault().SourceObject
        End If

        If TypeOf args Is AppointmentUpdatingEventArgs Then
            Return (TryCast(args, AppointmentUpdatingEventArgs)).Appointments.FirstOrDefault().SourceObject
        End If

        If TypeOf args Is AppointmentUpdatedEventArgs Then
            Return (TryCast(args, AppointmentUpdatedEventArgs)).Appointments.FirstOrDefault().SourceObject
        End If

        If TypeOf args Is AppointmentRemovingEventArgs Then
            Return (TryCast(args, AppointmentRemovingEventArgs)).Appointments.[Select](Function(c) TryCast(c.SourceObject, CarScheduling)).ToList()
        End If

        If TypeOf args Is AppointmentRemovedEventArgs Then
            Return (TryCast(args, AppointmentRemovedEventArgs)).Appointments.[Select](Function(c) TryCast(c.SourceObject, CarScheduling)).ToList()
        End If

        Return Nothing
    End Function
End Class
