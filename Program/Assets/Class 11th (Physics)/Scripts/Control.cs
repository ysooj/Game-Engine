using UnityEngine;

// ForceMode
// - Force : 지속적인 힘 (무게 o) => 차량 이동
// - Acceleration : 지속적인 가속도 (무게 x) => 마법, 커스텀 중력(인공 중력)
// - Impulse : 순간적인 힘 (무게 o) => 점프, 폭발
// - VelocityChange : 순간적인 속도 (무게 x) => 대시, 텔레포트

public class Control : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] ForceMode forceMode;
    private float originalSpeed;

    void Start()
    {
        originalSpeed = speed;
        forceMode = ForceMode.Force;
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    private void FixedUpdate()
    {
        // .AddForce(방향, 힘의 방식)의 방법으로 만들자.
        rigidBody.AddForce(direction * speed, forceMode);
    }

    public void Soar()
    {
        speed = 0.7f;
        direction = Vector3.up;
        forceMode = ForceMode.Impulse;
    }

    public void Revert()
    {
        speed = originalSpeed;
        direction = Vector3.zero;
        forceMode = ForceMode.Force;
    }
}
