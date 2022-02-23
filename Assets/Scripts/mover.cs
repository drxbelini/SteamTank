using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float yValue = 0;
    [SerializeField] float moveSpeed = 5.5f;
    [SerializeField] float jumpForce = 5.5f;
    [SerializeField] float rotarionForce = 50.0f;
    Rigidbody myRigidbody;

    float rotationsValue = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        
        if(Input.GetKey(KeyCode.W))
        {
            float zForce = moveSpeed * Time.deltaTime;

            myRigidbody.AddRelativeForce(Vector3.forward * zForce);
        }

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * rotarionForce;
        

        //transform.Translate(0,yValue,zValue);   

        rotationsValue = xValue + rotationsValue;

        transform.localRotation = Quaternion.Euler(0,(rotationsValue),0);     
    }
}
