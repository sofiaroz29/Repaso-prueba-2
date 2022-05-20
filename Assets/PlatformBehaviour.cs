using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    public float speed;
    public bool toRight;
    public GameObject baseder;
    public GameObject baseizq;
    public GameObject prefab1;
    public GameObject prefab2;
    int yOffset = 1;

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

        if (transform.position.x > baseder.transform.position.x -1.5f)
        {
            toRight = false;
            GameObject clone;
            clone = Instantiate(prefab1);
            clone.transform.position = baseder.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }
        
        if (transform.position.x < baseizq.transform.position.x + 1.5f)
        {
            toRight = true;
            GameObject clone;
            clone = Instantiate(prefab2);
            clone.transform.position = baseizq.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }


    }
}
