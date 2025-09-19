using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    // ���� �ؽ�Ʈ ������Ʈ�� �����Ϳ��� �����ϰų�, ��Ÿ�ӿ� ĳ��
    [SerializeField] Text titleText;
    private void Awake()
    {
        // ĳ�� ���
        // titleText�� �� ���� GetComponentInChildren<Text>()�� ã�� �����Ͽ� ���� ����ȭ
        titleText = GetComponentInChildren<Text>();
    }

    // ���콺�� �ø��ų� ���� �� ȣ��
    public void Enter()
    {
        titleText.fontSize = 100;   // ������ ��Ʈ ũ��
    }

    // ���콺�� ���� �� ȣ��
    public void Exit()
    {
        titleText.fontSize = 75;    // �⺻ ��Ʈ ũ��
    }

    // ������ �� ȣ��
    public void Down()
    {
        titleText.fontSize = 50;    // ���� ���� ��Ʈ ũ��
    }
}
