using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltMovement : MonoBehaviour
{
    public float speed;
    public Vector3 target;
    public bool isMoving = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit placeInfo;
            if (Physics.Raycast(ray, out placeInfo))
            {
                if (placeInfo.collider.CompareTag("Ground"))
                {
                    target = new Vector3(placeInfo.point.x, transform.position.y, placeInfo.point.z);
                    isMoving = true;
                }
            }
        }

        if (isMoving == true)
        {
            transform.LookAt(target);
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            if (Vector3.Distance(target, transform.position) < 0.01)
            {
                isMoving = false;
            }
        }
    }
}
