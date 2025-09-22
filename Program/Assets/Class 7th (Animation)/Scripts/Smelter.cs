using UnityEngine;

public class Smelter : MonoBehaviour
{         // Smelter ; ���ü�
    [SerializeField] float progress;
    [SerializeField] int count;

    public void Create()
    {
        Debug.Log("Create...");
    }

    public void Process(float progress)
    {
        // ### ������ ���� ��Ȳ ###
        // ��� ������ event�� �ְ�, ���� ���, �Ű����� progress�� 10�� ������ 
        // ������� 10%�� �ǰ�, 100%�� �� �� �ٽ� 0%�� �ǰ� �ϸ� �ȴ�.

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