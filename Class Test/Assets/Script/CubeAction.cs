using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour
{
    public float HorizontalRotationInput;
    public float VerticalRotationInput;
    public float HorizontalMovementInput;
    public float VerticalMovementInput;
    bool forward = false;
    public float speed = 50f;
    public float valuex = 1, valuey =1, valuez=1;

    public float rotationSpeed = 100f;


    void Update()
    {
        HorizontalRotationInput = Input.GetAxis("HorizontalRotation");
        VerticalRotationInput = Input.GetAxis("VerticalRotation");
        HorizontalMovementInput = Input.GetAxis("HorizontalMovement");
        VerticalMovementInput = Input.GetAxis("VerticalMovement");


        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * HorizontalRotationInput);
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * VerticalRotationInput);


        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalMovementInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalMovementInput);

        if (Input.GetKey("space"))   
        {

            transform.localScale = transform.localScale + new Vector3(Time.deltaTime * valuex, Time.deltaTime * valuey, Time.deltaTime * valuez);
            
        }
        if (Input.GetKeyUp("space"))
        {
            while (transform.localScale.x > 1)
            {
                transform.localScale = transform.localScale - new Vector3(Time.deltaTime * valuex, Time.deltaTime * valuey, Time.deltaTime * valuez);
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
