using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ref. ItemDisplay")]
    [SerializeField] ItemDisplay itemDisplay;


    [Header("Test Item Data")]
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemIcon;

    

    void Start()
    {
        itemDisplay.DisplayItem(itemName, itemIcon);
    }
}