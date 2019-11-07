using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove2 : MonoBehaviour
{
    public float Speed = 0.25f;
    public float Edge = 3.15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < Edge)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + Speed, transform.position.z);
            if (transform.position.y > Edge)
            {
                transform.position = new Vector3(transform.position.x, Edge, transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -Edge)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - Speed, transform.position.z);
            if (transform.position.y < -Edge)
            {
                transform.position = new Vector3(transform.position.x, -Edge, transform.position.z);
            }
        }
    }
}
