using TMPro;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    private TMP_Text tmpText;
    void Start()
    {
        tmpText = GetComponentInChildren<TMP_Text>();
    }

    public void Enter()
    {
        tmpText.fontSize = 100;
    }

    public void Exit()
    {
        tmpText.fontSize = 75;
    }

    public void Down()
    {
        tmpText.fontSize = 50;
    }
}
