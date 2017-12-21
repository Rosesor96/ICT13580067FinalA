using System;
using SQLite;
namespace ICT13580067FinalA.Models
{
    public class Profile
    {
           [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        [MaxLength(200)]
        public String Name { get; set; }
        public String Last { get; set; }
        public String Add{ get; set; }
        public double Mail { get; set; }

        [NotNull]
        [MaxLength(200)]
        public String Sex { get; set; }
        public int Age { get; set; }
        public String Zone { get; set; }
        public int Tel { get; set; }
        public String Mar { get; set; }
        public int Child { get; set; }
        public int Income { get; set; }
    }
}
