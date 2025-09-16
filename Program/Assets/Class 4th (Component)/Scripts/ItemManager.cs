using NUnit.Framework;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    // C#���� ����Ʈ�� ���� Ÿ��

    [SerializeField] Item [ ] items;

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
