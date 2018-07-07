using UnityEngine;
using System.Collections;

public class DropMarker : MonoBehaviour {
	private GameObject leftFrame;
	private GameObject rightFrame;
	
	private float lastClick;
	
	// Use this for initialization
	void Start () {
		leftFrame = GameObject.Find ("Left Frame");
		rightFrame = GameObject.Find ("Right Frame");
		lastClick=0;
	}
	
	// Update is called once per frame
	void Update () {
		// update position
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = transform.position.z;
		mousePosition = Camera.mainCamera.ScreenToWorldPoint(mousePosition);
		mousePosition.x *= 2;
		mousePosition.x = Mathf.Min (rightFrame.transform.position.x-(this.transform.localScale.x/2), mousePosition.x);
		mousePosition.x = Mathf.Max (leftFrame.transform.position.x+(this.transform.localScale.x/2), mousePosition.x);
		
		transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
		
		// mouse click
		if((Input.GetMouseButtonDown (0) || Input.GetMouseButton (0)) && lastClick < Time.time - 0.3){			
			Instantiate(Resources.Load("Ball"), this.transform.position, this.transform.rotation);
			lastClick = Time.time;
		}
		
	}
			
}
