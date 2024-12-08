namespace FullStackProject.Domain
{
    public class Job : BaseDomainModel
    {
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public string? Requirements { get; set; }
        public int Salary {  get; set; }
        public string? Status { get; set; }
        public int EmployerID { get; set; }
        public int CategoryID { get; set; }
    }
}
