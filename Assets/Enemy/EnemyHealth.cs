using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
  [SerializeField] int maxHp = 5;
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
      enemy.RewardGold();
    }
  }
}
