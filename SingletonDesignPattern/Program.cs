namespace SingletonDesignPattern
{
    class Program
    {
        /// <summary>
        /// Branching url https://github.com/firstcontributions/first-contributions/blob/master/github-windows-vs2017-tutorial.md
        /// https://stackoverflow.com/questions/42217847/how-do-i-add-an-existing-solution-to-github-from-visual-studio-2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("Ravi");
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("Chandra");
        }
    }
}
