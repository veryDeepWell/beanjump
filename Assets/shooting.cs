using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;

    public float shootForce, upwardForce;

    public float timeBetweenShooting, timeBetweenShots;

    public Rigidbody playerRb;

    public Camera fpsCam;
    public Transform attackPoint;

    public bool allowInvoke = true;

    private void Update()
    {
        //MyInput();
    }

    private void MyInput()
    {
        if (Input.GetKey(KeyCode.Mouse0)) 
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Ray ray = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        Vector3 targetPoint = ray.GetPoint(75);

        Vector3 direction = targetPoint - attackPoint.position;

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet

        currentBullet.transform.forward = direction.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(direction.normalized * shootForce, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);

        if (allowInvoke)
        {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;
            playerRb.AddForce(-direction.normalized, ForceMode.Impulse);
        }
    }

    private void ResetShot()
    {
        allowInvoke = true;
    }
}
