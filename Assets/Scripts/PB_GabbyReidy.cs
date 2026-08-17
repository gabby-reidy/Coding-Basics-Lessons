using UnityEngine;
using UnityEngine.UIElements;

public class PB_GabbyReidy : MonoBehaviour
{
    // Declaration of Variables
    string pokemonA;
    string pokemonB;
    string pokemonC;

    string battleMessage;
    string statsA;
    string statsB;
    string statsC;

    int combatPowerA;
    int combatPowerB;
    int combatPowerC;

    float weightA;
    float weightB;
    float weightC;

    float heightA;
    float heightB;
    float heightC;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pokemonA = "<color=cyan>Jirachi</color>";
        pokemonB = "<color=yellow>Ampharos</color>";
        pokemonC = "<color=orange>Teddiursa</color>";

        combatPowerA = 2999;
        combatPowerB = 2333;
        combatPowerC = 1444;

        weightA = 101.0000002f;
        weightB = 277.007777f;
        weightC = 166.666666f;

        heightA = 1.555555f;
        heightB = 2.599999f;
        heightC = 1.666666f;

    }

    // Update is called once per frame
    void Update()
    {
        ReadyForBattle();
        Stats();

        // 16
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayToConsole(battleMessage);
        }

        // 17
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DisplayToConsole(statsA);
            DisplayToConsole(statsB);
            DisplayToConsole(statsC);
        }
    }

    // 9
    string ConcatenatePokemon(string parameterA, string paramterB, string parameterC)
    {
        string allPokemon;
        allPokemon = parameterA + ", " + paramterB + ", and " + parameterC;
        return allPokemon;
    }

    // 10
    string ConcatonateStats(string parameterA, int parameterB, float parameterC, float parameterD)
    {
        string allStats;
        allStats = parameterA + " stats CP: " + parameterB + ", Weight: " + parameterC + "kg, Height: " + parameterD + "m.";
        return allStats;
    }

    // 11-12
    void ReadyForBattle()
    {
        battleMessage = ConcatenatePokemon(pokemonA, pokemonB, pokemonC) + " are ready for battle!";
    }

    // 13-14
    void Stats()
    {
        statsA = ConcatonateStats(pokemonA, combatPowerA, weightA, heightA);
        statsB = ConcatonateStats(pokemonB, combatPowerB, weightB, heightB);
        statsC = ConcatonateStats(pokemonC, combatPowerC, weightC, heightC);
    }

    // 15
    void DisplayToConsole(string parameterA)
    {
        Debug.Log(parameterA);
    }
   
}
