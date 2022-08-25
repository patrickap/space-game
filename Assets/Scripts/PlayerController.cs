using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  protected float speed = 50f;

  [SerializeField]
  protected float agility = 50f;

  void Update()
  {
    Movement();
    Rotation();
  }

  void Movement()
  {
    if (Input.GetKey(KeyCode.Space))
    {
      transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }
  }

  void Rotation()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      transform.Rotate(new Vector3(agility * Time.deltaTime, 0, 0));
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      transform.Rotate(new Vector3(-agility * Time.deltaTime, 0, 0));
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.Rotate(new Vector3(0, 0, agility * Time.deltaTime));
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.Rotate(new Vector3(0, 0, -agility * Time.deltaTime));
    }
  }
}
