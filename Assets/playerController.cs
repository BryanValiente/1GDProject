using UnityEngine;
using UnityEngine.InputSystem;


public class playerController : MonoBehaviour
{

    float movementX;

    float movementY;

    float movementZ;

    private Rigidbody rb;

    [SerializeField] private float speed = 5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
       

        Vector3 movement = new Vector3(movementX, movementY, movementZ);
        rb.AddForce(movement * speed);

        //speed limit
        if(rb.linearVelocity.magnitude > 7)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * 7;
        }

        
    }

    void OnMove(InputValue value)
    {
        Vector3 v = value.Get<Vector3>();
        
        Debug.Log("Move function has been called");
        // Debug.Log(v);
        movementX = v.x;
        movementY = v.y;
        movementZ = v.z;

    }
   int jumpCounter;
    public void OnJump()
    {
        Debug.Log(transform.position.y);
        if(transform.position.y < 0.6)
        {
            jumpCounter = 0;
        }
        if(transform.position.y < 0.6 || jumpCounter<2){
            // Debug.Log("If statement is working");
            GetComponent<Rigidbody>().AddForce(0,500,0);
            jumpCounter+=1;

        }
    }
    // public void OnDash()
    // {

    //     GetComponent<Rigidbody>().AddForce(0,500,0);

    // }

}
