using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvasScript : MonoBehaviour
{
    public Canvas startCaravan;
    public Canvas pauseCaravan;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startCaravan.gameObject.SetActive(false);
            pauseCaravan.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseCaravan.gameObject.SetActive(false);
            startCaravan.gameObject.SetActive(true);
        }



    }
}
