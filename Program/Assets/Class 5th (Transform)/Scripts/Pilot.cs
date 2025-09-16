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
        // wŰ ������ z������ 1ĭ + �̵�
        if (Input.GetKeyDown(KeyCode.W))
        {
            z++;
        }

        // a -> x������ �������� 1ĭ - �̵�
        if (Input.GetKeyDown(KeyCode.A))
        {
            x--;
        }

        // s -> z������ 1ĭ - �̵�
        if (Input.GetKeyDown(KeyCode.S))
        {
            z--;
        }

        // d -> x������ ���������� 1ĭ + �̵�
        if (Input.GetKeyDown(KeyCode.D))
        {
            x++;
        }

        // ����� ��ǥ�� ��ġ ������Ʈ
        transform.position = new Vector3(x, y, z);
    }
}
