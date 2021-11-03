using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Animations;
public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    [SerializeField]
    private float _fireRate = 0.45f;
    private float _canFire = 0.0f;
    public AudioSource SoundShoot;
    public Animator BallestaMovent;
<<<<<<< HEAD

=======
>>>>>>> 610c6a5db1a5110ffb960f4bdd3d1ff3dfadc3c2

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
           
        }

    }

    void Shoot()
    {
        if (Time.time > _canFire)
        {
            GameObject bala = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            _canFire = Time.time + _fireRate;
            SoundShoot.Play();
            BallestaMovent = GetComponent<Animator>();
            BallestaMovent.SetTrigger("DisparoBallesta");
<<<<<<< HEAD
         
=======
>>>>>>> 610c6a5db1a5110ffb960f4bdd3d1ff3dfadc3c2
        }


    }
}
