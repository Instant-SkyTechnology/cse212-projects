using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// Generates an array containing the first 'length' multiples of the given 'number'.
    /// Example: MultiplesOf(3, 5) returns {3, 6, 9, 12, 15}.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array to hold 'length' number of doubles
        // This array will store the multiples of the input 'number'
        double[] multiples = new double[length];

        // Step 2: Fill the array with multiples
        // Loop from 0 to length-1:
        //   At each index i, calculate the multiple as number * (i + 1)
        //   We use (i + 1) because the first multiple is 1 * number, not 0
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the completed array containing all multiples
        return multiples;
    }

    /// <summary>
    /// Rotates the given list 'data' to the right by 'amount' positions.
    /// The list is modified in-place. Example: 
    /// List {1,2,3,4,5,6,7,8,9} rotated by 3 becomes {7,8,9,1,2,3,4,5,6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Check if the rotation amount equals the list size
        // If so, the list remains unchanged and we can return immediately
        if (amount == data.Count) return;

        // Step 2: Extract the last 'amount' elements from the list
        // These elements will wrap around to the front when rotated
        List<int> endSlice = data.GetRange(data.Count - amount, amount);

        // Step 3: Remove these elements from the end of the list
        // This prevents duplication when we insert them at the front
        data.RemoveRange(data.Count - amount, amount);

        // Step 4: Insert the extracted elements at the beginning of the list
        // This effectively rotates the list to the right by 'amount'
        data.InsertRange(0, endSlice);

        // Step 5: The list is now rotated in-place as required
    }
}

