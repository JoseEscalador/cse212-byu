

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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array to be populated        
        double[] multiples = new double[length];
        // Create a for loop to iterate the multipliers
        for (int i = 0; i != length; i++)
        {
            // populate the array with the results
            multiples[i] = (i + 1) * number;
        }
        // get the resulting array
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // create a second list to work with
        List<int> data2 = new(data.Count);
        // create a start variable to get the first part
        int start = data.Count - amount;
        // get the first part with getRange before the second
        data2.AddRange(data.GetRange(start, amount));
        // get the second part
        data2.AddRange(data.GetRange(0, start));
        // clear data to repopulate it
        data.Clear();
        // repopulate data
        data.AddRange(data2);
    }
}
