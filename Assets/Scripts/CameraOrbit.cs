using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
  public float lookSensitivity;
  public float minYLook;
  public float maxYLook;

  public Transform camAnchor;
  public bool invertXRotation;
  private float curYRot;

  void Start()
  {
      Cursor.lockState = CursorLockMode.Locked;
  }
  
  //called at the end of each frame
  void LateUpdate()
  {
      //get the mouse x and y inputs
      float x = Input.GetAxis("Mouse X");
      float y = Input.GetAxis("Mouse Y");

      //rotate the player horizontally 
      transform.eulerAngles += Vector3.up * x * lookSensitivity;

      //camera up and down look functionality
     
      curYRot = Mathf.Clamp(curYRot, minYLook, maxYLook);

      Vector3 clampedAngle = camAnchor.eulerAngles;
      clampedAngle.x = curYRot;

      camAnchor.eulerAngles = clampedAngle; 
  }
}
