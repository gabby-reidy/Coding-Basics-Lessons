using UnityEngine;

public class ExerciseB : MonoBehaviour
{
    // Declaration of Variables
    string firstName;
    string lastName;

    string showA;
    string showB;
    string showC;

    string shows;
    string myName;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstName = "Gabby";
        lastName = "Reidy";

        showA = "Gilmore Girls";
        showB = "Breaking Bad";
        showC = "Mad Men";

        ConcatonateName();
        Debug.Log("My name is " + firstName + " " + lastName + ".");
        
    }

    // Update is called once per frame
    void Update()
    {
        ConcatonateShows();
        Debug.Log("My favorite TV shows are " + showA + ", " + showB + " and " + showC + ".");
    }

    void ConcatonateName()
    {
        myName = firstName + " " + lastName;
    }

    void ConcatonateShows()
    {
        shows = showA + " " + showB + " " + showC;
    }
}
