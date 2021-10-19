using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ObjectHit : MonoBehaviour
{
    public float timeToAction = 1;
    public float tempTime = 0;
    
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        tempTime = Time.time;
    }

    private void Start() 
    {
    GetComponent<MeshRenderer>().material.color = Color.black;
    }

    private void Update() 
    {
        float delta = Time.time - tempTime;
        if (delta > .5)
        {
        GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}


