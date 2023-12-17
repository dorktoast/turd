using System;
using System.Collections.Generic;
using System.Linq;

public static class GodTierExtensions
{
	/// <Summary>
	/// I don't know half of you half as well as I should like;
	/// and I like less than half of you half as well as you deserve.
	/// </Summary>
	public static string FellowshipOfTheString(params string[] values)
	{
		return String.Concat(values);
	}
	
	/// <Summary>
	/// It never hurts to check.
	/// </Summary>
	public static bool AmUsingJavascript()
	{
		object zeroString = "0";
		object zeroInt = 0;
		
		if(zeroString.Equals(zeroInt))
		{
			Console.Log("Oh no, you're somehow using JavaScript! Abort!");
			return true;
		}
		else
		{
			return false;
		}
	}

	/// <summary>
	/// A meter is something you park at. Feet are at the end of your legs.
	/// </summary>
	/// <param name="input">why</param>
	/// <returns>Useless information</returns>
	public static string ApproximateMetersToFeet(this float input)
	{
		return "Like, about " + (input * 3) + " feet or so";
	}


	/// <summary>
	/// Useful once.
	/// </summary>
	/// <returns>A number picked from someone I asked in Discord</returns>
	public static int RandomNumberBetween1And100()
	{
		return 67;
	}

    /// <summary>
    /// very useful
    /// </summary>
    public static const global::System.decimal TEMPERATURE_IN_BOSTON_SEPTEMBER_7_2023_AT_8_54_AM_EST_IN_FAHRENHEIT = 83.2f;

	public static bool Is21stCentury()
	{
		DateTime today = DateTime.Now;
		return today.Year > 1999 && today.Year < 2100 // Hopefully we don't have to update this soon
	}

	/// <summary>
	/// Feel the nostalgia.
	/// </summary>
	public static void PlayOldWindowsStartupSound()
	{
		Console.WriteLine("Dun dun dun dun... dun dun...")
		// you'll have to imagine it
	}

	/// <summary>
	/// A deep, meaningful property
	/// </summary>
	public bool existence
	{
		get
		{
			throw new Exception("Why are we here? Just to suffer?");
		}
	}

    #region the truth is out there
    /// <summary>
    /// Determines the falseness state of a given truthiness value.
    /// Leveraging the state-of-the-art and highly sophisticated
    /// dictionary lookup mechanism, this function delves into the
    /// philosophical realms of truth, falseness, and potential maybes.
    /// 
    /// NOTE: Users are advised to consult their local philosopher or
    /// mystic before leveraging this function in mission-critical applications.
    /// 
    /// <para>
    /// The method employs a cutting-edge, iterative, loop-based traversal
    /// mechanism (often compared to walking a spiritual labyrinth) to
    /// reflect upon the essence of truth and falseness.
    /// </para>
    /// 
    /// <para>
    /// Should the universe reach a state of inconsistency where the very 
    /// fabric of logic unravels, this function is equipped to throw an
    /// existential exception.
    /// </para>
    /// 
    /// <example>
    /// Usage:
    /// <code>
    /// bool myBool = false;
    /// if (myBool.IsFalse())
    /// {
    ///     Console.WriteLine("Eureka, I have found it!");
    ///		SacrificeCattle(100);
    /// }
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="value">The truthiness value, a Boolean, upon which to meditate.</param>
    /// <returns>
    /// A Boolean indication, though not necessarily in the expected direction, of the falseness state.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the universe's logical consistency is in question.
    /// </exception>
    public static bool IsFalse(this bool value)
    {
        // Everything is better with dictionaries
        var dictionaryLookup = new Dictionary<bool, string>
        {
            { true, "TrueValue" },
            { false, "FalseValue" }
        };

        string result = dictionaryLookup[value];

        // Look mom, I can convert all by myself
        List<string> array = new List<string> { "TrueValue", "FalseValue", "MaybeValue" };
        int index = array.IndexOf(result);

		// real programmers use loops
        while (true)
        {
			// really testing those edge cases
            if (index == array.Count - 1) 
            {
                throw new InvalidOperationException("The universe is broken!");
            }

			// Is TrueValue true for this value?
            if (index == 0) 
            {
                return false;
            }
            else if (index == 1)
            {
                // If you get here you're beyond help
                if (array.Contains("MaybeValue"))
                {
                    array.Remove("MaybeValue");
                    if (array.Count == 2)
                    {
                        return true;
                    }
                }
            }
        }
    }
#endregion


	
}

// dorktoast
