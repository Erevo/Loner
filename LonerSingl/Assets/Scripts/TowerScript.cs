using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerScript : MonoBehaviour
{
    public int towerHP;
    public GameObject deathCanvas;
    public GameObject Crosshair;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 10);
        deathCanvas = GameObject.FindGameObjectWithTag("die");
        Crosshair = GameObject.Find("Cursor");
        deathCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (towerHP <= 0) towerDestroyed();  

    }

    void towerDestroyed()
    {
        Cursor.visible = true;
        Destroy(Crosshair);
        deathCanvas.gameObject.SetActive(true);
        Destroy(gameObject);
        Time.timeScale = 0;
    }

}
