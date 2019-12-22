using UnityEngine;
using System.Collections;


public class Bullet2D : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, 3);
        Physics2D.IgnoreLayerCollision(8, 8);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Player":
                break;
            case "Bullet(Clone)":
                break;
            default:
                Destroy(gameObject);
                break;

        }

    }
}
