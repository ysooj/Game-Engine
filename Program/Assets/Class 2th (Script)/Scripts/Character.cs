using UnityEditor.Playables;
using UnityEngine;

// 컴포넌트가 아니기 때문에 MonoBehaviour를 상속받지 않으면 Unity 작업에서 넣어줄 수 없다.
public class Character : MonoBehaviour
{
    // Ability를 가져오려면 이렇게 써줘야 됨
    [SerializeField] Ability ability;
}