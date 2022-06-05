using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear : MonoBehaviour
{
    public Rigidbody tacorb;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            tacorb.AddForce(0, -500, 1000, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name=="Blanca"){
gameObject.SetActive(false); }
}
}

