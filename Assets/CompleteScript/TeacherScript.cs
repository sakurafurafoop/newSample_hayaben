using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherScript : MonoBehaviour {
    float timer;
    int randomNumber;
    bool timerCheck;
    float teacherRotate;
    bool resetCheck = false;

    // Use this for initialization
    void Start () {
        randomNumber = Random.Range(4, 7);
        timerCheck = true;
    }
	
	// Update is called once per frame
	void Update () {
        teacherRotate = this.gameObject.transform.rotation.y;
       
        if(timerCheck == true)
        { 
            timer += Time.deltaTime;
            
            if(timer >= randomNumber)
            {
                
                Turn(180);
                if (teacherRotate >= 1)
                {
                    Stay();
                }
            }
        }else if(timerCheck == false)
        {
            Turn(0);
            if(teacherRotate <= 0)
            {
                ChangeBool();
            }
        }
        
	}

    void Turn(float rotateY)
    {
        float step = 120 * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, rotateY, 0), step);

    }

    void ChangeBool()
    {
        timerCheck = true;
        resetCheck = false;
        randomNumber = Random.Range(4, 7);
        timer = 0;
    }

    void Stay()
    {
        if (resetCheck == false)
        {
           
            float resetNumber = Random.Range(4, 6);
            Invoke("Reset", resetNumber);
            resetCheck = true;
        }

    }


    void Reset()
    {
        timerCheck = false;
        
    }


}
