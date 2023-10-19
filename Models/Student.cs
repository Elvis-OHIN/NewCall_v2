namespace Models
{
    public class Student
    {
        public int id { get; set;}
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string statut { get; set; }
        public Student(int id, string firstname, string lastname, string statut)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.statut = statut;
        }

    }
}
