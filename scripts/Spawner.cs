using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] groups;

    public void spawnNext() {
        //random index
        int i = Random.Range(0, groups.Length);
        //spawn goup at current position
        Instantiate(groups[i], transform.position, Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
        //start game with block
        spawnNext();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
