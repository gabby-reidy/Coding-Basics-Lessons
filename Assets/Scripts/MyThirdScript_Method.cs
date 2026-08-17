using UnityEngine;

public class MyThirdScript_Method : MonoBehaviour
{
    // Declaration of Variables
    string food1;
    string food2;
    string food3;

    string fruits;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food1 = "<color=red>Apples</color>";
        food2 = "<color=orange>Oranges</color>";
        food3 = "<color=yellow>Pineapples</color>";
    }

    // Update is called once per frame
    void Update()
    {
        ConcatonateFruits();
        DisplayToConsole();
    }

    void ConcatonateFruits()
    {
        fruits = food1 + ", " + food2 + " and " + food3;
    }

    void DisplayToConsole()
    {
        Debug.Log("My favorite fruits are: " + fruits + ".");
    }
}
