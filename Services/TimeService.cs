namespace DI
{
    public class TimeService
    {
        public string GetTime() => System.DateTime.Now.ToString();
    }
}