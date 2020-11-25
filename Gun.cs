using UnityEngine;

public class Gun: MonoBehaviour
{

	public float damage = 10f;
	public float range = 100f;
	public GameObject ImpactEffect;

	public Camera fpsCam;
	public ParticleSystem muzzleflash;

   // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
        	Shoot();
        }
    }

    void Shoot ()
    {

    muzzleflash.Play();
	RaycastHit hit;
	if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range));
	{
		Debug.Log(hit.transform.name);

		Enemy target = hit.transform.GetComponent<Enemy>();
		if (target != null)
		{
			target.TakeDamage(damage);
      }

		Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
	}

 } }