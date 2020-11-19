/*
* Author - @Shreyansh Anchlia 
* ©SquareDragon Games
*/

using UnityEngine;

public class MouseMove : MonoBehaviour
{
	public Camera cam;
	public Transform pivot;
	public Transform target;

	public float speed = 1f;
	public float panSpeed = 0.001f;

	public float minYBounds, maxYBounds;
	int isRotating = 0; //1 = anticlockwise, -1 = clockwise

	Vector2 prevPos;
	Vector3 cameraPosition;


	private void Update()
	{
		cameraPosition = cam.transform.position;
		pivot.Rotate(Vector3.up, isRotating *  speed);
		if(Input.GetMouseButton(0) && isRotating == 0)
		{
			cameraPosition.y = Mathf.Clamp(cameraPosition.y + (prevPos.y - Input.mousePosition.y) * panSpeed, minYBounds, maxYBounds);
			cam.transform.position = cameraPosition;
		}
		cam.transform.LookAt(target);
		prevPos = Input.mousePosition;
	}
	public void AnticlockWiseRotate()
	{
		isRotating++;
	}
	public void ClockWiseRotate()
	{
		isRotating--;
	}
}
