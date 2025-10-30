using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewItem", menuName = "Game/Enemies")]
public class EnemyDatabase : ScriptableObject
{
    public List<EnemyData> enemies;
}
