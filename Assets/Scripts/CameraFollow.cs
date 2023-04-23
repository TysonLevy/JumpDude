using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    void FixedUpdate()
    {
        this.transform.position = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        if(this.transform.position.x < 0)
        {
            this.transform.position = new Vector3(0, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.y < 0)
        {
            this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        }
        if (this.transform.position.x > 20)
        {
            this.transform.position = new Vector3(20, this.transform.position.y, this.transform.position.z);
        }

    }
    
}
