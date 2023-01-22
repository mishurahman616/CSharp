namespace AccessModifer
{
    class Program:Class1
    {
        
        private static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.privateProtected);
        }
    }
    class Class1
    {
        private protected int privateProtected = 404;
        public void ShowClass1Info(string[] args)
        {
            Console.WriteLine(privateProtected);
        }
    }



}
