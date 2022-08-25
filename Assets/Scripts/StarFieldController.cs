using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFieldController : MonoBehaviour
{
  private ParticleSystem.Particle[] points;
  private float starDistanceSqr;
  private float starClipDistanceSqr;

  [SerializeField]
  protected Color starColor;

  [SerializeField]
  protected int starMax = 600;

  [SerializeField]
  protected float starSize = 0.35f;

  [SerializeField]
  protected float starDistance = 60f;

  [SerializeField]
  protected float starClipDistance = 15f;


  void Start()
  {
    starDistanceSqr = starDistance * starDistance;
    starClipDistanceSqr = starClipDistance * starClipDistance;

  }

  void Update()
  {
    if (points == null)
    {
      CreateStars();
    }

    for (int i = 0; i < starMax; i++)
    {
      if ((points[i].position - transform.position).sqrMagnitude > starDistanceSqr)
      {
        points[i].position = Random.insideUnitSphere.normalized * starDistance + transform.position;
      }

      if ((points[i].position - transform.position).sqrMagnitude <= starClipDistanceSqr)
      {
        float percentage = (points[i].position - transform.position).sqrMagnitude / starClipDistanceSqr;
        points[i].startColor = new Color(1, 1, 1, percentage);
        points[i].startSize = percentage * starSize;
      }
    }

    GetComponent<ParticleSystem>().SetParticles(points, points.Length);
  }

  private void CreateStars()
  {
    points = new ParticleSystem.Particle[starMax];

    for (int i = 0; i < starMax; i++)
    {
      points[i].position = Random.insideUnitSphere * starDistance + transform.position;
      points[i].startColor = new Color(starColor.r, starColor.g, starColor.b, starColor.a);
      points[i].startSize = starSize;
    }
  }
}
