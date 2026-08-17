using UnityEngine;

public class MyFirstScript_IntString_PrintDebugLog : MonoBehaviour
{
    //  Declaration of variables
    private int wholeNumber;
    private int wholeNumber2 = 70;
    public int wholeNumber3 = 7777;
    private string text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wholeNumber = 10;
        text = "My name is Gabby.";

        print(wholeNumber);
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(wholeNumber2);
        Debug.Log(wholeNumber3);

        Debug.Log(text + " " + "My lucky number is: " + wholeNumber2 + ".");

        Debug.Log("<color=red>The third number is </color>" + wholeNumber3 + ".");
    }
}
