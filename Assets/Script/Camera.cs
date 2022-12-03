using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject player;
    public float offsetSmoothing;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z); 
        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
    }
}