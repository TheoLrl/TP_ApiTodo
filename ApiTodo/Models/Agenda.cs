public class Agenda{
    public int Id { get; set; }
    public string Name { get; set; }

    // One-to-many relationship with Todo
    public List<Todo> Todos { get; set; }
}