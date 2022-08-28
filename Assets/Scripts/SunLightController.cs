using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLightController : MonoBehaviour
{
  [SerializeField]
  GameObject origin;

  [SerializeField]
  GameObject target;

  void Update()
  {
    transform.position = origin.transform.position;
    transform.LookAt(target.transform.position);
  }
}
