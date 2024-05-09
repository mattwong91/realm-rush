using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
  [SerializeField] int maxHp = 5;
  int currentHp = 0;

  void Start()
  {
    currentHp = maxHp;
  }

  void OnParticleCollision(GameObject other)
  {
    currentHp--;
    if (currentHp < 1)
    {
      Destroy(gameObject);
    }
  }
}
