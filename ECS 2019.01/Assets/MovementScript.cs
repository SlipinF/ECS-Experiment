using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position += Vector3.back;
        }
    }
}
