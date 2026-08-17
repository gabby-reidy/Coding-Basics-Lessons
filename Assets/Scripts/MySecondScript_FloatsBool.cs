using UnityEngine;

public class MySecondScript_FloatsBool : MonoBehaviour
{
    // Declaration of Variables
    private float floatNumber;       // accuracy (after the decimal point) of 6 digits
    private double doubleNumber;     // accuracy (after the decimnal point) of 12 digits
    private decimal decimalNumber;   // accuracy (after the decimal point) that can be represented by 32 bit

    bool boolean;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        floatNumber = 7.777777f;
        doubleNumber = 9.999999999999d;
        decimalNumber = 3.33333333333333333333333333333333m;

        boolean = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(floatNumber);
        Debug.Log(doubleNumber);
        Debug.Log(decimalNumber);

        Debug.Log(boolean);
    }
}
