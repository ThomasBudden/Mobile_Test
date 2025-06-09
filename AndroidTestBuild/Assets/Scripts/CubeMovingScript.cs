using UnityEngine;

public class CubeMovingScript : MonoBehaviour
{
    public float speed = 0.01f;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10f));

            transform.position = Vector3.Lerp(transform.position, touchPosition, speed);
        }
    }
}
