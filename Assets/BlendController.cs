using AmazingAssets.CurvedWorld;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendController : MonoBehaviour
{
    private CurvedWorldController controller;

    // Переменные, которые будут изменяться
    public float variable1;
    public float variable2;
    public float variable3;

    // Диапазоны изменения переменных
    public Vector2 range1 = new Vector2(0f, 10f);
    public Vector2 range2 = new Vector2(-5f, 5f);
    public Vector2 range3 = new Vector2(1f, 20f);

    // Скорости изменения переменных
    public float speed1 = 1f;
    public float speed2 = 2f;
    public float speed3 = 1.5f;

    private float timeOffset1;
    private float timeOffset2;
    private float timeOffset3;

    private void Awake()
    {
        controller = GetComponent<CurvedWorldController>();
    }

    void Start()
    {
        // Создаем случайные временные сдвиги, чтобы значения начинали изменяться с разной фазы
        timeOffset1 = Random.Range(0f, 100f);
        timeOffset2 = Random.Range(0f, 100f);
        timeOffset3 = Random.Range(0f, 100f);
    }

    void Update()
    {
        // Меняем значения переменных
        variable1 = Mathf.Lerp(range1.x, range1.y, Mathf.PingPong(Time.time * speed1 + timeOffset1, 1));
        variable2 = Mathf.Lerp(range2.x, range2.y, Mathf.PingPong(Time.time * speed2 + timeOffset2, 1));
        variable3 = Mathf.Lerp(range3.x, range3.y, Mathf.PingPong(Time.time * speed3 + timeOffset3, 1));

        controller.bendCurvatureSize = variable1;
        controller.bendHorizontalSize = variable2;
        controller.bendVerticalSize = variable3;
    }
}
