using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, -7, 0) * Time.deltaTime;
    }
}
