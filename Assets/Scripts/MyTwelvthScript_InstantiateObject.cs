using UnityEngine;

public class MyTwelvthScript_InstantiateObject : MonoBehaviour
{
    // Declaration of Variables
    public GameObject spawnObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObjectMethod();
        }
    }

    void SpawnObjectMethod()
    {
        Instantiate(spawnObject,transform.position,transform.rotation);
    }
}
