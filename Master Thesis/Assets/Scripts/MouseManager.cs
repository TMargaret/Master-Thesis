using UnityEngine;
using System.Collections;

public class MouseManager : MonoBehaviour {

	public GameObject selectedObject;
	// Use this for initialization
	void Start () {
	
	}
		
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo)) {

			Debug.Log ("Mouse is over:" + hitInfo.collider.name);
			GameObject hitObject = hitInfo.transform.root.gameObject;

			SelectObject (hitObject);
		} else {
			ClearSelection ();
		}

			
	}

	void SelectObject(GameObject obj){
		if (selectedObject != null) {
			if (obj == selectedObject)
				return;

			ClearSelection ();
		}
		selectedObject = obj;
	
	}

	void ClearSelection(){
		selectedObject = null;
	}

}
