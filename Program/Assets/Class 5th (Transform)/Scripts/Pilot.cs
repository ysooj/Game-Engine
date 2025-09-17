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
        // Input.GetAxis("Horizontal") ; x축에 대한, 수평에 대한 값
        // GetAxis는 즉각적으로 값을 반환시켜주지 않고, -1부터 1까지 점차? 바꾸면서 반환한다.
        // 따라서 키보드에서 손을 뗐을 때 바로 멈추게 하고 싶다면 GetAxisRaw로 해줘야 한다.
        direction.x = Input.GetAxisRaw("Horizontal");  // 수평 입력 (A/D 또는 ←/→)
        direction.z = Input.GetAxisRaw("Vertical");    // 수직 입력 (W/S 또는 ↑/↓)

        // 대각선 이동 시 속도가 빨라지는 것을 방지하기 위해 벡터 정규화
        direction.Normalize();

        // 등속 운동 ; P  = P0 + Vt
        //          ; 다음 위치 = 현재 위치 + (방향 × 속도 × 시간)
        transform.position = transform.position + direction * speed * Time.deltaTime;
        // Time.deltaTime : 이전 프레임이 완료되는 시점부터
        //                  현재 프레임이 시작되기까지 지난 시간을 반환하는 값입니다.
    }
}