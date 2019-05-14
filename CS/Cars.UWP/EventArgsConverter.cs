using Cars.Model;
using DevExpress.Mvvm.UI;
using DevExpress.UI.Xaml.Scheduler;
using System.Linq;
using Windows.UI.Xaml.Markup;

namespace Cars.UWP {
    public class EventArgsConverter : MarkupExtension, IEventArgsConverter
    {

        protected override object ProvideValue()
        {
            return this;
        }

        public object Convert(object sender, object args)
        {
            if(args is AppointmentAddedEventArgs)
            {
                return (args as AppointmentAddedEventArgs).Appointments.FirstOrDefault().SourceObject;
            }

            if(args is AppointmentUpdatingEventArgs)
            {
                return (args as AppointmentUpdatingEventArgs).Appointments.FirstOrDefault().SourceObject;
            }

            if (args is AppointmentUpdatedEventArgs)
            {
                return (args as AppointmentUpdatedEventArgs).Appointments.FirstOrDefault().SourceObject;
            }

            if (args is AppointmentRemovingEventArgs)
            {
                return (args as AppointmentRemovingEventArgs).Appointments.Select(c => c.SourceObject as CarScheduling).ToList();
            }

            if(args is AppointmentRemovedEventArgs)
            {
                return (args as AppointmentRemovedEventArgs).Appointments.Select(c => c.SourceObject as CarScheduling).ToList();
            }

            return null;
        }
    }
}
