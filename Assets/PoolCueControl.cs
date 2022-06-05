using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolCueControl : MonoBehaviour
{
    public GameObject Blanca;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
            transform.RotateAround
            (Blanca.transform.position, Vector3.forward, 10 * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.RotateAround
            (Blanca.transform.position, Vector3.back, 10 * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.RotateAround
            (Blanca.transform.position, Vector3.left, 10 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.RotateAround
            (Blanca.transform.position, Vector3.right, 10 * Time.deltaTime);
    }
}
