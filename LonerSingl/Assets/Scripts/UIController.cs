using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject Tower;
    [SerializeField] private TowerScript towerS;
    [SerializeField] int towerHP;
    Text text;




    void Start()
    {
    }

    void Update()
    {
        while (Tower == null)
            Tower = GameObject.FindGameObjectWithTag("tw");
        while (text == null)
                text = GameObject.Find("Text1").GetComponent<Text>();

        gameObject.transform.SetParent(Tower.transform);

        towerS = Tower.GetComponent<TowerScript>();
        towerHP = towerS.towerHP;

        text.text = "HP: " + towerHP;

        text.transform.position = new Vector3(Tower.transform.position.x, Tower.transform.position.y + 2f, Tower.transform.position.z);
    }
}
