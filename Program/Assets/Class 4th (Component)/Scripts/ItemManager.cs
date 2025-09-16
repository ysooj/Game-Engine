using NUnit.Framework;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    // C#에서 리스트는 참조 타입

    [SerializeField] Item [ ] items;

    [SerializeField] int count = 0;

    void Start()
    {
        Initialized();
    }

    void Update()
    {
        // GetKey : 키를 꾹 눌렀을 때
        // GetKeyDown : 키를 눌렀을 때
        // GetKeyUp : 키를 뗐을 때
        // 스페이스바를 누를 때마다 무기가 교체되는 기능
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        // 마우스 왼쪽 버튼을 누르면 무기가 사용되는 기능
        // 현재는 Activate 함수가 실행되면서 콘솔 창에 로그가 뜨는 것이 다다.
        if (Input.GetMouseButtonDown(0))
        {
            if (items[count].gameObject.activeSelf)
            {
                items[count].Activate();
            }
        }
    }

    void Initialized()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(false);
        }

        count = items.Length - 1;
    }

    void Swap()
    {
        items[count].gameObject.SetActive(false);

        count = (count + 1) % items.Length;

        items[count].gameObject.SetActive(true);
    }
}
