public class Todo
{
    public int Id { get; set; }
    public string Task { get; set; }
    public bool Completed { get; set; }
    public DateTime? Deadline { get; set; }

    public int? AgendaId { get; set; }  // Nullable, as a Todo may not belong to an Agenda
    public Agenda Agenda { get; set; }
}