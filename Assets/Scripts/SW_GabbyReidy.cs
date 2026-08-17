using System.ComponentModel.Design;
using UnityEngine;

public class SW_GabbyReidy : MonoBehaviour
{
    // Declaration of Variables
    string[] firstName = { "G", "A", "B", "B", "Y" };
    string[] lastName = { "R", "E", "I", "D", "Y" };
    string[] maidenName = { "S", "H", "I", "E", "L", "D", "S" };
    string[] birthPlace = { "M", "A", "C", "O", "N" };

    string[] jawaNumbers = new string[10];

    string[] jawaWords = { "Ashuna", "Baba", "Chikua", "Dooka", "Eyeta", "Gomjam", "Hazamuzee", "Ibana", 
        "Jaw k'osa", "Kiluyak", "Lopima", "M'nuta", "Nyeta", "Ogo", "Perupa", "Rubac", "Shootogawa",
        "Taa baa", "Utinni", "Vapoosza", "Wass", "Yahtah" };

    string jediFirst;
    string jediLast;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jawaNumbers[0] = "Po";
        jawaNumbers[1] = "Ko";
        jawaNumbers[2] = "Kyo";
        jawaNumbers[3] = "Yo";
        jawaNumbers[4] = "Dyo";
        jawaNumbers[5] = "Lyo";
        jawaNumbers[6] = " ";
        jawaNumbers[7] = "Ho";
        jawaNumbers[8] = "To";
        jawaNumbers[9] = "Kisewa";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            JediFirstName(lastName[0], lastName[1], lastName[2], firstName[0], firstName[1]);
            JediLastName(maidenName[0], maidenName[1], maidenName[2], birthPlace[0], birthPlace[1], birthPlace[2]);
            Debug.Log(jediFirst + " " + jediLast);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            JediFirstName(firstName[0], firstName[1], firstName[2], lastName[0], lastName[1]);
            JediLastName(birthPlace[0], birthPlace[1], birthPlace[2], maidenName[0], maidenName[1], maidenName[2]);
            Debug.Log(jediFirst + " " + jediLast);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) || (Input.GetKeyDown(KeyCode.Keypad1)))
        {
            DisplayToConsole(jawaNumbers[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || (Input.GetKeyDown(KeyCode.Keypad2)))
        {
            DisplayToConsole(jawaNumbers[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || (Input.GetKeyDown(KeyCode.Keypad3)))
        {
            DisplayToConsole(jawaNumbers[2]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || (Input.GetKeyDown(KeyCode.Keypad4)))
        {
            DisplayToConsole(jawaNumbers[3]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || (Input.GetKeyDown(KeyCode.Keypad5)))
        {
            DisplayToConsole(jawaNumbers[4]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || (Input.GetKeyDown(KeyCode.Keypad6)))
        {
            DisplayToConsole(jawaNumbers[5]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) || (Input.GetKeyDown(KeyCode.Keypad7)))
        {
            DisplayToConsole(jawaNumbers[6]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) || (Input.GetKeyDown(KeyCode.Keypad8)))
        {
            DisplayToConsole(jawaNumbers[7]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) || (Input.GetKeyDown(KeyCode.Keypad9)))
        {
            DisplayToConsole(jawaNumbers[8]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0) || (Input.GetKeyDown(KeyCode.Keypad0)))
        {
            DisplayToConsole(jawaNumbers[9]);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ThreeRandomWords(); 
        }
    }

    // output type method to concatenate jedi first name
    string JediFirstName(string a, string b, string c, string d, string e)
    {
        jediFirst = a + b + c + d + e;
        return jediFirst;
    }

    //  output type method to concatenate jedi last name
    
    string JediLastName(string a, string b, string c, string d, string e, string f)
    {
        jediLast = a + b + c + d + e + f;
        return jediLast;
    }

    void DisplayToConsole(string a)
    {
        Debug.Log(a);
    }

    void ThreeRandomWords()
    {
        int wordA = Random.Range(0, jawaWords.Length);
        int wordB = Random.Range(0, jawaWords.Length);
        int wordC = Random.Range(0, jawaWords.Length);
        Debug.Log(jawaWords[wordA] + " " + jawaWords[wordB] + " " + jawaWords[wordC]);
    }
}
