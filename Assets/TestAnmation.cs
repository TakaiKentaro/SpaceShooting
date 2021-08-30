using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnmation : MonoBehaviour
{
    [SerializeField]
    Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("play animtion");
            animation.Play();
        }
    }
}
