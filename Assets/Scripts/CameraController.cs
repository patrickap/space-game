using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField]
  protected GameObject target;

  [SerializeField]
  protected Vector3 offset = new Vector3(0, 6, -20);

  [SerializeField]
  protected float speed = 5f;

  void Update()
  {
    if (target == null)
    {
      return;
    }

    Movement();
    Rotation();
  }

  void Movement()
  {
    // test
    var targetPosition = target.transform.position + (target.transform.rotation * offset);
    transform.position = Vector3.Slerp(transform.position, targetPosition, speed * Time.deltaTime);
  }

  void Rotation()
  {
    var targetForward = target.transform.position - transform.position;
    transform.rotation = Quaternion.LookRotation(targetForward, target.transform.up);
  }
}