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
        // PLAN
        // 1. Create an array that can store the required number of values.
        // 2. Use a loop to go through each position in the array.
        // 3. For each position, multiply the starting number by
        //    the loop number + 1 to get the next multiple.
        // 4. Store the multiple in the array.
        // 5. After the loop is finished, return the completed array.

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
        // PLAN
        // 1. Find the place where the list should be split.
        //    The split point is data.Count - amount.
        // 2. Copy the values from the split point to the end
        //    of the list into a temporary list.
        //    These values will move to the front.
        // 3. Copy the values from the beginning of the list
        //    up to the split point into another temporary list.
        //    These values will move to the back.
        // 4. Clear the original list so it can be rebuilt.
        // 5. Add the last section of the list first.
        // 6. Add the beginning section after it.
        // 7. The list is now rotated to the right by the
        //    requested amount.

        int splitPoint = data.Count - amount;

        List<int> endPart = data.GetRange(splitPoint, amount);
        List<int> beginningPart = data.GetRange(0, splitPoint);

        data.Clear();

        data.AddRange(endPart);
        data.AddRange(beginningPart);
    }
}