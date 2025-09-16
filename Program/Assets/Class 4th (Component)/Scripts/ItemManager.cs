using NUnit.Framework;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    // C#에서 리스트는 참조 타입

    [SerializeField] Item [ ] items;

    int count = 0;

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
            items[count++].gameObject.SetActive(false);

            count = count % items.Length;

            items[count].gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            items[count].Activate();
        }
    }

    void Initialized()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(false);
        }

        items[0].gameObject.SetActive(true);
    }
}
