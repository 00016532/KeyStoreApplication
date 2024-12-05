namespace KeyStoreAPI.Models
{
    public class Key
    {
        public int KeyID { get; set; }
        public int UserID { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ExpiresAt { get; set; }

        public User User { get; set; }
    }
}

//00016532
