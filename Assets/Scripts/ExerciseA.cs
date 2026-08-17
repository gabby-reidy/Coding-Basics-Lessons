using UnityEngine;

public class ExerciseA : MonoBehaviour
{
    // Declaration of variables
    private int variableOne;
    private int variableTwo;
    private int variableThree;
    private int resultOne;
    private int resultTwo; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //initialize the 3 integer variables
        variableOne = 1;
        variableTwo = 2;
        variableThree = 3;
        //add the three integer values
        resultOne = variableOne + variableTwo + variableThree;
        //multiply the three integer values
        resultTwo = variableOne * variableTwo * variableThree;


        Debug.Log(variableOne + " + " + variableTwo + " + " + variableThree + " = " + resultOne);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(variableOne + " * " + variableTwo + " * " + variableThree + " = " + resultTwo);
    }
}
