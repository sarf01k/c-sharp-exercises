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
                maxSequenceList = [ start ];
                if (i != elements.Length - 1)
                {
                    for (int j = i + 1; j < elements.Length; j++)
                    {
                        if (elements[j] > start)
                            maxSequenceList.Add(elements[j]);
                    }                                                            
                    len = (byte)maxSequenceList.Count;
                }
                
                if (len > bestLen)
                {
                    bestLen = len;
                    maxSequence = maxSequenceList.Distinct().ToArray();
                }
            }

            byte biggest = maxSequence.Max();
            Array.Resize(ref maxSequence, Array.IndexOf(maxSequence, biggest) + 1);

            //
            for (int k = 0; k < maxSequence.Length; k++)
            {
                Console.Write(maxSequence[k]);
            }
            Console.WriteLine();
            //

            maxSequenceList = maxSequence.ToList();
            for (int i = 1; i < maxSequenceList.Count - 1; i++)
            {
                if (maxSequenceList[i] > maxSequenceList[i+1] && maxSequenceList[i] > maxSequenceList[i-1] || maxSequenceList[i] < maxSequenceList[i+1] && maxSequenceList[i] < maxSequenceList[i-1])
                {
                    maxSequenceList.Remove(maxSequenceList[i]);
                }
            }

            for (int k = 0; k < maxSequenceList.Count; k++)
            {
                Console.Write(maxSequenceList[k]);
            }
        }
    }
}