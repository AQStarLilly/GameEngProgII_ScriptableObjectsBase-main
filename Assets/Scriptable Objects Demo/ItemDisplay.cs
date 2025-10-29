using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemData itemData;

    public TextMeshProUGUI itemNameText;
    public Image iconImage;

    public void DisplayItem(string itemName, Sprite itemIcon)
    {
        if(itemNameText != null)
        {
            itemNameText.text = itemData.itemName;
        }
        if(iconImage != null)
        {
            iconImage.sprite = itemData.itemIcon;
        }
    }
}
