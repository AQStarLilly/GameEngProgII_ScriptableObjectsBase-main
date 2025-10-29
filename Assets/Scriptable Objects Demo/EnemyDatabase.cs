using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Game/Enemies")]
public class EnemyDatabase : ScriptableObject
{
    public string enemyType;
    public int enemyHealth;
}
