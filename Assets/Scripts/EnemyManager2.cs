using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour
{
    private float interval = 0.5f;
    private float timeElapsed = 0.0f;
    public float timeOut;
    public GameObject bulletprefab;
    public GameObject explosion;

    GameController gameController;

    float offset;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        offset = Random.Range(0, 2f * Mathf.PI);
        InvokeRepeating("Shot", 1f, 1f);
        
    }
    
    void Shot()
    {
        Instantiate(bulletprefab, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.01f, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            Instantiate(explosion, collision.transform.position, transform.rotation);
            gameController.GameOver();
        }
        else if (collision.CompareTag("bullet") == true)
        {
            gameController.AddScore();
        }
        else if(collision.CompareTag("EnemyBullet")==true)
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(collision.gameObject);

    }

}
