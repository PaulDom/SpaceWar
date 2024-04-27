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
        Vector2 mousePos = Input.mousePosition; // �������� �������������� ����� � ��������
        Vector2 realMousePos = Camera.main.ScreenToWorldPoint(mousePos); // �������� � �����
        gameObject.transform.position = realMousePos; // ���������� ������ � ����������
    }
}
