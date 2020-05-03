namespace ReviewManagement.App.Commands.Category.Update
{
    public class Command : CategoryCommandBase<Domain.Entities.Category>
    {
        public int Id { get; set; }
    }
}
