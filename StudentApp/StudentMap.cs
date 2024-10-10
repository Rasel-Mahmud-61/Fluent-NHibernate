using FluentNHibernate.Mapping;

namespace StudentApp
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Table("Student"); // Database table name
            Id(x => x.ID).GeneratedBy.Assigned(); // Mapping for the ID property
            Map(s => s.FirstName);
            Map(x => x.LastName);
        }
    }
}
