using UnityEngine;

public class ExerciseC : MonoBehaviour
{
    // Declaration of Variables
    float numberOne = 2.222222f;
    float numberTwo = 3.333333f;
    float numberThree = 4.444444f;
    float resultOne;

    double numberFour = 5.555555555555d;
    double numberFive = 6.666666666666d;
    double resultTwo;

    decimal numberSix = 8.88888888888888888888888888888m;
    decimal numberSeven = 9.99999999999999999999999999999m;
    decimal resultThree;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        resultOne = numberOne * numberTwo * numberThree;
        //Debug.Log(resultOne);

        resultTwo = numberFour / numberFive;
        //Debug.Log(resultTwo);

        resultThree = numberSix + numberSeven;
        //Debug.Log(resultThree);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(numberOne + " * " + numberTwo + " * " + numberThree + " = " + resultOne + ".");
        Debug.Log(numberFour + " / " + numberFive + " = " + resultTwo + ".");
        Debug.Log(numberSix + " + " + numberSeven + " = " + resultThree + ".");
    }
}
