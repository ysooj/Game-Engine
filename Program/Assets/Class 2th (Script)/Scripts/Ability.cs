using UnityEngine;

// 직렬화 가능한 클래스임을 Unity에 알리는 특성(attribute)
// 이렇게 하면 Unity 인스펙터에서 이 클래스의 필드를 볼 수 있음
[System.Serializable]
public class Ability
{
    // [SerializeField] : 필드가 private이더라도 Unity 인스펙터에 노출되도록 함
    // 즉, 코드 상에서는 외부에서 접근할 수 없지만, 에디터에서는 값을 설정하거나 확인할 수 있음
    [SerializeField] int strength;
    [SerializeField] int intelligence;
    [SerializeField] int dexterity;
    [SerializeField] int wisdom;
}