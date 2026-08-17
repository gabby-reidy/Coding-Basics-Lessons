using UnityEngine;

public class MyNinthScript_Arrays : MonoBehaviour
{
    // Declaration of Variables
    string[] letter = { "A", "B", "D", "O", "Y" };
    float[] fNumbers = new float[5];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fNumbers[0] = 1.111111f;
        fNumbers[1] = 2.222222f;
        fNumbers[2] = 3.333333f;
        fNumbers[3] = 4.444444f;
        fNumbers[4] = 5.555555f;
    }

    // Update is called once per frame
    void Update()
    {
        KeyPress();
    }

    void KeyPress()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(letter[1] + letter[0] + letter[1] + letter[4] + " " + letter[4] + letter[3] + letter[2] + letter[0]);
        } 
        else if (Input.GetKeyDown(KeyCode.X))
        {
            //Debug.Log(fNumbers[0] + " " + fNumbers[1] + " " + fNumbers[2] + " " + fNumbers[3] + " " + fNumbers[4]);

            for (int i = 0; i <=4; i++)
            {
                Debug.Log(fNumbers[i]);
            }

            foreach (float i in  fNumbers)
            {
                Debug.Log(i);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log(fNumbers[4] + " " + fNumbers[3] + " " + fNumbers[2] + " " + fNumbers[1] + " " + fNumbers[0]);
        }
    }
}
