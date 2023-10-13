using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1M : MonoBehaviour
{
    public Transform endPoint;   // Конечная точка
    public float speed;   // Скорость перемещения

    private Vector3 startPoint; // Начальная точка
    private Vector3 currentTarget; // Текущая целевая позиция

    private void Start()
    {
        startPoint = transform.position; // Используем текущую позицию объекта как начальную точку
        currentTarget = endPoint.position; // Начинаем с конечной точки
    }

    private void Update()
    {
        // Перемещаем объект в сторону текущей целевой позиции
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // Если объект достиг текущей целевой позиции, меняем цель на противоположную
        if (Vector3.Distance(transform.position, currentTarget) < 0.01f)
        {
            if (currentTarget == endPoint.position)
                currentTarget = startPoint;
            else
                currentTarget = endPoint.position;
        }
    }
}



