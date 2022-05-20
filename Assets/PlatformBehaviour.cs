using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{

    public float speed;
    public bool toRight;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > 4)
        {
            toRight = false;
        }
        
        if (transform.position.x < -4f )
        {
            toRight = true;
        }
    }
}
