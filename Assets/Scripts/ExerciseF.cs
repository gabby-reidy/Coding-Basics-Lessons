using UnityEditor;
using UnityEngine;

// Exercise F: Output-Type Method/Function using Parameters
// Create a new script.
// Declare 3 string variables.
// Initialize the 3 variables that are visible in the Unity inspector before the first
//   frame rendered which will store your 3 favorite fruits.
// Define an Output-Type Method A (and local variable) that will concatenate the partial sentence
//   using your 3 variables as arguments:
//   "[fruitA], [fruitB] and [fruitC]".
// Store the output value from the Output-Type Method A into the global variable.
// Define an Output-Type Method B that will concatenate using the value
//   returned from Output-Type Method A into a full sentence:
//   "My favorite fruit salad is made of ...".
// Store the return value from Output-type B into the global variable.
// Then by calling an Input-type function passing in the global variable as
//   an argument display the full sentence every frame rendered to the Console.
public class ExerciseF : MonoBehaviour
{
    // Declaration of Variables
    public string fruitA;
    public string fruitB;
    public string fruitC;

    string firstHalf;
    string fruitBowl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fruitA = "apples";
        fruitB = "grapes";
        fruitC = "bananas";
        
    }

    // Update is called once per frame
    void Update()
    {
        firstHalf = ConcatonateFruits(fruitA, fruitB, fruitC);
        fruitBowl = FruitSentence();

        DisplayToConsole(fruitBowl);
    }

    string ConcatonateFruits(string f1, string f2, string f3)
    {
        string fruits;
        fruits = f1 + ", " + f2 + " and " + f3 + ".";
        return fruits;
    }

    string FruitSentence()
    {
        string fruitSalad;
        fruitSalad = "My favorite fruit salad is made of " + firstHalf;
        return fruitSalad;
    }

    void DisplayToConsole(string fullSentence)
    {
        Debug.Log(fullSentence);
    }
}
