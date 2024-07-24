using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;  
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 10f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 20f;
    private bool isTurningLeft = false;
    private bool isTurningRight = false;
    private bool isSpeedingUp = false;
    private bool canMove = true;    private InputActions controls;
    private void Awake()
    {
        controls = new InputActions(); // Assuming PlayerControls is the name of your Input Actions asset
    }

    private void OnEnable() {
        controls.Enable();
        controls.Player.SpeedUp.started += ctx => isSpeedingUp = true;
        controls.Player.SpeedUp.canceled  += ctx => isSpeedingUp = false;
        controls.Player.RotateToLeft.started  += ctx => isTurningLeft = true;
        controls.Player.RotateToLeft.canceled   += ctx => isTurningLeft = false;
        controls.Player.RotateToRight.started  += ctx => isTurningRight = true;
        controls.Player.RotateToRight.canceled   += ctx => isTurningRight = false;
    }

    private void OnDisable() {
        controls.Disable();
        controls.Player.SpeedUp.started -= ctx => isSpeedingUp = true;
        controls.Player.SpeedUp.canceled -= ctx => isSpeedingUp = false;
        controls.Player.RotateToLeft.started -= ctx => isTurningLeft = true;
        controls.Player.RotateToLeft.canceled -= ctx => isTurningLeft = false;
        controls.Player.RotateToRight.started -= ctx => isTurningRight = true;
        controls.Player.RotateToRight.canceled -= ctx => isTurningRight = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    private void Update() {
        if(canMove){
            if(isTurningRight)
                RotateToRight();
            else if(isTurningLeft)
                RotateToLeft();
            
            if(isSpeedingUp)
                ReactToBoost();
            else
                surfaceEffector2D.speed = normalSpeed;
        }
    }
    public void DisableControls()
    {
        canMove = false;
    }
    private void ReactToBoost()
    {
        Debug.Log("Boost button clicked.");
        surfaceEffector2D.speed = boostSpeed;
    }

    private void RotateToLeft()
    {
        Debug.Log("LEft button clicked.");
        rb2d.AddTorque(torqueAmount);
    }

    private void RotateToRight()
    {
        Debug.Log("Right button clicked.");
        rb2d.AddTorque(-torqueAmount);
    }
}
