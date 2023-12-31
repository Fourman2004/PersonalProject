using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Input playerControls;
    Public bool sprint;
	
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        playerControls = GetComponent<Input>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
