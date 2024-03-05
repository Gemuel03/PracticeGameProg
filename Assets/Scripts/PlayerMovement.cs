using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; // reference sa RigidBody ng Player


    // kung gusto mo mag appear sa script sa unity para doon ka nalang mag adjust ng values
    /*public float Forwardforce;
    public float Gravityforce;
    public float Sidewaysforce;*/

    // Start is called before the first frame update


    public float moveSpeed;
    public Transform orientation;
    float horizontalInput;
    float verticalInput;
    Vector3 movementDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.freezeRotation = true;
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        movementDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(movementDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Update is called once per frame
    void Update()
    {

        MyInput();



       /*f (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Forwardforce * Time.deltaTime);
        }
        else if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Forwardforce * Time.deltaTime);
        }else if(Input.GetKey("q")) 
        {
            rb.AddForce(0, Gravityforce * Time.deltaTime, 0 );
        }else if (Input.GetKey("e"))
        {
            rb.AddForce(0, -Gravityforce * Time.deltaTime, 0);
        }        

        if (Input.GetKey("d"))
        {
            rb.AddForce (Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }else if (Input.GetKey("a"))
        {
            rb.AddForce(-Sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }*/



    }
}



/*
 x = kung negative pa left and movement, kung positive pa right
 y = kung negative pa baba and movement, kung positive pa taas
 z = kung positive pa forward movement, kung negative pa atras
 */
//rb.useGravity=false; no Gravity
//rb.AddForce(x,y,z) ma move ang object
//rb.AddForce(0,0,200 * Time.deltaTime); para sa slower computer
//Debug.Log() pang print sa console
//public Datatype Variable Name;