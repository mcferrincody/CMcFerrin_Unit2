using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topofScene = 40.0f;
    private float bottomofScene = -15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topofScene)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomofScene)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
