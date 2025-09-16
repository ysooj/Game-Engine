using NUnit.Framework;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    // C#에서 리스트는 참조 타입

    [SerializeField] Item [ ] items;

    void Start()
    {
        Initialized();
    }

    void Update()
    {
        // GetKey : 키를 꾹 눌렀을 때
        // GetKeyDown : 키를 눌렀을 때
        // GetKeyUp : 키를 뗐을 때
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < items.Length; i++)
            {
                int count = items.Length - 1 - i;

                items[count].gameObject.SetActive(true);

                items[count - 1].gameObject.SetActive(false);
            }
        }
    }

    void Initialized()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(false);
        }
    }
}
