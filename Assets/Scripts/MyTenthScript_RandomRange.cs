using UnityEngine;

public class MyTenthScript_RandomRange : MonoBehaviour
{
    // Declaration of Variables
    int randomInt;
    int rangeStart = 0;
    int rangeEnd = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PressKey();
    }

    void PressKey()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            randomInt = GetRandomNumber(rangeStart, rangeEnd);
            Debug.Log(randomInt);

            // or
            // Debug.Log(GetRandomNumber(rangeStart,rangeEnd));  < generally better to do it the other way so that the variable is stored

        }
    }

    //Output type method returning a random number 
    int GetRandomNumber (int number1, int number2)
    {
        int randomNumber = Random.Range(number1, number2);
        return randomNumber;
    }
}
