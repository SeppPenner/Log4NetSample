namespace Log4NetSample
{
    internal static class Program
    {
        private static readonly log4net.ILog Log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static void Main()
        {
            Log.Info("Application is working");
            Log.Error("New Error");
        }
    }
}