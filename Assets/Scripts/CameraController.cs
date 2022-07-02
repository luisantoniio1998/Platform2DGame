using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject target;
	public float followAhead;

	private Vector3 targetPosition;

	public float smoothing;

	public bool followTarget;

	// Use this for initialization
	void Start () {
		followTarget = true;
	}
	
	// Update is called once per frame
	void Update () {

		if(followTarget)
		{
			targetPosition = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

			// this moves the target of the camera ahead of the player
			if(target.transform.localScale.x > 0f)
			{
				targetPosition = new Vector3(targetPosition.x + followAhead, targetPosition.y, targetPosition.z);
			} else {
				targetPosition = new Vector3(targetPosition.x - followAhead, targetPosition.y, targetPosition.z);
			}

			//transform.position = targetPosition;

			transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
		}
	}
}
