using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.Model {
    public partial class CarsContext : DbContext
    {
        
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarScheduling> CarSchedulings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cars.db");
        }
    }

    public partial class Car
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Trademark { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public short? HP { get; set; }

        public double? Liter { get; set; }

        public byte? Cyl { get; set; }

        public byte? TransmissSpeedCount { get; set; }

        [StringLength(3)]
        public string TransmissAutomatic { get; set; }

        public byte? MPG_City { get; set; }

        public byte? MPG_Highway { get; set; }
                          
        [StringLength(7)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Hyperlink { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }

    [Table("CarScheduling")]
    public partial class CarScheduling
    {
        public int ID { get; set; }

        public int? CarId { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        public string Description { get; set; }

        public int? Label { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public bool AllDay { get; set; }

        public int EventType { get; set; }

        public string PatternId { get; set; }

        public string RecurrenceRule { get; set; }

        public int RecurrenceIndex { get; set; }

        public string ReminderInfo { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Price { get; set; }

        public string ContactInfo { get; set; }
    }
}
