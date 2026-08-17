using Unity.VisualScripting;
using UnityEngine;

public class ExerciseH2 : MonoBehaviour
{
    int wholeA = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //LMB
        {
            DisplayToConsole(wholeA, CountUp5(wholeA));
            wholeA = CountUp5(wholeA);
        }
    }

    int CountUp5(int x)
    {
        for (int i = 0; i < 5; i++)
        {
            x++;
        }
        return x;
    }

    void DisplayToConsole(int n, int result)
    {
        Debug.Log("Your start number is " + n + ". Pressing the left mouse counts upwards 5 times to the new " + result + ".");

    }
}
