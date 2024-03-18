using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 360f / Time.fixedDeltaTime, 0);
        Debug.Log("Next Step.");
    }
}
