using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player; // Gameobject allows me to select another gameobject from the scene to a script for a certain purpose, here it defines what the player is so the script can add the offset to it.
    private Vector3 offset = new Vector3(1.4f,0.87f,-10.80287f); //Creates an offset for the camera which makes it so the player and camera dont clip, setting a third person view.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void lateUpdate()
    {
     transform.position = player.transform.position + offset; //grabs player position and transforms the cameras pos plus that by the offset
    }
}
