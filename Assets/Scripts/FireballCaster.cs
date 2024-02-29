using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public Fireball FireballPrefab;
    public Transform fireballSourceTransform; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(FireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);

        }
    }
}
