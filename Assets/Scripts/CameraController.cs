using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField]
  protected GameObject target;

  [SerializeField]
  protected Vector3 offset;

  [SerializeField]
  protected float speed;

  void Update()
  {
    Movement();
    Rotation();
  }

  void Movement()
  {
    var cameraPosition = transform.position;
    var targetRight = target.transform.right;
    var targetUp = target.transform.up;
    var targetForward = target.transform.forward;
    var targetPosition = target.transform.position - (targetRight * offset.x) - (targetUp * offset.y) - (targetForward * offset.z);
    transform.position = Vector3.Slerp(cameraPosition, targetPosition, speed * Time.deltaTime);
  }

  void Rotation()
  {
    var cameraRotation = transform.rotation;
    var targetRotation = target.transform.rotation;
    transform.rotation = Quaternion.Slerp(cameraRotation, targetRotation, speed * Time.deltaTime);
  }
}