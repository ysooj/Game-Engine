using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float time;

    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> list = new List<GameObject>();

    void Start()
    {
        //  // new�� ���� ����ϴٰ� ���� �ȴ�.
        //  GameObject clone = Instantiate(prefab);
        //  
        //  clone.transform.position = new Vector3(1, 1, 1);

        Create();
    }

    void Create()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, transform);
            //clone.transform.position = new Vector3(i - 2, 0, 0);  // ���� ���� �ڵ�
            clone.SetActive(false);
            list.Add(clone);
        }
    }

    void Update()
    {
        // 5�ʸ��� �α׸� ����ָ� �ȴ�.
        time += Time.deltaTime;

        if (time >= 5.0f)
        {
            Debug.Log("event call");
            time = 0.0f;
        }
    }
}