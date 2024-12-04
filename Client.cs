namespace lab10
{
    public class Client
    {
        private int ID;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string CreditCard { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string lastName, string firstName, string middleName, string creditCard, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            CreditCard = creditCard;
            PhoneNumber = phoneNumber;
        }

        public void CreateTask()
        {
            throw new System.NotImplementedException();
        }

        public string GetFIO()
        {
            return LastName + " " + FirstName + " " + MiddleName;
        }
    }
}
