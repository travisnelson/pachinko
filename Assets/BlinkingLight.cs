using UnityEngine;
using System.Collections;

public class BlinkingLight : MonoBehaviour {
	// Use this for initialization
	IEnumerator Start () {
		while(true){
			//enabled = !enabled;
			if(light.intensity==2){
				light.intensity=0;
			} else {
				light.intensity=2;
			}
			yield return new WaitForSeconds(0.5F);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
