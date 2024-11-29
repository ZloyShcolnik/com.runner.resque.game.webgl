using UnityEngine;
using UnityEngine.InputSystem;

public class SwipeHandler : MonoBehaviour
{
    public float swipeThreshold = 50f; // Минимальная длина свайпа для его регистрации

    private Vector2 startMousePosition; // Начальная позиция мыши
    private bool isSwiping = false;     // Флаг, указывающий на активный свайп

    public void OnMouseSwipe()
    {
        // Начало свайпа
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            isSwiping = true;
            startMousePosition = Mouse.current.position.ReadValue();
        }
        // Завершение свайпа
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            if (isSwiping)
            {
                Vector2 endMousePosition = Mouse.current.position.ReadValue();
                Vector2 swipeDelta = endMousePosition - startMousePosition;

                if (swipeDelta.magnitude >= swipeThreshold) // Проверяем длину свайпа
                {
                    ProcessSwipe(swipeDelta);
                }
                else
                {
                    Debug.Log("Слишком короткий свайп");
                }

                isSwiping = false; // Сбрасываем флаг
            }
        }
    }

    private void ProcessSwipe(Vector2 swipeDelta)
    {
        // Определяем, является ли свайп горизонтальным или вертикальным
        if (Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y)) // Горизонтальный свайп
        {
            if (swipeDelta.x > 0)
            {
                Debug.Log("Свайп вправо");
            }
            else
            {
                Debug.Log("Свайп влево");
            }
        }
        else // Вертикальный свайп
        {
            if (swipeDelta.y > 0)
            {
                Debug.Log("Свайп вверх");
            }
            else
            {
                Debug.Log("Свайп вниз");
            }
        }
    }
}