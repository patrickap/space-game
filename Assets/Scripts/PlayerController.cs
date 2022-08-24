using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  protected float speed;

  [SerializeField]
  protected float agility;

  void Update()
  {
    Movement();
    Rotation();
  }

  void Movement()
  {
    var player = transform;

    if (Input.GetKey(KeyCode.Space))
    {
      player.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }
  }

  void Rotation()
  {
    var player = transform;

    if (Input.GetKey(KeyCode.UpArrow))
    {
      player.Rotate(new Vector3(agility * Time.deltaTime, 0, 0));
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      player.Rotate(new Vector3(-agility * Time.deltaTime, 0, 0));
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      player.Rotate(new Vector3(0, 0, agility * Time.deltaTime));
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      player.Rotate(new Vector3(0, 0, -agility * Time.deltaTime));
    }
  }
}
