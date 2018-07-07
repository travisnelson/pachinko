using UnityEngine;
using System.Collections;

public class movecamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1)){
			Vector3 pos1 = new Vector3(0, 1, -10);
			Vector3 pos2 = new Vector3(0, -20, -110);
			Vector3 camera = Camera.mainCamera.transform.position;
			
			if(camera.y == pos1.y){
				Camera.mainCamera.transform.position = pos2;
			} else {
				Camera.mainCamera.transform.position = pos1;
			}
			
			
			//Camera.mainCamera.transform.position
		}
	}
}
