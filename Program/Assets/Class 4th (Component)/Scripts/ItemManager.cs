using NUnit.Framework;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    // C#���� ����Ʈ�� ���� Ÿ��

    [SerializeField] Item [ ] items;

    int count = 0;

    void Start()
    {
        Initialized();
    }

    void Update()
    {
        // GetKey : Ű�� �� ������ ��
        // GetKeyDown : Ű�� ������ ��
        // GetKeyUp : Ű�� ���� ��
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
