using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float yValue = 0;
    [SerializeField] float moveSpeed = 5.5f;
    [SerializeField] float jumpForce = 5.5f;
    [SerializeField] float rotarionForce = 50.0f;

    float rotationsValue = 0;
    
    // Start is called before the first frame update
    void Start()
    {   
        PrintInstructions();
    }
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move yor player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * rotarionForce;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        

        transform.Translate(0,yValue,zValue);   

        rotationsValue = xValue + rotationsValue;

        transform.localRotation = Quaternion.Euler(0,(rotationsValue),0);     
    }
}
