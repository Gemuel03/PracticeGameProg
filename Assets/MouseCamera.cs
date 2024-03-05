using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    //public float sensX;
    //public float sensY;
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;

    public Transform orientation;

    //float xRotation;
    //float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

       /* float mouseX = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensY;

        yRotation += mouseY;
        xRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);*/


        turn.x += Input.GetAxis("Mouse Y");
        turn.y += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(-turn.x, turn.y, 0);
        orientation.rotation = Quaternion.Euler(0, turn.y, 0);

        if (turn.x > 90)
        {
            turn.x = 90;
        }
        if (turn.x < -90)
        {
            turn.x = -90;
        }
    }
}
