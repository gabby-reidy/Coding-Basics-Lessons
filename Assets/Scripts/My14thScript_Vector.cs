using UnityEngine;

public class My14thScript_Vector : MonoBehaviour
{
    // Declaration of Variables
    public GameObject spawnObject1;
    public GameObject spawnObject2;
    public GameObject spawnObject3;
    public Transform spawnPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //Instantiate an object using the objects position/rotation the script is attached to
            Instantiate(spawnObject1, transform.position, transform.rotation);

            // Instantiate an obeject using another objects position/rotation
            Instantiate(spawnObject2, spawnPos.position, spawnPos.rotation);

            // Instantiate an object using a specific position and orientation in the 3d space
            Instantiate(spawnObject3, new Vector3(-5, 5, 0), Quaternion.identity);
        }
    }
}
