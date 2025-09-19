using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    // 제목 텍스트 컴포넌트를 에디터에서 연결하거나, 런타임에 캐싱
    [SerializeField] Text titleText;
    private void Awake()
    {
        // 캐싱 기법
        // titleText를 한 번만 GetComponentInChildren<Text>()로 찾고 저장하여 성능 최적화
        titleText = GetComponentInChildren<Text>();
    }

    // 마우스를 올리거나 선택 시 호출
    public void Enter()
    {
        titleText.fontSize = 100;   // 강조된 폰트 크기
    }

    // 마우스를 뗐을 때 호출
    public void Exit()
    {
        titleText.fontSize = 75;    // 기본 폰트 크기
    }

    // 눌렀을 때 호출
    public void Down()
    {
        titleText.fontSize = 50;    // 눌린 상태 폰트 크기
    }
}
