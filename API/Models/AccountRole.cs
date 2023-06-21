namespace API.Models
{
    public class AccountRole
    {
        public Guid Guid { get; set; }
        public Guid AccountGuid { get; set; }
        public Guid RoleGuid { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }

    }
}
