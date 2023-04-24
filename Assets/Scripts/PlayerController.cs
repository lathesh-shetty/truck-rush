using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    //Private variables
    private float _speed = 25.0f;
    private float _turnSpeed = 35f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input Mapping
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * verticalInput);
        //rotate vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * horizontalInput);
    }
}
