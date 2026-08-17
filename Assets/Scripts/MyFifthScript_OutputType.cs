using UnityEngine;

public class MyFifthScript_OutputType : MonoBehaviour
{
    // Declaration of Variables
    int intNumber1;
    int intNumber2;
    int intNumber3;

    int averageNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        intNumber1 = 33;
        intNumber2 = 66;
        intNumber3 = 99;
    }

    // Update is called once per frame
    void Update()
    {
        // Store return value from output type function in a variable
        averageNumber = CalculateAverageNumber(intNumber1, intNumber2, intNumber3);
        Debug.Log("The average number of " + intNumber1 + " + " + intNumber2 + " + " + intNumber3 + " = " + averageNumber);


        // Can avoid making a variable like above, by calling the int function directly in debug log (has to return a value)
        // Variables are good if re-suing, if its a one time use its better to just call directly

        // Use return value from output-type function immediately as an argument for a function
        Debug.Log("The average number of " + intNumber1 + " + " + intNumber2 + " + " + intNumber3 + " = " + CalculateAverageNumber(intNumber1, intNumber2, intNumber3));
    }


    // output type function example
    int CalculateAverageNumber(int x1, int x2, int x3)
    {
        int result;
        result = (x1 + x2 + x3) / 3;
        return result;
    }
}
