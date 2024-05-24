using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float mouseSpeed;
    public Transform cameraTransform;

    float camAngle = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var mouseX = Input.GetAxis("Mouse X");
        var mouseY = Input.GetAxis("Mouse Y");

        transform.position +=  horizontal * transform.right * speed * Time.deltaTime;
        transform.position +=  vertical * transform.forward * speed * Time.deltaTime;

        transform.Rotate(Vector3.up, mouseX * mouseSpeed);

        // Calcula
        camAngle += mouseY * mouseSpeed;

        // Limita
        camAngle = Mathf.Clamp(camAngle, -90f, 90f);


        // Aplica
        cameraTransform.localRotation = Quaternion.Euler(-camAngle, 0f, 0f);
    }
}
