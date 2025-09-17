using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Pilot : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;
    void Start()
    {

    }

    void Update()
    {
        // Input.GetAxis("Horizontal") ; x�࿡ ����, ���� ���� ��
        // GetAxis�� �ﰢ������ ���� ��ȯ�������� �ʰ�, -1���� 1���� ����? �ٲٸ鼭 ��ȯ�Ѵ�.
        // ���� Ű���忡�� ���� ���� �� �ٷ� ���߰� �ϰ� �ʹٸ� GetAxisRaw�� ����� �Ѵ�.
        direction.x = Input.GetAxisRaw("Horizontal");  // ���� �Է� (A/D �Ǵ� ��/��)
        direction.z = Input.GetAxisRaw("Vertical");    // ���� �Է� (W/S �Ǵ� ��/��)

        // �밢�� �̵� �� �ӵ��� �������� ���� �����ϱ� ���� ���� ����ȭ
        direction.Normalize();

        // ��� � ; P  = P0 + Vt
        //          ; ���� ��ġ = ���� ��ġ + (���� �� �ӵ� �� �ð�)
        transform.position = transform.position + direction * speed * Time.deltaTime;
        // Time.deltaTime : ���� �������� �Ϸ�Ǵ� ��������
        //                  ���� �������� ���۵Ǳ���� ���� �ð��� ��ȯ�ϴ� ���Դϴ�.
    }
}