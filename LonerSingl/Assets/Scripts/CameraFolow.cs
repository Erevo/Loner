using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    public GameObject Player;

    
    void Update()
    {
        Camera.main.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10f);
    }
}
