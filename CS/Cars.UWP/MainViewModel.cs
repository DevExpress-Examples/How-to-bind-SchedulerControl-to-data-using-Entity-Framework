using Cars.Model;
using DevExpress.Mvvm;
using DevExpress.UI.Xaml.Scheduler;
using System.Collections.Generic;
using System.Linq;

namespace Cars.UWP {
    public class MainViewModel : ViewModelBase {


        CarsContext db;

        public MainViewModel() {
            db = new CarsContext();
            Cars = db.Cars.ToList();
            this.SaveChangesCommand = new DelegateCommand<CarScheduling>(SaveChanges);
            this.AppointmentAddedCommand = new DelegateCommand<CarScheduling>(AppointmentAdded);
            this.AppointmentRemovingCommand = new DelegateCommand<IEnumerable<CarScheduling>>(AppointmentRemoving);
            this.AppointmentRemovedCommand = new DelegateCommand<IEnumerable<CarScheduling>>(AppointmentRemoved);
            this.AppointmentUpdatingCommand = new DelegateCommand<CarScheduling>(AppointmentUpdating);
            Appointments = db.CarSchedulings.ToList();
        }

        protected IEnumerable<Car> cars;
        public IEnumerable<Car> Cars
        {
            get { return this.cars; }
            set { this.SetProperty(ref this.cars, value, "Cars"); }
        }


        protected IEnumerable<CarScheduling> appointments;
        public IEnumerable<CarScheduling> Appointments
        {
            get { return this.appointments; }
            set { this.SetProperty(ref this.appointments, value, "Appointments"); }
        }

        public DelegateCommand<CarScheduling> SaveChangesCommand { get; private set; }

        public DelegateCommand<CarScheduling> AppointmentAddedCommand { get; private set; }

        public DelegateCommand<IEnumerable<CarScheduling>> AppointmentRemovingCommand { get; private set; }
        public DelegateCommand<IEnumerable<CarScheduling>> AppointmentRemovedCommand { get; private set; }

        public DelegateCommand<CarScheduling> AppointmentUpdatingCommand { get; private set; }

        protected bool ProcessOccurranceChange = false;
        protected string RecurrenceRule = string.Empty;

        public void AppointmentUpdating(CarScheduling appointment)
        {
            if(appointment.EventType == (int)AppointmentType.Occurrence)
            {
                ProcessOccurranceChange = true;
            }

            if(appointment.EventType == (int)AppointmentType.Pattern)
            {
                RecurrenceRule = appointment.RecurrenceRule;
            }
        }

        public void AppointmentAdded(CarScheduling appointment)
        {
            db.Add(appointment);
            db.SaveChanges();
            Refresh();
        }

        public void AppointmentRemoving(IEnumerable<CarScheduling> appointments)
        {

            foreach (var item in appointments)
            {
                if(item.EventType != (int)AppointmentType.Occurrence)
                {
                    db.Remove(item);
                    if(item.EventType == (int)AppointmentType.Pattern)
                    {
                        RemoveOccurrances(item.PatternId);
                    }
                }                          
            }
                
            db.SaveChanges();
        }

        public void AppointmentRemoved(IEnumerable<CarScheduling> appointments) {

            foreach(var item in appointments)
            {
                if(item != null && item.EventType == (int)AppointmentType.DeletedOccurrence)
                {
                    db.Add(item);
                }
            }

            db.SaveChanges();
            Refresh();
        }


        void RemoveOccurrances(string patternId) {
            var occurrances = db.CarSchedulings.Where(c => c.PatternId == patternId
                        && (c.EventType == (int)AppointmentType.ChangedOccurrence || c.EventType == (int)AppointmentType.DeletedOccurrence)).ToList();
            db.RemoveRange(occurrances);
        }

        public void SaveChanges(CarScheduling appointment)
        {
            if(appointment != null && ProcessOccurranceChange)
            {
                if(appointment.EventType == (int)AppointmentType.ChangedOccurrence)
                {
                    db.Add(appointment);
                }
                ProcessOccurranceChange = false;
            }

            if(appointment.EventType == (int)AppointmentType.Pattern && appointment.RecurrenceRule != RecurrenceRule)
            {
                RemoveOccurrances(appointment.PatternId);
                RecurrenceRule = string.Empty;
            }

            db.SaveChanges();
            Refresh();
        }


        protected void Refresh() {
            this.Appointments = db.CarSchedulings.ToList();
        }
    }
}
