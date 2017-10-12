using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public Transform originalParent = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnBeginDrag(PointerEventData eventData) {
		Debug.Log ("Begin Dragging");
		originalParent = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent);

		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData eventData) {
		//Debug.Log ("Dragging");
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData) {
		Debug.Log ("Done Dragging");
		this.transform.SetParent (originalParent);
		//GetComponent<CanvasGroup> ().blocksRaycasts = true;

		//EventSystem.current.RaycastAll (eventData);
	}
}
