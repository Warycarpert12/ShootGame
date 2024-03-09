using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float maxSize = 5;
    public float Speed = 1;
    public float damage = 50;
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

    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.DealDamage(damage);
        }
        
        var enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }
}
