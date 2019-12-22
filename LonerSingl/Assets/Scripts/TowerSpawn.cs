using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    [SerializeField]GameObject tower;
    void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(-5f ,5f), Random.Range(-5f, 5f), 0);
        Instantiate(tower, randomPos, Quaternion.identity);
    }

}
