using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public float Time;

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
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
