using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform shotPoint;
    float m_timer = 0f;
    public float m_fireInterval = 0.3f;
    Rigidbody2D rb2d;
    public int speed;


    GameController gameController;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    float x;
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * speed;

        rb2d.velocity = new Vector2(x, 0);
        {
            m_timer += Time.deltaTime;

            if (m_timer > m_fireInterval)
            {
                m_timer = 0;
                Instantiate(BulletPrefab, shotPoint.position, shotPoint.rotation);
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        gameController.GameOver();
    }
}
