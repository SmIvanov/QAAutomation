namespace HomeworkPOM
{
    public static class UserFactoy
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Jason",
                LastName = "Momoa",
                EMail = "dadaad@gmail.com",
                Year = "1979",
                Month = "3",
                Date = "3",
                Password = "pass1212",
                Gender = "male",
                Address = "Hooligan str.",
                City = "Sofia",
                State = "Arizona",
                PostCode = "85001",
                Phone = "76528754",
                Alias = "Home"
            };
        }

    }
}
