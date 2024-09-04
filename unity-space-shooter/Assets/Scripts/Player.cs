using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Score
    public int points;
    //Projectile object
    public Projectile projectilePrefab;
    //Shoot interval
    public float shootInterval = 0.3f;
    //Shoot time counter
    public float shootTimer;
    //shoot point position reference
    public Transform shootPoint;

    // Update is called once per frame
    void Update()
    {
        //Move spaceship
        Move();
        //Update shoot time counter
        shootTimer -= Time.deltaTime;
        //Shoot
        Shoot();
    }

    //Move spaceship
    void Move()
    {
        //On left click pressed
        if (Input.GetMouseButton(0))
        {
            //Mouse position
            Vector2 mousePos = Input.mousePosition;
            //Get mouse position in scene
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            //Set new spaceship position
            transform.position = realPos;
        }
    }

    //Shoot
    void Shoot()
    {
        //On shoot time counter is equal or less than zero
        if (shootTimer <= 0)
        {
            //Generate new projectile
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            //Restart shoot time counter
            shootTimer = shootInterval;
        }
    }
}
