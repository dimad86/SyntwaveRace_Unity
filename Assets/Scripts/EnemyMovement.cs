using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] public Vector3 startCoord; // Ќачальные координаты
    [SerializeField] public Vector3 endCoord;   //  онечные координаты
    [SerializeField] public float speed; // —корость перемещени€

    private float startTime;
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {
        MoveTo(startCoord); // Ќачинаем с начальных координат
    }

    // Update is called once per frame
    void Update()
    {
        // ≈сли достигли конечных координат, мен€ем цели местами и начинаем движение заново
        if (Vector3.Distance(transform.position, endCoord) < 0.01f)
        {
            SwapTargets();
            MoveTo(startCoord);
        }
        // ≈сли достигли начальных координат, мен€ем цели местами и начинаем движение заново
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

    // Ќачать движение к указанным координатам
    private void MoveTo(Vector3 target)
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(transform.position, target);
    }

    // Ћинейна€ интерпол€ци€ между начальными и конечными координатами
    private void FixedUpdate()
    {
        float distanceCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distanceCovered / journeyLength;
        transform.position = Vector3.Lerp(startCoord, endCoord, fractionOfJourney);
    }
}
