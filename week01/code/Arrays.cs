public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // First I need an array that can hold all of the multiples.
        // Then I can loop through each spot in the array.
        // Every time through the loop, multiply the number by
        // the loop position + 1 and store it in the array.
        // Finally, return the finished array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // My idea here is to split the list into two pieces.
        // The last part of the list will move to the front.
        // The beginning part will move to the back.
        //
        // Example:
        // {1,2,3,4,5,6,7,8,9} rotated by 3 becomes:
        // {7,8,9} + {1,2,3,4,5,6}

        int split = data.Count - amount;

        List<int> endPart = data.GetRange(split, amount);
        List<int> beginningPart = data.GetRange(0, split);

        data.Clear();

        data.AddRange(endPart);
        data.AddRange(beginningPart);
    }
}