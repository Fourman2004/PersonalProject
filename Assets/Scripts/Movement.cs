using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Input playerControls;
    public int speedMultiplier, stamina;


    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody rb;

    private Vector3 movementInput;


    // Start is called before the first frame update
    void Start()
    {
        playerControls = new Input();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput = playerControls.Player.Movement.ReadValue<Vector3>();
        rb.velocity = movementInput * speed;
        if (playerControls.Player.Sprint.IsPressed() && stamina != 0)
        {
            speed = speed * speedMultiplier;
            stamina--;
        }
    }

    private void OnEnable()
    {
        playerControls.Player.Enable();
    }

    private void OnDisable()
    {
        playerControls.Player.Disable();
    }
}
