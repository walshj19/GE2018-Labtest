using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {
    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;

	private void Awake()
	{
        SpawnFormation();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SpawnFormation(){
        for (int i = 0; i < followers; i++)
        {
            float horizontalOffset;
            float verticalOffset;
            float level;

            if (i%2 == 0)
            {
                //even level
                level = i / 2;
            }
            else
            {
                // odd level
                level = (i / 2) + 1;
            }

            verticalOffset = level*gap;

            if (i%2 == 1)
            {
                //left side
                horizontalOffset = -verticalOffset;
            }
            else
            {
                //right side
                horizontalOffset = verticalOffset;
            }

            // calculate the posion of the follower
            Vector3 offset = new Vector3();
            offset.x += horizontalOffset;
            offset.z += verticalOffset;
            offset.y = transform.position.y;

            // adjust the rotation
            Quaternion rotation = transform.rotation;

            GameObject follower = Instantiate<GameObject>(prefab);
            follower.transform.position += offset;
            follower.transform.rotation = rotation;

            // assign the path behaviors
            if(i == 0){
                // assign leader behavior

            }
            else
            {
                //assign the offset persue behavior
            }
        }
    }
}
