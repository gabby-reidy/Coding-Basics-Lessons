using UnityEngine;

public class My13thScript : MonoBehaviour
{
    // Declaration of Variables
    public GameObject spawnObject;
    public Transform spawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            spawnObject = Instantiate(spawnObject, spawnPos.position, spawnPos.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            spawnObject.GetComponent<Renderer>().material.color = Color.red;
            //spawnObject.GetComponent<Renderer>().material.SetColor("_BaseColor", Color.magenta);
        }
    }
}
