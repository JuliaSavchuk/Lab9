namespace Lab9
{
    public struct Birthday
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Birthday(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void ShowBirthday()
        {
            Console.WriteLine($"Birthday: {Day}.{Month}.{Year}");
        }

        public DayOfWeek DayOfWeekOfBirth()
        {
            //DayOfWeek: Це перерахування, яке представляє день тижня.
            return new DateTime(Year, Month, Day).DayOfWeek;
        }
        public DayOfWeek DayOfWeekInYear(int targetYear)
        {
            return new DateTime(targetYear, Month, Day).DayOfWeek;
        }

        public int DaysUntilBirthday()
        {
            //DateTime.Today: Це властивість, яка повертає поточну дату і час в локальному часовому поясі.
            DateTime today = DateTime.Today;
            DateTime birthdayThisYear = new DateTime(today.Year, Month, Day);
            if (today > birthdayThisYear)
                birthdayThisYear = birthdayThisYear.AddYears(1); // Додаємо рік, якщо день народження вже минув у цьому році
            return (birthdayThisYear - today).Days;
        }
    }
}
