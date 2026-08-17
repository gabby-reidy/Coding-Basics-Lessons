using UnityEngine;

public class My16thScript : MonoBehaviour
{
    // Declaration of Variables
    public Rigidbody burstObject;
    int bulletVelo = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Rigidbody clone;
            for (int i = 1; i <= 5; i++)
            {
                clone = Instantiate(burstObject, transform.position + new Vector3(0,0, -0.5f), transform.rotation);
                clone.linearVelocity = transform.TransformDirection(Vector3.back * bulletVelo);
            }
        }
    }
}
