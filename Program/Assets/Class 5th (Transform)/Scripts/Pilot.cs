using UnityEngine;

public class Pilot : MonoBehaviour
{
    [SerializeField] int x = 0;
    [SerializeField] int y = 0;
    [SerializeField] int z = 0;
    void Start()
    {
        Debug.Log(transform.position);

        transform.position = new Vector3(x, y, z);

        Debug.Log(transform.position);
    }

    void Update()
    {
        Move(0, 0, 0);
    }

    void Move(int x, int y, int z)
    {
        // w키 누르면 z축으로 1칸 + 이동
        if (Input.GetKeyDown(KeyCode.W))
        {
            z++;
        }

        // a -> x축으로 왼쪽으로 1칸 - 이동
        if (Input.GetKeyDown(KeyCode.A))
        {
            x--;
        }

        // s -> z축으로 1칸 - 이동
        if (Input.GetKeyDown(KeyCode.S))
        {
            z--;
        }

        // d -> x축으로 오른쪽으로 1칸 + 이동
        if (Input.GetKeyDown(KeyCode.D))
        {
            x++;
        }

        // 변경된 좌표로 위치 업데이트
        transform.position = new Vector3(x, y, z);
    }
}
