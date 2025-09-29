using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;             // 몬스터를 몇 개 생성할지
    [SerializeField] float time;            // (사용 안 함)
    [SerializeField] int coroutineCount;    // 몇 개까지 활성화했는지 추적

    [SerializeField] GameObject prefab;     // 생성할 프리팹
    [SerializeField] List<GameObject> list = new List<GameObject>();    // 미리 생성해둔 객체들 저장
    [SerializeField] List<Vector3> randomPosition;

    void Start()
    {
        //  // new랑 거의 비슷하다고 보면 된다.
        //  GameObject clone = Instantiate(prefab);
        //  
        //  clone.transform.position = new Vector3(1, 1, 1);

        Create();                       // 미리 몬스터들을 비활성화 상태로 생성

        StartCoroutine(Coroutine());    // 코루틴 시작
    }

    // count 수만큼 프리팹을 미리 만들어두고, 비활성화 상태로 리스트에 저장함
    void Create()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, transform);
            //clone.transform.position = new Vector3(i - 2, 0, 0);  // 내가 넣은 코드
            clone.SetActive(false);
            list.Add(clone);
        }
    }

    // 5초마다 리스트에서 랜덤한 오브젝트를 찾아서 활성화 시킴
    // 이미 활성화된 오브젝트면 인덱스를 다음으로 넘기고,
    // coroutineCount가 list.Count에 도달하면 코루틴 종료
    IEnumerator Coroutine()
    {
        while(coroutineCount < list.Count)
        {
            yield return new WaitForSeconds(5f);

            int index = Random.Range(0, list.Count);

            while (list[index].activeSelf)
            {
                index = (index + 1) % list.Count;
            }

            //  int location = (index - list.Count / 2) * 2;
            //  list[index].transform.position = new Vector3(location, 0, 0);
            list[index].SetActive(true);

            list[index].transform.localPosition = randomPosition[index];

            Debug.Log("몬스터 등장");

            coroutineCount++;
            
            //  GameObject monster = list[i];
            //  monster.transform.position = new Vector3(i - (list.Count % 2) - 1, 0, 0);

            //  monster.SetActive(false);
            //  Debug.Log("5초 뒤 몬스터 등장");
            //  
            //  
            //  //  monster.SetActive(true);
            //  Debug.Log("몬스터 등장");
        }

        Debug.Log("코루틴 종료");
    }

    //  void Update()
    //  {
    //      // 5초마다 로그를 찍어주면 된다.
    //      time += Time.deltaTime;
    //  
    //      if (time >= 5.0f)
    //      {
    //          Debug.Log("event call");
    //          time = 0.0f;
    //      }
    //  }
}