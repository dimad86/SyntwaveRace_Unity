using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] public Vector3 startCoord; // ��������� ����������
    [SerializeField] public Vector3 endCoord;   // �������� ����������
    [SerializeField] public float speed; // �������� �����������

    private float startTime;
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {
        MoveTo(startCoord); // �������� � ��������� ���������
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �������� �������� ���������, ������ ���� ������� � �������� �������� ������
        if (Vector3.Distance(transform.position, endCoord) < 0.01f)
        {
            SwapTargets();
            MoveTo(startCoord);
        }
        // ���� �������� ��������� ���������, ������ ���� ������� � �������� �������� ������
        else if (Vector3.Distance(transform.position, startCoord) < 0.01f)
        {
            SwapTargets();
            MoveTo(endCoord);
        }

    }

    private void SwapTargets()
    {
        Vector3 temp = startCoord;
        startCoord = endCoord;
        endCoord = temp;
    }

    // ������ �������� � ��������� �����������
    private void MoveTo(Vector3 target)
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(transform.position, target);
    }

    // �������� ������������ ����� ���������� � ��������� ������������
    private void FixedUpdate()
    {
        float distanceCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distanceCovered / journeyLength;
        transform.position = Vector3.Lerp(startCoord, endCoord, fractionOfJourney);
    }
}
