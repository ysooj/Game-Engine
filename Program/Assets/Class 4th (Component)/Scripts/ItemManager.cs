using NUnit.Framework;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemManager : MonoBehaviour
{
    // C#���� ����Ʈ�� ���� Ÿ��

    [SerializeField] Item [ ] items;

    [SerializeField] int count = 0;

    void Start()
    {
        Initialized();
    }

    void Update()
    {
        // GetKey : Ű�� �� ������ ��
        // GetKeyDown : Ű�� ������ ��
        // GetKeyUp : Ű�� ���� ��
        // �����̽��ٸ� ���� ������ ���Ⱑ ��ü�Ǵ� ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        // ���콺 ���� ��ư�� ������ ���Ⱑ ���Ǵ� ���
        // ����� Activate �Լ��� ����Ǹ鼭 �ܼ� â�� �αװ� �ߴ� ���� �ٴ�.
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
