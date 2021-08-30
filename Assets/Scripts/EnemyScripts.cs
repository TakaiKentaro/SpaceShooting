using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    [SerializeField] private float m_speed = 0f;
    [SerializeField] GameObject explosion;

    void Update()
    {
        transform.Translate(0, m_speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet"){Instantiate(explosion, transform.position, transform.rotation);}
        if(collision.gameObject.tag == "EnemyBullet"){return;}
        if(collision.gameObject.tag == "Enemy"){return;}      
    }
}