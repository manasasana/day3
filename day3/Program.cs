public class Exceptionhand
{
    public void validateage(int age)
    {
        if (age < 18)
        {
            throw new underageException("You are underage");
        }

    }

    public static void Main(String[] args)
    {
        try
        {
            validateage(17);
        }
        catch (underageException e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            Console.WriteLine("code is resumed");
        }

    }

}
      
    public class underageException : Exception
    {
        public underageException(string msg);base(msg):
        {

        }
    }

class test
{
    public static void Main(String[] args)
    {
        show();
    }
    public static void show()
    {
        int[] arr = { 1, 2, 5, 8, 9, 6, 4, 10 };
        //Array.Sort(arr);
        Array.Reverse(arr);
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}