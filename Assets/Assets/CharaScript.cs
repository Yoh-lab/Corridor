using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.05f;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * 0.05f;
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 100 * Time.deltaTime, 0) ;
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -100 * Time.deltaTime, 0);
        }
    }
}