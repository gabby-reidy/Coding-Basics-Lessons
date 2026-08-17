using UnityEngine;

public class ExerciseD : MonoBehaviour
{
    // Declaration of Variables
    string movieA;
    string movieB;
    string movieC;

    int wholeA;
    int wholeB;
    int resultA;

    float floatA;
    float floatB;
    float resultB;

    double doubleA;
    double doubleB;
    double resultC;

    decimal decimalA;
    decimal decimalB;
    decimal resultD;

    bool boolA;
    bool boolB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movieA = "<color=red>Oldboy</color>";
        movieB = "<color=magenta>Pride and Prejudice</color>";
        movieC = "<color=blue>Videodrome</color>";

        wholeA = 5;
        wholeB = 10;
        //resultA = (wholeA + wholeB) * 100;

        floatA = 6.666666f;
        floatB = 7.777777f;
        //resultB = floatA + floatB;

        doubleA = 3.333333333333d;
        doubleB = 4.444444444444d;
        //resultC = doubleA + doubleB;

        decimalA = 2.2222222222222222222222222222m;
        decimalB = 8.8888888888888888888888888888m;
        //resultD = decimalA + decimalB;

        boolA = true;
        boolB = false;

        ConcatonateMovies();
    }

    // Update is called once per frame
    void Update()
    {
        ConcatonateMath();
    }

    void ConcatonateMovies()
    {
        Debug.Log("My favorite movies are " + movieA + ", " + movieB + ", and " + movieC + ".");
        Debug.Log("It is " + boolA + " I love the Barbie movie!");
        Debug.Log("It is " + boolB + " Bruce Lee will beat Chuck Norris!");
    }

    void ConcatonateMath()
    {
        resultA = (wholeA + wholeB) * 100;
        resultB = floatA + floatB;
        resultC = doubleA + doubleB;
        resultD = decimalA + decimalB;

        Debug.Log("(" + wholeA + " + " + wholeB + ")" + " * " + "100 = " + resultA + " damage.");
        Debug.Log(floatA + " + " + floatB + " = " + resultB + " jump height.");
        Debug.Log(doubleA + " + " + doubleB + " = " + resultC + " target accuracy.");
        Debug.Log(decimalA + " + " + decimalB + " = " + resultD + " spawn location.");
    }
}
