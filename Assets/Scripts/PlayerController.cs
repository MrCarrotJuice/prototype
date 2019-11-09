using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class PlayerController : MonoBehaviour
  

{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // all variables
    private float turnSpeed = 50.0f;
    private float speed = 20;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //forward inputs
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Steering inputs
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);






    }
}
