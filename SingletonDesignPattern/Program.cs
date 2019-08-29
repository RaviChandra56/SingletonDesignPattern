namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("Ravi");
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("Chandra");
        }
    }
}
