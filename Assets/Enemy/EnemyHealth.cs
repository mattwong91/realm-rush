using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))] //NOTE creates a dependency on Enemy script/class
public class EnemyHealth : MonoBehaviour
{
  [SerializeField] int maxHp = 5;

  [Tooltip("Adds amount to maxHP when enemy is defeated")]
  [SerializeField] int difficultyRamp = 1;

  int currentHp = 0;

  Enemy enemy;

  void OnEnable()
  {
    currentHp = maxHp;
  }

  void Start()
  {
    enemy = GetComponent<Enemy>();
  }

  void OnParticleCollision(GameObject other)
  {
    currentHp--;
    if (currentHp < 1)
    {
      gameObject.SetActive(false);
      maxHp += difficultyRamp;
      enemy.RewardGold();
    }
  }
}
