using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expiration : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeToLive = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToLive -= Time.deltaTime;
        if (TimeToLive <= 0)
        {
            Destroy(gameObject);
        }
    }
}
