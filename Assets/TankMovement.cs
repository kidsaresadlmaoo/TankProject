using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class TankMovement : MonoBehaviour
{
    //[SerializeField] private float _linearSpeed = 0.1f;
   // [SerializeField] private float _rollSpeed = 0.1f;
   //[SerializeField] private float _rollForce = 0.1f;
   //[SerializeField] private float _spinForce = 0.1f;
    [SerializeField] private float _spinSpeed;
    [SerializeField] private float _linearForce;

    //private bool _boosterInput = false;
    private float _rollInput;
    private float _spinInput;
    
    private Rigidbody _rigidbody;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    { 
        //Debug.Log("kikou");

        _rigidbody.AddForce(transform.forward * (_rollInput * _linearForce));
        _rigidbody.AddRelativeTorque(0, _spinInput * _spinSpeed, 0);
        
        //Debug.Log("kaki");

    }
    
    void OnForwardBackward(InputValue value)
    {
        Debug.Log("kakou");
        _rollInput = value.Get<float>();
    }
    
    void OnLeftRight(InputValue value)
    {
        Debug.Log("kaki");

        _spinInput = value.Get<float>();
        
        Debug.Log("kikou");
    }
}
