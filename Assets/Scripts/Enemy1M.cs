using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1M : MonoBehaviour
{
    public Transform endPoint;   // �������� �����
    public float speed;   // �������� �����������

    private Vector3 startPoint; // ��������� �����
    private Vector3 currentTarget; // ������� ������� �������

    private void Start()
    {
        startPoint = transform.position; // ���������� ������� ������� ������� ��� ��������� �����
        currentTarget = endPoint.position; // �������� � �������� �����
    }

    private void Update()
    {
        // ���������� ������ � ������� ������� ������� �������
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // ���� ������ ������ ������� ������� �������, ������ ���� �� ���������������
        if (Vector3.Distance(transform.position, currentTarget) < 0.01f)
        {
            if (currentTarget == endPoint.position)
                currentTarget = startPoint;
            else
                currentTarget = endPoint.position;
        }
    }
}



