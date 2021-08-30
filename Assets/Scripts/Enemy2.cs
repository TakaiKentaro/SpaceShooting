using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime, 0);

        transform.Translate(0, -0.03f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "Player")
        {
            // 0.2秒後に消える
            Destroy(gameObject, 0.2f);
        }
    }
}
