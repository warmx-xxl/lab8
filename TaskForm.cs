namespace lab10
{
    public class TaskForm
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string CarName { get; set; }
        public string Email { get; set; }

        public TaskForm()
        {
            LastName = "";
            FirstName = "";
            MiddleName = "";
            CarName = "";
            Email = "";
        }

        public string About()
        {
            return $"{LastName} {FirstName} {MiddleName}, автомобиль: {CarName}, email: {Email}";
        }
    }
}
