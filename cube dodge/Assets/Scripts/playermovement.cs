using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 5000f;
    public float sidewaysForce = 50f;
    // Update is called once per frame
    void FixedUpdate()
    {
		forwardForce += 3;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce *  Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce *  Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
