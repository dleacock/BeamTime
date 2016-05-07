using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class ScrollingBackground : MonoBehaviour {

    public List<GameObject> panels;
    public List<GameObject> blocks;


    int numberOfPanels = 0;

    private float blockMin = -.40f;
    private float blockMax = .40f;

    void Awake() {
        if(panels != null) {
            numberOfPanels = panels.Count;
        }

        if(blocks != null) {

            foreach (var block in blocks) {
                Vector3 pos = block.transform.position;
                pos.y = Random.Range(blockMin, blockMax);
                block.transform.position = pos;
            }

        }


    }


	void OnTriggerEnter2D(Collider2D collider) {
        
        float width = ((BoxCollider2D)collider).size.x;

        Vector3 pos = collider.transform.position;
        pos.x += width * numberOfPanels;

        if (collider.CompareTag("Blocks")) {
            pos.y = Random.Range(blockMin, blockMax);
        }


        collider.transform.position = pos;
    }
}
