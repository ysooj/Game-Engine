using UnityEngine;

public class Smelter : MonoBehaviour
{         // Smelter ; 제련소
    [SerializeField] float progress;
    [SerializeField] int count;

    public void Create()
    {
        Debug.Log("Create...");
    }

    public void Process(float progress)
    {
        // ### 아이템 제작 상황 ###
        // 어느 시점에 event를 넣고, 예를 들어, 매개변수 progress로 10을 넣으면 
        // 진행률이 10%가 되고, 100%가 된 후 다시 0%가 되게 하면 된다.

        this.progress += progress;

        Debug.Log("Progress : " + this.progress + "%");

        this.progress = this.progress % 100;
    }

    public void Enhance (int count)
    {
        this.count += count;

        Debug.Log("Enhance Count : " + this.count);
    }
}