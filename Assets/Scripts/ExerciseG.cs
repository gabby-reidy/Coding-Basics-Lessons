using UnityEngine;

// Exercise G: Logical Operators
// Declare and assign 4 string variables of your favorite video game characters (color-coded).
//
// Pressing the 1-4 number key or equivalent 1-4 keypad key have it display the videogame character name.
//
// Pressing the left Shift and A key displays all character names (separated by a comma).

public class ExerciseG : MonoBehaviour
{
    //Declaration of Variables
    string characterA = "<color=blue>Shadowheart</color>";
    string characterB = "<color=magenta>Kirby</color>";
    string characterC = "<color=yellow>Isabelle</color>";
    string characterD = "<color=cyan>Daisy</color>";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        KeyPress();
    }

    void KeyPress()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(characterA);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(characterB);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(characterC);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log(characterD);
        }
        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log(characterA + ", " + characterB + ", " + characterC + ", " + characterD);
        }
    }
}
