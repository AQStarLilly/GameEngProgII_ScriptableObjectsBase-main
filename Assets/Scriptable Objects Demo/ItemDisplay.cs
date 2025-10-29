using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public TextMeshProUGUI itemNameText;
    public Image itemIcon;

    public void DisplayItem(string name, Sprite icon)
    {
        itemNameText.text = name;
        itemIcon.sprite = icon;
        //fdsfesdfds
    }
}
