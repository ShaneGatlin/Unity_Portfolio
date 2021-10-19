using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f; //moveSpeed adjust player movement speed
    //These variables change our movement speed
    // Not needed anymore| Keep for reference [SerializeField] float xValue = 0f; //Variable declarations
    //[SerializeField] gives the value its own window in unity (Click+Drag right/left during game mode)
    //
    //  void PrintInstruction() //Method or Function example| void = no return and () being empty means no parameter passed through
    // {
    //     Debug.Log("Welcome to the game!");
    //     Debug.Log("Move player with <wasd> or arrow keys... duh!");
    // }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed; //Time.deltaTime normalizes to account for Frame Rate
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;  

        transform.Translate(xValue,0,zValue);
    }

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

   
}
