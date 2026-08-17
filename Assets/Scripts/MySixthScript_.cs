using UnityEditor.UI;
using UnityEngine;

public class MySixthScript_ : MonoBehaviour
{
    // Declaration of Variables
    int intelligence;
    string letter;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        letter = "Please press W A S D key.";
    }

    // Update is called once per frame
    void Update()
    {
        ButtonPressCheck();
    }

    void ButtonPressCheck()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            intelligence = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            intelligence = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            intelligence = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            intelligence = 4;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            intelligence = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            intelligence = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            intelligence = 7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            intelligence = 8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            intelligence = 9;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            intelligence = 10;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            letter = "W";
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            letter = "A";
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            letter = "S";
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            letter = "D";
        }
        else if (Input.GetMouseButtonDown(0))
        {
            letter = "<color=yellow>Left mouse button has been pressed.</color>";
        }
        else if (Input.GetMouseButtonUp(1))
        {
            letter = "<color=green>Right mouse button has been released.</color>";
        }
        else if (Input.GetMouseButtonDown(2))
        {
            letter = "<color=orange>Middle mouse button has been pressed.</color>";
        }
        else
        {
            Debug.Log("No key has been pressed.");
        }

        Debug.Log(intelligence);
        Debug.Log(letter);
        Greet();
    }

    // This function demonstrates the switch-case statement -- good for checking particular values
    void Greet()
    {
        switch(intelligence)
        {
            case 5:
                Debug.Log("Hello there!");
                break;
            case 4:
                Debug.Log("What do you want?");
                break;
            case 3:
                Debug.Log("Okay!");
                break;
            case 2:
                Debug.Log("I don't know.");
                break;
            case 1:
                Debug.Log("Who knows?");
                break;
            default:
                Debug.Log("No number 1-5 has been pressed.");
                break;
        }
    }
}
