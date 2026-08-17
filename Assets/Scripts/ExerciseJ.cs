using UnityEngine;

public class ExerciseJ : MonoBehaviour
{
    // Declaration of Variables
    public Rigidbody rB1;
    public Rigidbody rB2;
    public Rigidbody rB3;

    public Transform spawnPosition;
    public Transform spawnRotation;

    public int amount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controls();   
    }

    void Controls()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(rB1, new Vector3(-5, 8, 0), Quaternion.identity);
            Instantiate(rB2, new Vector3(5, 7,0), Quaternion.identity);
            Instantiate(rB3, new Vector3(7, 9, 0), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(rB3, transform.position, transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < amount; i++)
            {
                Instantiate(rB1, spawnPosition, spawnRotation);
            }
        }
    }
}
