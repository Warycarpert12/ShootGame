using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float maxSize = 5;
    public float Speed = 1;
    void Start()
    {
        transform.localScale = Vector3.zero;
    }

    void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * Speed;
        if (transform.localScale.y > maxSize )
        {
            Destroy(gameObject);
        }    
    }
}
