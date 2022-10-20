using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbableObjectCube : XRGrabInteractable
{
    [SerializeField] float _throwForce = 1000f;

    List<Vector3> _trackedPositions = new List<Vector3>();
    bool _isHeld;

    // Start is called before the first frame update
    void Start()
    {
        _trackedPositions.Clear();
        _isHeld = true;
    }

    // Update is called once per frame
    void Update()
    {
        if( _isHeld )
        {
            if(_trackedPositions.Count > 15)
            {
                _trackedPositions.RemoveAt(0);
            }
            _trackedPositions.Add(transform.position);
        }
    } 

}
