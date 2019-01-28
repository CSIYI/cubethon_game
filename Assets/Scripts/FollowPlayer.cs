using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    //set of three numbers, easy to manage x,y,z
    public Vector3 offset;
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
