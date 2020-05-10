using ReviewManagement.Domain.Enums;

namespace ReviewManagement.App.Models
{
    public class PayloadInfo
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string Login { get; set; }

        public Role Role { get; set; }
    }
}
