using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Models
{
    public class Equipment : EquipmentBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public Engine? Engine { get; set; }
        public Chassis? Chassis { get; set; }
        public Transmission? Transmission { get; set; }
        public ICollection<Part> Parts { get; set; } = new List<Part>();
        public override ICollection<Note> Notes { get; set; } = new List<Note>();
        public Location? Location { get; set; }
        public int LocationId { get; set; }
        public ICollection<Worker> Workers { get; set; } = new List<Worker>();
        public User? User { get; set; }
        public int UserId { get; set; }

        public Equipment(string name, string? description, string? type, Engine? engine, Chassis? chassis, Transmission? transmission, ICollection<Part> parts, ICollection<Note> notes, ICollection<Worker> workers)
        {
            Name = name;
            Description = description;
            Type = type;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Parts = parts;
            Notes = notes;
            Workers = workers;
        }

        public Equipment()
        {
        }
    }
}
