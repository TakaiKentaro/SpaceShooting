using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0, -0.03f, 0);

        if(transform.position.y < -15.0f)
        {
            transform.position = new Vector3(0, 15.0f, 0);
        }
    }
}
