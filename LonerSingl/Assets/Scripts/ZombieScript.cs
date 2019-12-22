using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public float zombieSpeed;
    [SerializeField] GameObject Tower;
    [SerializeField] Rigidbody2D Zombie;
    [SerializeField] private int zombieHP = 100;
    [SerializeField] private TowerScript towerS;
    [SerializeField] int towerHP;
    public int zombieDamage;
    public float lastDamage;




    void Start()
    {
        Tower = GameObject.FindGameObjectWithTag("tw");
    }

    void Update()
    {
        if (Tower == null)
        {
            return;
        }

        towerS = Tower.GetComponent<TowerScript>();
        Zombie.angularVelocity = 0f;
        if (zombieHP <= 0)
        {
            Destroy(Zombie.gameObject);
        }

        if (Vector3.Distance(Tower.transform.position, Zombie.transform.position) < 5f)
        {
            if (Time.time > lastDamage + 2f)
            {
                towerS.towerHP -= zombieDamage;
                lastDamage = Time.time;
            }
        }


        towerHP = towerS.towerHP;


    }

    void FixedUpdate()
    {
        Zombie.transform.right = Vector2.Lerp(transform.right, (Tower.transform.position - transform.position), 1f);
        Zombie.velocity = Zombie.transform.TransformDirection(new Vector3(zombieSpeed, 0));
    }


    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bullet(Clone)")
        {
            Zombie.AddForce(coll.rigidbody.velocity / 25, ForceMode2D.Force);
            zombieHP -= 50;

        }


    }

}
