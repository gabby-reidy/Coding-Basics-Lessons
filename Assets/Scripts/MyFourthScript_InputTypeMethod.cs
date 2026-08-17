using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UIElements;

public class MyFourthScript_InputTypeMethod : MonoBehaviour
{
    // Declaration of Variables
    string heroA;
    string heroB;
    //string heroC;
    //string heroD;

    string fiendA;
    string fiendB;

    string allHeroes;
    string allFiends;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        heroA = "<color=magenta>Daisy</color>";
        heroB = "<color=yellow>Peach</color>";
        //heroC = "Mario";
        //heroD = "Luigi";

        fiendA = "<color=orange>Wario</color>";
        fiendB = "<color=red>Bowser</color>";

        //Debug.Log(heroA + heroB + fiendA + fiendB);
    }

    // Update is called once per frame
    void Update()
    {
        ConcatonateHeroes(heroA, heroB);
        ConcatonateFiends(fiendA, fiendB);
   
        DisplayToConsole(allHeroes, allFiends); 
    }

    void ConcatonateHeroes(string parameterA, string parameterB)
    {
        allHeroes = parameterA + " and " + parameterB;
    }

    void ConcatonateFiends(string parameterA, string parameterB)
    {
        allFiends = parameterA + " and " + parameterB;
    }

    void DisplayToConsole(string text1, string text2)
    {
        Debug.Log(text1 + " are best friends.");
        Debug.Log(text2 + " are just in love with " + text1);
    }
}
