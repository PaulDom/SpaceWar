using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        gameObject.transform.position = (Vector2)transform.position + Vector2.down * speed * Time.deltaTime;
    }

    void Start()
    {
        Destroy(gameObject, 10);
    }
}
