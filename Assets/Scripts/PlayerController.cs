using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float ForwardInput;
    public float speed = 5.0f;
    public float turnSpeed;   // the floats store decimal values, allowing for fluid turning and an better transition to higher and lower numbers
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal"); //defines the axis of horizontal as HorizontalInput
        ForwardInput = Input.GetAxis("Vertical"); //defines the axis of vertical as ForwardInput 

        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * HorizontalInput);
        transform.Rotate(Vector3.up, turnSpeed * HorizontalInput * Time.deltaTime);
            // Vector3.up controls the axis allowing for going forwards and backwards.
            // speed allows me to control the rate at which the player can move
            

    }
}
