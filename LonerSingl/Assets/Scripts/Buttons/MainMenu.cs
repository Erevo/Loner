using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void OnMouseDown()
    {
        GetComponent<Light>().range = 40;
    }

    void OnMouseUp()
    {
        GetComponent<Light>().range = 15;
    }

    public void OnMouseClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
