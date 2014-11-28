using UnityEngine;
using System.Collections;

public class MouseInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            Vector3 location = InputProcessor.GetWorldPosition(mousePosition);
            DebugCube.main.cube.transform.position = location;
        }
	}
}
