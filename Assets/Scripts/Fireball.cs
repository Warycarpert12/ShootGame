using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float Speed;
    public float lifetime;


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
        DestroyFireball();
    }
    private void DestroyFireball()
    {
        Destroy(gameObject);
    }
}
