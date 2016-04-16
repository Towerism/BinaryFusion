using UnityEngine;
using System.Collections;

public class PlayerShip : MonoBehaviour {

  public float speed = 5f;

  private Vector3 moveDirection = Vector3.zero;
  
  public void Start() {
  }

  public void Move(Vector3 _moveDirection) {
    moveDirection = _moveDirection;
  }
  
  public void Update() {
    performTranslation();
    resetMoveDirection();
  }

  private void performTranslation() {
    transform.Translate(moveDirection * speed * Time.deltaTime);
  }

  private void resetMoveDirection() {
    moveDirection = Vector3.zero;
  }

}
