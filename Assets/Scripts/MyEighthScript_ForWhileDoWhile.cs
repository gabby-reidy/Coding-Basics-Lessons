using UnityEngine;

public class MyEighthScript_ForWhileDoWhile : MonoBehaviour
{
    // Declaration of Variables
    public int cupsInTheSink = 4;
    bool toContinue = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //For Loop example
        int n = 0;

        for (int i = 0; i < 10; i++)   // i++ is the same as i = i + 1
        {
            n++;                      // n++ is the same as n = n + 1
            Debug.Log("n value: " + n + " , " + "i value= " + i);
        }

        // While Loop example
        while (cupsInTheSink > 0)
        {
            Debug.Log(cupsInTheSink + " remaining Cups to wash!");
            cupsInTheSink--;
        }

        // Do While example
        do
        {
            Debug.Log("Hello");
        } while (toContinue == true);

        //Another Do While example
        int _number = 0;
        do
        {
            _number++;
            Debug.Log(_number);
        } while (_number < 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
