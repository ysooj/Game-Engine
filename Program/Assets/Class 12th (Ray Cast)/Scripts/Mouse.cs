using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;               // 광선
    [SerializeField] float distance;
    [SerializeField] RaycastHit rayCastHit; // 광선에 부딪힌 오브젝트에 대한 정보를 담을 것.
    [SerializeField] Texture2D texture2D;

    private void Awake()
    {
        distance = Mathf.Infinity;
        Cursor.SetCursor(texture2D, Vector2.zero, CursorMode.Auto);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 0 ; 마우스 왼쪽 버튼
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);

            if (Physics.Raycast(ray, out rayCastHit, 100))
            {
                Debug.Log(rayCastHit.collider.name);
                Debug.DrawLine(ray.origin, rayCastHit.point, Color.red);
            }
        }
    }
}
