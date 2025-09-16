using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        // Awake : 객체가 생성될 때 호출되며, 스크립트가 비활성화되어 있을 때에도 호출되고
        //         단 한 번만 호출되는 이벤트 함수입니다.

        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable : 객체가 활성화되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnEnable");

        // 객체를 스폰하고 풀링할 때 사용한다.
        // 예 : 총구 위치에서 총알이 총구 방향으로 나간다.
    }

    private void Start()
    {
        // Start : 객체가 생성되었을 때 호출되며, 단 한 번만 호출되는 이벤트 함수입니다.

        Debug.Log("Start");
    }

    // Awake와 Start를 나누어놓은 이유
    // - Awake는 객체 간의 의존 관계 없이, 자기 자신이 초기화되어야 할 데이터를 세팅할 때 사용합니다.
    // - Start는 다른 컴포넌트나 오브젝트와의 상호작용이 필요한 초기화를 진행할 때 사용합니다.
    //   (모든 Awake가 끝난 뒤에 호출되므로, 다른 객체들이 모두 초기화된 상태를 보장받을 수 있음)

    private void FixedUpdate()
    {
        // FixedUpdate : timestep에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수입니다.

        Debug.Log("FixedUpdate");

        // 물리 관련 작업을 여기서 해준다.
        // 프레임이 튀어서 부딫쳐야 하는데 통과되는 현상이 발생하지 않게 하기 위해서다.
    }

    private void Update()
    {
        // Update : 객체가 활성화되는 동안, 매 프레임마다 호출되는 이벤트 함수입니다.

        Debug.Log("Update");

        // (키)입력(Input System)과 같은 작업을 여기서 해준다.
        // 고정된 간격으로 FixedUpdate가 이루어지는데, 혹시 그 간격 사이에 입력이 들어오면 안 되니까
        // Update에서 매 프레임마다 호출하여 처리하는 것이다.
    }

    private void LateUpdate()
    {
        // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수입니다.

        Debug.Log("LateUpdate");

        // - 카메라가 플레이어를 따라갈 때 주로 사용합니다.
        //   (플레이어가 이동한 후 위치를 정확히 추적할 수 있음)
        // - 트랜스폼 변경 후, 후처리가 필요한 경우에 적합합니다.
        // - 애니메이션, 연출, 뷰 관련 작업에 자주 활용됩니다.

        // 단, 물리 기반 움직임이나 카메라 제어는 LateUpdate에서 처리하면
        // 업데이트 주기 차이로 인해 화면이 떨릴 수 있습니다.
        // 이런 경우에는 FixedUpdate를 사용하는 것이 더 적절합니다.
    }

    private void OnDisable()
    {
        // OnDisable : 객체가 비활성화되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnDisable");

        // 예 : 날아간 총알을 다시 총구 위치로 reset시킨다.
    }

    private void OnDestroy()
    {
        // OnDestroy : 객체가 삭제되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnDestroy");
    }
}