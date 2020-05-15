using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update

    public float ForwardForce = 2000f;
    public float SidewayForce = 500f;

        // We make this as "Fixed"Update because we are
        //using it to mess with physics.

    // Update is called once per frame
    void FixedUpdate()
    {
        //add ForwardForce
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime );

        if (Input.GetKey("d") )
        {

            rb.AddForce( SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {

            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        
        }

    }
}
