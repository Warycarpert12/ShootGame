using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public float damage = 10f;

    public Fireball FireballPrefab;
    public Transform fireballSourceTransform; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var fireball = Instantiate(FireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);
            fireball.damage = damage;

        }
    }
}
