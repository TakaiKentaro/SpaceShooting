using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 position;
    public float lifetime;
    public GameObject bullet;
    AudioSource getSE;
    GameController gameController;

    private void Start()
    {
        getSE = this.GetComponent<AudioSource>();
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        transform.position += new Vector3(0, 0.2f, 0);
        getSE.PlayOneShot(getSE.clip);
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            gameController.AddScore();
        }
    }
    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "Enemy")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
