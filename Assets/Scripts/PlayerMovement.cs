
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    public float scale;

    private void Update()
    {
        Time.timeScale = scale;
    }
    // We mark this as "Fixed Update" because we are using 
    // it to mess wtih physics

    void FixedUpdate () {

        //Add a forwardd force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); // Add a force of 2000 on the z-axis
        if(Input.GetKey("d")){
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
