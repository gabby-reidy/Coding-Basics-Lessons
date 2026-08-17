using UnityEngine;

public class MySeventhScript_Operators : MonoBehaviour
{
    // Declaration of Variables
    string firstName = "Gabby";
    string lastName = "Reidy";
    bool pressZKey = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        KeyPress();
    }

    // This Function handles keyboard button presses.
    void KeyPress()
    {
        if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.F1))
        {
            Debug.Log("My first name is " + firstName + ".");
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.F2))
        {
            Debug.Log("My last name is " + lastName + ".");
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            // The following 'if' logic checks if the pressZKey==false.
            if (!pressZKey)
            {
                Debug.Log("<color=red>The Portal has been toggled OFF!</color>");
            }
            // The following 'else' logic checks if the pressZkey==true.
            else
            {
                Debug.Log("<color=green>The Portal has been toggled ON!</color>");
            }

            // The following changes the boolean variable pressZKey to the opposite (from False to True and vice versa).
            pressZKey = !pressZKey;
        }
    }
}

