using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMamager : MonoBehaviour
{

    private float countTime = 0f;

    [SerializeField]
    private float nextCountTime = 0;

    public GameObject explosion;

    GameController gameController;



    private void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Update()
    {
             transform.Translate(0, -0.05f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")==true)
        {
            Instantiate(explosion, collision.transform.position, transform.rotation);
            gameController.GameOver();
        }
        else if (collision.CompareTag("bullet") == true)
        {
            gameController.AddScore();
        }
        else if (collision.CompareTag("EnemyBullet") == true)
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(collision.gameObject);

    }
}
