using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : EnemyScripts
{
    public GameObject bulletprefab;
    void Start()
    {
        InvokeRepeating("Shot", 1f, 1f);
    }
    void Shot()
    {
        Instantiate(bulletprefab, transform.position, transform.rotation);
    }
}
