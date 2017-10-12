using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter(PointerEventData eventData) {
		Debug.Log ("On Pointer entering");
	}

	public void OnPointerExit(PointerEventData eventData) {
		Debug.Log ("On Pointer EXIT");
	}

	public void OnDrop(PointerEventData eventData) {

		Debug.Log (eventData.pointerDrag.name + "was dropped on " + gameObject.name);
		Draggable sample = eventData.pointerDrag.GetComponent<Draggable> ();
		if (sample != null) {
			sample.originalParent = this.transform;
		}
	}

}
