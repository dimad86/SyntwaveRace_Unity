using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchAnim : MonoBehaviour
{
    [SerializeField] public float animationDuration; // ����������������� ����� ��������
    [SerializeField]public float scaleAmount; // �������� ���������� �������
    [SerializeField] public float forwardAmount; // �������� ������ ������� ������
    [SerializeField] public int repeatCount; // ���������� ���������� ��������

    private Vector3 initialScale; // ����������� ������ �������
    private Vector3 initialPosition; // ����������� ������� �������
    private float animationTimer; // ������ ��������
    private int currentRepeat; // ������� ���������� ����������

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
            // �������� ���������
            animationTimer = 0f;
            currentRepeat++;

            if (currentRepeat > repeatCount)
            {
                // ��� ���������� ���������, ���������� ���������
                currentRepeat = 0;
                transform.localScale = initialScale;
                transform.position = initialPosition;
            }
        }
        else
        {
            // ���������� �������� ���������� � ������ �������
            float t = animationTimer / animationDuration;
            float scaleFactor = Mathf.Lerp(1f, 1f - scaleAmount, t);
            float forwardOffset = Mathf.Lerp(0f, forwardAmount, t);

            transform.localScale = initialScale * scaleFactor;
            transform.position = initialPosition + transform.forward * forwardOffset;
        }
    }

  
}
