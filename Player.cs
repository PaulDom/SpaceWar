using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points = 0;
    public Projectile projectilePrefab;

    private void Update()
    {
        Move();
        Shoot();
    }

    void Move()
    {
        Vector2 mousePos = Input.mousePosition; 
        Vector2 realMousePos = Camera.main.ScreenToWorldPoint(mousePos); 
        gameObject.transform.position = realMousePos; 
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
