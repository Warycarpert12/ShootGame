using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fireball : MonoBehaviour
{
    public float Speed;
    public float lifetime;
    public float damage = 10;
    public AudioSource FireballSound;


    private void Start()
    {
        Invoke("DestroyFireball", lifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveFixedUpdate();
    }
    private void MoveFixedUpdate()
    {

        transform.position += transform.forward * Speed * Time.fixedDeltaTime;

    }
    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DestroyFireball();
    }
    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);

        }
    }
    private void DestroyFireball()
    {
        Destroy(gameObject);
    }

}
