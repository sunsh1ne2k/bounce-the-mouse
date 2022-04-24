using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D projectileRb;
    // Start is called before the first frame update
    void Awake()
    {
        projectileRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 direction, float force){
        projectileRb.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other){
        MouseController mc = other.collider.GetComponent<MouseController>();
        if (mc!=null){
            Debug.Log("Game Over");
        }
    }
}
