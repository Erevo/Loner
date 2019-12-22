using UnityEngine;
using System.Collections;

public class FireScript : MonoBehaviour
{

    public float speed = 10;
    public Rigidbody2D bullet;
    public Transform gunPoint;
    public float fireRate = 1;
    public Rigidbody2D Player;

    private float lastShoot;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (Time.time > lastShoot + fireRate)
        {

            lastShoot = Time.time;
            Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.Euler(0f, 0f, -90f) * Player.transform.rotation);
            clone.velocity = transform.TransformDirection(new Vector3(speed, 0, 0));
        }
    }


}
