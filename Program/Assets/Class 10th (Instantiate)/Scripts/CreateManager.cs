using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float time;
    [SerializeField] int coroutineCount;

    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> list = new List<GameObject>();

    void Start()
    {
        //  // new�� ���� ����ϴٰ� ���� �ȴ�.
        //  GameObject clone = Instantiate(prefab);
        //  
        //  clone.transform.position = new Vector3(1, 1, 1);

        Create();

        StartCoroutine(Coroutine());
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

    IEnumerator Coroutine()
    {
        while(coroutineCount < list.Count)
        {
            int index = Random.Range(0, list.Count);

            yield return new WaitForSeconds(5f);

            if (list[index].activeSelf)
            {
                index = (index + 1) % list.Count;
            }

            list[index].SetActive(true);
            Debug.Log("���� ����");

            coroutineCount++;
            
            //  GameObject monster = list[i];
            //  monster.transform.position = new Vector3(i - (list.Count % 2) - 1, 0, 0);

            //  monster.SetActive(false);
            //  Debug.Log("5�� �� ���� ����");
            //  
            //  
            //  //  monster.SetActive(true);
            //  Debug.Log("���� ����");
        }

        Debug.Log("�ڷ�ƾ ����");
    }

    //  void Update()
    //  {
    //      // 5�ʸ��� �α׸� ����ָ� �ȴ�.
    //      time += Time.deltaTime;
    //  
    //      if (time >= 5.0f)
    //      {
    //          Debug.Log("event call");
    //          time = 0.0f;
    //      }
    //  }
}