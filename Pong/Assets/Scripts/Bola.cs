using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{   
    public float velBola;
    public Rigidbody2D rigidbody2D;
    public AudioSource somBola;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D.velocity = new Vector2(velBola, velBola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D colissionInfo)
    {
        somBola.Play();
    }
}
