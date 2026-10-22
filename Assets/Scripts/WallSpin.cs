using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpin : MonoBehaviour
{
    float turnSpeed = 4.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * turnSpeed * 4 * Time.deltaTime);
    }
}
