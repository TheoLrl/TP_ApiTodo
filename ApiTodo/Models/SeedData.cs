using Microsoft.EntityFrameworkCore;

public class SeedData
{

    public static void Init()
    {
        using (var context = new TodoContext())
        {

            Todo todo1 = new Todo
            {
                Task = "truc1",
                Completed = false,
                Deadline = DateTime.Parse("2024-10-16")
            };

            Todo todo2 = new Todo
            {
                Task = "truc2",
                Completed = true,
            };

            Todo todo3 = new Todo
            {
                Task = "truc3",
            };

            context.Todos.AddRange(
                todo1,
                todo2,
                todo3
            );
            context.SaveChanges();


        }
    }
}