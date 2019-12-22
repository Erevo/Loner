using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Rigidbody2D Player;
    [SerializeField] GameObject gunPoint;
    [SerializeField] float Speed;
    Vector3 MousePos;
    
    void Start()
    {
       
    }

    void FixedUpdate()
    {
        Player.angularVelocity = 0f;
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Player.transform.right = Vector2.Lerp(transform.right, (MousePos - transform.position), 1f);
        Player.velocity = new Vector3(Input.GetAxis("Horizontal") * Speed,Input.GetAxis("Vertical")  * Speed, 0);
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(new Vector3(Player.position.x, Player.position.y, -1), new Vector3(MousePos.x, MousePos.y, -1));
    }
}
