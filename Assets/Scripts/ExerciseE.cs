using UnityEngine;

//Exercise E: Input-Type Method/Function using Parameters
// Create a new script.
// Declare 3 string variables for your favorite Fast Food Restaurants.
// Initialize the variables before the first frame is rendered respectively.
//   Color-code the Fast Food variables in different colors.
// Define a method that uses the string variables as parameters, concatenates
//   the following sentence and stores it in a global variable:
//   “My favorite Fast Food Restaurants are [restaurant 1], [restaurant 2] and [restaurant3].”
// Define a method passing in the global variables as argument to be displayed to the Console.
// At every frame rendered display the above sentence to the Console.

public class ExerciseE : MonoBehaviour
{
    // Declaration of Variables
    string fastFoodA;
    string fastFoodB;
    string fastFoodC;

    string allFoods;
    string fastFoodSentence;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fastFoodA = "<color=blue>Taco Bell</color>";
        fastFoodB = "<color=red>Burger King</color>";
        fastFoodC = "<color=yellow>Cava</color>";
    }

    // Update is called once per frame
    void Update()
    {
        ConcatonateFoods(fastFoodA, fastFoodB, fastFoodC);
        DisplayToConsole(fastFoodSentence);
       
    }

    void ConcatonateFoods(string ParameterA, string ParameterB, string ParameterC)
    {
        //allFoods = ParameterA + " , " + ParameterB + " and " + ParameterC;
        fastFoodSentence = "My favorite fast food restaurants are " + ParameterA + ", " + ParameterB + " and " + ParameterC + ".";

    }

    void DisplayToConsole(string sentence)
    {
        Debug.Log(sentence);
    }
}
