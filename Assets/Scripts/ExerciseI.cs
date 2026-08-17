using UnityEngine;

public class ExerciseI : MonoBehaviour
{
    // Declaration of Variables
    string[] letters = { "A", "E", "H", "M", "T", "Y", "F", "O", "C", "R", "B", "W", "I", "U" };
    //                    0    1    2    3    4    5    6    7    8    9    10   11   12   13
    float[] numbers = new float[5];
    string starWarsSentence;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numbers[0] = 3.14f;
        numbers[1] = 7.77f;
        numbers[2] = 2.56f;
        numbers[3] = 10.78f;
        numbers[4] = 9.88f;

    }

    // Update is called once per frame
    void Update()
    {
        KeyControls();
    }

    void KeyControls()
    {
        if (Input.GetMouseButtonDown(1))
        {
            starWarsSentence = OutputTypeFunction();
            DisplayToConsole(starWarsSentence);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            DisplayToConsole("Floatnumbers from lowest to highest are: " + numbers[2] + ", " + numbers[0] + ", "
                + numbers[1] + ", " + numbers[4] + ", " + numbers[3] + ".");
        }
    }

    string OutputTypeFunction()
    {
        return letters[3] + letters[0] + letters[5] + " " + letters[4] + letters[2] + letters[1] + " " +
            letters[6] + letters[7] + letters[9] + letters[8] + letters[1] + " " + letters[10] + letters[1] +
            " " + letters[11] + letters[12] + letters[4] + letters[2] + " " + letters[5] + letters[7] + letters[13] + ".";
    }

    void DisplayToConsole(string sentence)
    {
        Debug.Log(sentence);
    }
}
