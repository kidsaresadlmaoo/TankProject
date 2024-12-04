using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class Shooter : MonoBehaviour
{
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;    
    
    private Rigidbody _rigidbody;

    private Coroutine shoot_routine = null;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator Fire()
    {
        while (true)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }


    void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            if (shoot_routine != null)
                StopCoroutine(shoot_routine);

            shoot_routine = StartCoroutine("Fire");
        }
        else
        {
            StopCoroutine("Fire");
            shoot_routine = null;
        }
    }
}
