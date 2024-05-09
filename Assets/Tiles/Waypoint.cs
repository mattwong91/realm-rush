using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
  [SerializeField] GameObject towerPrefab;

  [SerializeField] bool isPlaceable;
  public bool IsPlaceable { get { return isPlaceable; } } //NOTE using a property to return state of private variable and be read only

  void OnMouseDown()
  {
    if (isPlaceable)
    {
      Instantiate(towerPrefab, transform.position, Quaternion.identity);
      isPlaceable = false;
    }
  }
}
