using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
        }
    }

    void Movement(Vector3 direction)
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
