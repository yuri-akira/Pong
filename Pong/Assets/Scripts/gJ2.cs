using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gJ2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("bola"))
        {
            FindObjectOfType<GameManager>().pontuacaoJ1();

            other.gameObject.transform.position = Vector2.zero;

        }
    }
}
