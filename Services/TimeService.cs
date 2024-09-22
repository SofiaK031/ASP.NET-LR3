namespace LR3.Services
{
    public class TimeService : ITimeService
    {
        public string GetCurrentTimePeriod()
        {
            switch (DateTime.Now.Hour)
            {
                case >= 0 and < 6:
                    return "Зараз ніч";
                case >= 6 and < 12:
                    return "Зараз ранок";
                case >= 12 and < 18:
                    return "Зараз день";
                case >= 18 and <= 23:
                    return "Зараз вечір";
                default:
                    return "Виникла помилка під час визначення часу!";
            }
        }
    }
}
