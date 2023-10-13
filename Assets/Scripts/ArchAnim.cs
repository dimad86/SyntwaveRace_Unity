using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchAnim : MonoBehaviour
{
    [SerializeField] public float animationDuration; // Продолжительность одной анимации
    [SerializeField]public float scaleAmount; // Величина уменьшения объекта
    [SerializeField] public float forwardAmount; // Величина сдвига объекта вперед
    [SerializeField] public int repeatCount; // Количество повторений анимации

    private Vector3 initialScale; // Изначальный размер объекта
    private Vector3 initialPosition; // Изначальная позиция объекта
    private float animationTimer; // Таймер анимации
    private int currentRepeat; // Текущее количество повторений

    private void Start()
    {
        initialScale = transform.localScale;
        initialPosition = transform.position;
        animationTimer = 0f;
        currentRepeat = 0;
    }

    private void Update()
    {
        animationTimer += Time.deltaTime;

        if (animationTimer >= animationDuration)
        {
            // Анимация завершена
            animationTimer = 0f;
            currentRepeat++;

            if (currentRepeat > repeatCount)
            {
                // Все повторения завершены, сбрасываем состояние
                currentRepeat = 0;
                transform.localScale = initialScale;
                transform.position = initialPosition;
            }
        }
        else
        {
            // Производим анимацию уменьшения и сдвига объекта
            float t = animationTimer / animationDuration;
            float scaleFactor = Mathf.Lerp(1f, 1f - scaleAmount, t);
            float forwardOffset = Mathf.Lerp(0f, forwardAmount, t);

            transform.localScale = initialScale * scaleFactor;
            transform.position = initialPosition + transform.forward * forwardOffset;
        }
    }

  
}
