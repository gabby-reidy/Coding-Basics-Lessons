using System.Globalization;
using UnityEngine;

// Exercise H:  For, While, Do-While Loop
// Create a script:
// Create a whole-number variable that is visible in the inspector and assign it a value.
// Define a Method handling your input controls. Define individual Methods taking the
//   whole-number variable as argument in handling the task for each button/key press:
//      a. Pressing left mouse button displays the sentence below counting upwards 5 times using a
//          For-Loop.
//      b. Pressing right mouse button displays the sentence below counting downwards 3 times using a
//          While Loop.
//      c. Pressing space bar or center mouse button displays the sentence below counting upwards 7 times. 
// Create a Method passing in the whole-number value that will count upwards
//    using a For Loop (5 iterations).
// Create a Method passing in the whole-number value that will count downwards
//    using a While Loop (3 iterations).
// Create a Method passing in the whole-number value that will count upwards
//    using a Do-While Loop (7 iterations).

// Assign each string variable a sentence expression and to an unique input key.
// Based on the key press, have the respective sentence displayed in the console, e.g
//   ‘Your start number is [x]. Pressing [space bar] counts [up] [x] iterations to the [new x] number.

public class ExerciseH : MonoBehaviour
{
    // Declaration of Variables
    public int wholeA = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Your start number is " + wholeA + ". Press mouse button to increase or decrease the number.");
    }

    // Update is called once per frame
    void Update()
    {
        KeyPress();
    }

    void KeyPress()
    {
        if (Input.GetMouseButtonDown(0))  //LMB
        {
            ForLoopUp5Times(wholeA);
        }
        else if (Input.GetMouseButtonDown(1)) // RMB
        {
            WhileLoopDown3Times(wholeA);
        }
        else if (Input.GetMouseButtonDown(2) || Input.GetKeyDown(KeyCode.Space)) // MMB or Space
        {
            DoWhileLoopUp7Times(wholeA);
        }
    }

    void ForLoopUp5Times(int x)
    {
        for (int i = 0; i < 5; i++)
        {
            x++;
        }
        Debug.Log("Your start number is " + wholeA + ". Pressing the left mouse button counts upwards 5 times to the new number " + x + ".");
        wholeA = x;
    }

    void WhileLoopDown3Times(int x)
    {
        int counter = 3;
        while (counter > 0)
        {
            x--;
            counter--;
        }
        Debug.Log("Your start number is " + wholeA + ". Pressing the right mouse button counts down 3 times to the new number " + x + ".");
        wholeA = x;
    }

    void DoWhileLoopUp7Times(int x)
    {
        int counter = 0;
        do
        {
            x++;
            counter++;
        } while (counter < 7);
        Debug.Log("Your start number is " + wholeA + ". Pressing the center mouse button or space bar counts up 7 times to the new number " + x + ".");
        wholeA = x;
    }
}
