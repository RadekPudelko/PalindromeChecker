using System;
	
/**
	Console Application for checking if a given input is a palindrome.
	Response to IAmTimCorey youtube c# challenge @ https://www.youtube.com/watch?v=9PbSEsxh_yQ
	
	@author Radoslaw Pudelko
	@date 1/23/2019
*/
public class PalindromChecker
{	
	/**
		Prompts the user for an int, double or string to check if its a palindrome
	*/
	public static void Main()
	{	
		// Prompt the user for the item to check
		Console.WriteLine("Palindrome checker\n");
		Console.WriteLine("Enter a string, int or double: ");
		String input = Console.ReadLine();
		
		// Removes whitespace and any non alphanumeric chars
		String processedInput = removeSpecialChars(input.ToLower());
		
		// Reports results
		if(isPalindrome(processedInput)) {
			Console.WriteLine(input + " is a palindrome.");
		} else {
			Console.WriteLine(input + " is not a palindrome.");
		}
	}
	
	/** 
		Removes chars from the given string if they are not alphanumeric. Builds a string containing
		only chars which are alphamumeric
		@param input the string to process
		@return String the processed string
	*/
	public static String removeSpecialChars(String input)
	{
		char[] inArr = input.ToCharArray();
		String newString = "";
		// Go through each char and replace non letter/digits with whitespace
		for(int i = 0; i < inArr.Length; i++) {
			if(char.IsLetterOrDigit(inArr[i])) { // Add a valid char to the string
				newString += inArr[i];
			}
		}
		return newString;
	}
	
	/**
		Checks if a given string is a palindrome. Goes through halfway through the
		string and compares each corresponding char to see if they match.
		@param s the string to check
		@return true if the string is a palindrome, false otherwise
	*/
	public static bool isPalindrome(String s) 
	{
		char[] cArr = s.ToCharArray();
		
		// Go through half the string and check if chars match with the corresponding char in the other hald
		for( int i = 0; i < cArr.Length / 2; i++ ) {
			if(cArr[i] != cArr[cArr.Length - 1 - i]) { // Mismatch, not a palindrome
				return false;
			}
		}
		return true;
	}
}
