namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        return Enumerable.SequenceEqual(xs, ys);
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs == null || xs.Length == 0)
        {
            throw new IndexOutOfRangeException("The array is null or empty.");
        }

        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs == null || xs.Length == 0)
        {
            throw new Exception("The array is null or empty.");
        }

        return xs[xs.Length - 1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        return (T)xs[xs.Length / 2];
    }

    public static void Reverse<T>(T[] xs)
    {
        Array.Reverse(xs);
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        if (xs == null || xs.Length == 0)
        {
            throw new ArgumentNullException(nameof(xs));
        }
        return xs.Count(x => EqualityComparer<T>.Default.Equals(x, element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}