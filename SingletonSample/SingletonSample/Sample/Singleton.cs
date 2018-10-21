public sealed class Singleton
{
    public int counter = 0;
    private static volatile Singleton instance = null;
    private static readonly object padlock = new object();

    private Singleton() {

    }

    public static string IncrementCounter()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                if (instance == null)
                    instance = new Singleton();
            }
        }
        return (instance.counter++).ToString();
    }
}