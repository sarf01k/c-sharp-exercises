namespace IncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] elements = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };

            byte[] maxSequence = new byte[elements.Length];
            var maxSequenceList = new List<byte>();

            byte start = elements[0];
            byte len = 1;
            byte bestLen = len;

            for (int i = 0; i < elements.Length; i++)
            {
                start = elements[i];
                if (i != elements.Length - 1)
                {
                    for (int j = i + 1; j < elements.Length; j++)
                    {
                        if (elements[j] > start)
                        {
                            maxSequenceList.Append(elements[j]);
                            if (maxSequenceList.Count > 0)
                                Console.Write(maxSequenceList[j-1]);
                        }
                    }
                    len = (byte)maxSequenceList.Count;
                }

                for (int k = 0; k < maxSequenceList.Count; k++)
                {
                    Console.Write(maxSequenceList[i]);
                }

                // if (len > bestLen)
            }
        }
    }
}