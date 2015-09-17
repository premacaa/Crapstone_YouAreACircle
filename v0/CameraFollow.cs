using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public PlayerController player;
    private Vector3 playerPos;
    private float offset;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        playerPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        offset = player.transform.position.x - playerPos.x;
        transform.position = new Vector3(transform.position.x + offset, transform.position.y, transform.position.z); 
        playerPos = player.transform.position;
	}
}
