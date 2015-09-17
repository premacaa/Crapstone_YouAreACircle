using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

    public float scrollingSpeed;
    public float tile;
    private Vector3 start;


	// Use this for initialization
	void Start () {
        start = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPos = Mathf.Repeat(Time.time * scrollingSpeed, tile);
        transform.position = start + Vector3.left * newPos;
    
    }

}
