using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    private Camera mainCamera;
    private Controls _controls;

    private Outline currentOutilinedObject;

    public Controls Controls
    {
        set
        {
            _controls = value;
        }
        get
        {
            return _controls;
        }
    }

    private void Awake()
    {
        Controls = new Controls();
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }

    private void Start()
    {
        Controls.Mouse.Click.started += _ => StartedClick();
        Controls.Mouse.Click.performed += _ => EndedClick();
    }

    private void FixedUpdate()
    {
            DetectObject();
    }

    private void StartedClick()
    {
        
    }

    private void EndedClick()
    {
            DetectClick();
    }

    private void DetectClick()
    {
        Ray ray = mainCamera.ScreenPointToRay(Controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                IClickable clickable = hit.transform.GetComponent<IClickable>();
                if(clickable != null)
                {
                    clickable.OnClick();
                }
              
            }

        }
        else
        {
            if (currentOutilinedObject != null)
            {
                currentOutilinedObject.enabled = false;
                currentOutilinedObject = null;
            }
        }
    }

   
    private void DetectObject()
    {

        Ray ray = mainCamera.ScreenPointToRay(Controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider != null)
            {
              //  Debug.Log("Colidiu com = " + hit.collider.gameObject.name);
                SetOutlineToObject(hit);
            }
         
        }
        else
        {
            if (currentOutilinedObject != null)
            {
                currentOutilinedObject.enabled = false;
                currentOutilinedObject = null;
            }
        }
    }

    private void SetOutlineToObject(RaycastHit hit)
    {
        Outline outline = hit.collider.transform.GetComponent<Outline>();
        if (outline != null)
        {
            if (currentOutilinedObject != null)
            {
                if (currentOutilinedObject.gameObject != outline.gameObject)
                {
                    currentOutilinedObject.enabled = false;
                    currentOutilinedObject = outline;
                    outline.enabled = true;
                }
            }
            else
            {
                currentOutilinedObject = outline;
                outline.enabled = true;
            }
        }
    }
}
