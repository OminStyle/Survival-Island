using UnityEngine;
using System.Collections;
public class Animator : MonoBehaviour
{
	public float xStartPosition = -1.0f;
	public float xEndPosition = 0.5f;
	public float speed = 1.0f;
	float startTime;

	void Start()
	{
		startTime = Time.time;
	}

	void Update()
	{
		Vector3 pos =
			new Vector3( Mathf.Lerp( xStartPosition, xEndPosition,
				(Time.time - startTime) * speed ),
				transform.position.y, transform.position.z );
		transform.position = pos;
	}
}