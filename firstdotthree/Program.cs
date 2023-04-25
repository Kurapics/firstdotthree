internal class Program
{

    private static void Main(string[] args)
    {
        double sum = 0;
        for (int i = 0; i < 12; i ++)
        {
            sum += ball_volume(10 + i * 0.5);
        }
        double ball_volume(double d)
        {
            return (4 * Math.PI / 3) * d * d * d;
        }
        Console.WriteLine(sum);
    }
}