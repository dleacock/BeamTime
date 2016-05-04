using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollingBackground : MonoBehaviour {

    public List<GameObject> panels;
    int numberOfPanels = 0;

    void Awake() {
        if(panels != null) {
            numberOfPanels = panels.Count;
        }
    }


	void OnTriggerEnter2D(Collider2D collider) {
         Debug.Log(collider.name);

        float width = ((BoxCollider2D)collider).size.x;

        Vector3 pos = collider.transform.position;
        pos.x += width * numberOfPanels;
        collider.transform.position = pos;
    }
}
