namespace ClassLibrary
{
    public class Sequence
    {
        public static int Calculate(double[] array)
        {
            int n = array.Length;

            if (n == 0)
            {
                return 0;
            }
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0 && array[i + 1] < 0)
                    counter++;
                if (array[i] < 0 && array[i + 1] > 0)
                    counter++;

            }
            return counter;
        }
    }
}