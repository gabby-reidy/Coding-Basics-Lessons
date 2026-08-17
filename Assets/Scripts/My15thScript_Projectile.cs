using UnityEngine;

public class My15thScript_Projectile : MonoBehaviour
{
    // Declaration of variables
    public Rigidbody projectile1;
    public Rigidbody projectile2;
    public Rigidbody projectile3;
    public Rigidbody projectile4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody clone;
            clone = Instantiate(projectile1, transform.position, transform.rotation);
            clone.linearVelocity = transform.TransformDirection(Vector3.forward * 20);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Rigidbody clone;
            clone = Instantiate(projectile2, transform.position, transform.rotation);
            clone.linearVelocity = transform.TransformDirection(Vector3.back * 30);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rigidbody clone;
            clone = Instantiate(projectile3, transform.position, transform.rotation);
            clone.linearVelocity = transform.TransformDirection(Vector3.right * 10);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rigidbody clone;
            clone = Instantiate(projectile3, transform.position, transform.rotation);
            clone.linearVelocity = transform.TransformDirection(Vector3.left * 10);
        }
        else if (Input.GetMouseButtonDown(2) || (Input.GetKeyDown(KeyCode.Space)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            Rigidbody clone;
            clone = Instantiate(projectile4, transform.position, transform.rotation);
            clone.linearVelocity = transform.TransformDirection(Vector3.up * 50);
        }
    }
}
// rmb fire backwards faster velo diff projectile.
// left right arrows shoot third projectile slightly slower
// space or mmb to fire upwards any velo - fourth projectile