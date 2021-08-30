using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float interval = 1.5f;
    private float timeElapsed = 0.0f;
    public float timeOut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= interval)
        {
            timeElapsed = 0f;
            Vector2 randamPos = new Vector2(Random.Range(-3.5f, 3.5f),6);
            Instantiate(enemyPrefab, randamPos, Quaternion.identity);
        }
    }
}
