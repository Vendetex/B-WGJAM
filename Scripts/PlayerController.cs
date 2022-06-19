using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;

    private void Update() {
        Vector3 plrInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position = transform.position + plrInput.normalized * speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, GameObject.FindWithTag("GameAreaBounds").transform.Find("LeftBound").position.x, GameObject.FindWithTag("GameAreaBounds").transform.Find("RightBound").position.x),
                                        Mathf.Clamp(transform.position.y, GameObject.FindWithTag("GameAreaBounds").transform.Find("BottomBound").position.y, GameObject.FindWithTag("GameAreaBounds").transform.Find("TopBound").position.y),
                                        0);
    }

    
}
