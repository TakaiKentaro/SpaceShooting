using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyScripts : MonoBehaviour
{
    [SerializeField] private float m_speed = 0f;
    [SerializeField] GameObject explosion;

    void Update()
    {
        transform.Translate(0, m_speed, 0);
    }

    public abstract void HitBullet();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            HitBullet();
        }    
    }


}