using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed, cameraSens;
    [SerializeField] private GameObject cam;
    private Rigidbody _rb;
    private float camRotationX = 0, camRotationY = 0;
    // Start is called before the first frame update
    void Start()
    {
        LockCursorandHide();
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.onLoad)
        {
            Walking();
            MoveCamera();
        }
    }
    private void Walking()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 moveBy = transform.right * x + transform.forward * z;
        Run();
        _rb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);
    }
    private void Run()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            speed *= 1.5f;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            speed /= 1.5f;
    }
    private void LockCursorandHide()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void MoveCamera()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        camRotationX += x;
        camRotationY += y;
        if (camRotationY > 90)
            camRotationY = 90;
        else if (camRotationY < -45)
            camRotationY = -45;
        transform.eulerAngles = new Vector3(0, camRotationX, 0);
        cam.transform.localEulerAngles = new Vector3(camRotationY * -1, 0, 0);
    }
}
