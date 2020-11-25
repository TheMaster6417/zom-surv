using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public GameObject BloodEffect;

    public void TakeDamage (float amount)
    {
    	health -= amount;
    	if (health <= 29)
    	{
    		Instantiate(BloodEffect);
    	}
    	if (health <= 0f)
    	{
    		die();
    	}
 
   }

   void die ()
   {
   	Destroy(gameObject);
   }


}


