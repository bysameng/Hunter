using UnityEngine;
using System.Collections;

public class InputProcessor{

    public static Vector3 GetWorldPosition(Vector3 screenPosition)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 100f, Physics.DefaultRaycastLayers);
        Vector3 worldPosition = hit.point;
        return worldPosition;
    }


}
