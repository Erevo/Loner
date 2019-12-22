using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{

    public GameObject[] Zombies;
    [SerializeField] private GameObject[] Spawns;
    public int zombieMax;
    public float zombieTime;
    public float startNewWaveTime;
    private bool Activated = false;



    private void Start()
    {
    }

    void Update()
    {
        Spawns = GameObject.FindGameObjectsWithTag("spawnPoint");
        if (Input.GetKeyDown(KeyCode.Space) & (Activated == false))
        {
            Time.timeScale = 1;
            Activated = true;
            StartCoroutine(waveTime());
        }

        if (Input.GetKeyDown(KeyCode.P) & (Activated == true))
        {
            Activated = false;
            Time.timeScale = 0;
        }

    }

    IEnumerator waveTime()
    {
        yield return new WaitForSecondsRealtime(3);
        while (Activated == true)
        {
            for (int i = 0; i < zombieMax; i++)
            {
                if (Activated)
                {
                    Instantiate(Zombies[Random.Range(0, 3)], Spawns[Random.Range(0, Spawns.Length)].transform.position, Quaternion.identity);
                    yield return new WaitForSecondsRealtime(zombieTime);
                }
            }
            zombieMax += 5;
            zombieTime *= 0.8f;
            yield return new WaitForSecondsRealtime(startNewWaveTime);
            startNewWaveTime *= 0.9f;
        }
    }
}
