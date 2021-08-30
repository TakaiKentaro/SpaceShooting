using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{

    [SerializeField] private float m_speed = 0f;

    [SerializeField] GameObject explosion;

    GameController gameController;
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Update()
    {
        transform.Translate(0, m_speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            gameController.AddScore();
            Instantiate(explosion, transform.position, transform.rotation); 
        }
        if(collision.gameObject.tag == "EnemyBullet"){return;}
        if(collision.gameObject.tag == "Enemy"){return;}      
    }
}