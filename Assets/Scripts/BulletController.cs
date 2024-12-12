using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public int dmg;

    public Rigidbody2D rb;
    void Start()
    {
        speed = speed+Random.Range(-2, 2);
        //rb.velocity = transform.right * speed;
        rb.AddForce((transform.up-transform.right)*speed,ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.GameObject().name == "Player")
        {
            Destroy(this.GameObject());
            hitInfo.GetComponent<PlayerController>().recieveDamage(dmg);
        }
        //print("bullet hitting" + hitInfo);
    }
}
