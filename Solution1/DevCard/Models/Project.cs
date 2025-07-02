namespace DevCard.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }

        public Project(long id, string name, string description, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Client = client;
        }
    }
}