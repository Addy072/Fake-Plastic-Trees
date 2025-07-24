using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector3 (-1000f *Time.deltaTime, 0, 0));
        }

       if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(1000f * Time.deltaTime, 0, 0));
        }

    }
    
}
