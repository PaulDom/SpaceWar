using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 mousePos = Input.mousePosition; // Получили местоположение мышки в пикселях
        Vector2 realMousePos = Camera.main.ScreenToWorldPoint(mousePos); // Перевили в юниты
        gameObject.transform.position = realMousePos; // Перемешаем обьект к координате
    }
}
