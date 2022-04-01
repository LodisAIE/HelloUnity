using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmitterBehaviour : MonoBehaviour
{

    private BulletBehaviour _bullet;
    private float _bulletForce;

    public void Fire()
    {
        GameObject bullet = Instantiate(_bullet.gameObject, null);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        BulletBehaviour bulletBehaviour = bullet.GetComponent<BulletBehaviour>();

    }
}
