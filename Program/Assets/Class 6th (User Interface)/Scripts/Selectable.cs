using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    [SerializeField] Text uiText;
    void Start()
    {
        uiText = GetComponentInChildren<Text>();
    }

    public void Enter()
    {
        uiText.fontSize = 100;
    }

    public void Exit()
    {
        uiText.fontSize = 75;
    }

    public void Down()
    {
        uiText.fontSize = 50;
    }
}
