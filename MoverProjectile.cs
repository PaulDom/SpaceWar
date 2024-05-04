using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverProjectile : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        gameObject.transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }

    void Start()
    {
        Destroy(gameObject, 10);
    }
}
