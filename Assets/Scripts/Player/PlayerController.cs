using UnityEngine;
using System.Collections;

[RequireComponent (typeof (PlayerShip))]
public class PlayerController : MonoBehaviour {
  
  private PlayerShip player;
  
  public void Start() {
    player = GetComponent<PlayerShip>();
  }
  
  public void Update() {
    float verticalTranslation = Input.GetAxis("Vertical");
    float horizontalTranslation = Input.GetAxis("Horizontal");
    player.Move(new Vector2(horizontalTranslation, verticalTranslation));
  }
}
