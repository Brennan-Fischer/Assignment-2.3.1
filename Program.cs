namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter myWriter = new StreamWriter("C:\\MSSA-CCAD14\\sample.txt"))
                {
                    myWriter.WriteLine("Name: John Doe");
                    myWriter.WriteLine("Age: 30");
                    myWriter.WriteLine("Address: 5555 Road City State");

                }
                using (StreamReader myReader = new StreamReader("C:\\MSSA-CCAD14\\sample.txt"))
                {
                    string myLine = myReader.ReadLine();
                    while (myLine != null)
                    {
                        Console.WriteLine(myLine);
                        myLine = myReader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

    }
}
