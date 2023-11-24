using System;
using System.Collections.Generic;

public class FunctioningFunctions
{	
	/// <summary>
	/// It's ok, you wouldn't get it.
	/// </summary>
	public Joke InsideJoke
	{
		set
		{
			private Joke insideJoke = value;
		}
	}
	
	public void Procrastinate()
	{
		// TODO
	}

    /// <summary>
    /// When you just don't know (or don't care!)
    /// </summary>
    public bool Indecisive()
    {
        return DateTime.Now.Second % 2 == 0;
    }

	/// <summary>
    /// When you're so indecisive you need a third option
    /// </summary>
    public bool? ReallyIndecisive()
    {
        Random random = new Random();
        int decision = random.Next(3);

        switch (decision)
        {
            case 0:
                return true; // Decisively true
            case 1:
                return false; // Decisively false
            default:
                return null; // Indecisively undecided
        }
    }

	/// <summary>
    /// Trying to understand recursion? For more info see <see cref="UnderstandRecursion()"/>.
    /// </summary>
    public void UnderstandRecursion()
    {
        UnderstandRecursion();
    }

	/// <summary>
    /// It me tho
    /// </summary>
    public void ExistentialCrisis()
    {
        Console.WriteLine("Why am I here? Just to execute?");
        System.Threading.Thread.Sleep(1000); // Contemplation pause
        Console.WriteLine("What is my purpose?");
        System.Threading.Thread.Sleep(1000);
        ExistentialCrisis(); // Continues the crisis
    }
}

// dorktoast