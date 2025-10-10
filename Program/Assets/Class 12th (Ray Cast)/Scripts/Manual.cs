using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    [SerializeField] Text titleText;
    [SerializeField] Text descriptionText;

    private void Awake()
    {
        Bind("Manual", "The manual shows information about nearby objects, helping players understand each item and reminding them to read before using any equipment.");
    }

    public void Bind(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
    }
}