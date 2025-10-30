using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    [Header("Database Reference")]
    public EnemyDatabase enemyDatabase;

    [Header("UI Display")]
    public TextMeshProUGUI enemyNameText;
    public Image enemyIconImage;

    private int currentEnemyIndex = 0;

    void Start()
    {
        if (enemyDatabase != null && enemyDatabase.enemies.Count > 0)
        {
            DisplayEnemy(currentEnemyIndex);
        }
    }

    public void DisplayEnemy(int index)
    {
        if (index < 0 || index >= enemyDatabase.enemies.Count) return;

        EnemyData enemy = enemyDatabase.enemies[index];
        enemyNameText.text = enemy.enemyType;
    }

    // Example: Cycle through enemies for testing
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentEnemyIndex = (currentEnemyIndex + 1) % enemyDatabase.enemies.Count;
            DisplayEnemy(currentEnemyIndex);
        }
    }
}
