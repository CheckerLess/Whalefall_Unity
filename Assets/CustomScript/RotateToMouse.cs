using UnityEngine;
using System.Collections;

public class RotateToMouse : MonoBehaviour
{
    //Use these to get the GameObject's positions
    Vector2 m_MyFirstVector;
    Vector2 m_MySecondVector;
    Vector3 MousePos;
    Quaternion m_Angle;

    //You must assign to these two GameObjects in the Inspector
    public GameObject m_MyObject;
    public GameObject m_MySecondObject;

    private void Start()
    {
        m_MyFirstVector = Vector2.zero;
        m_MySecondVector = Vector2.zero;
    }

    void Update()
    {

        //Rotate towards target
        Vector3 targ = m_MySecondObject.transform.position;
        targ.z = 0f;

        Vector3 objectPos = m_MyObject.transform.position + new Vector3(0,1.6f,0);
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        transform.position = objectPos;
    }

    void OnGUI()
    {
        //Output the angle found above
        GUI.Label(new Rect(25, 25, 200, 40), "Angle Between Objects" + m_Angle);
        GUI.Label(new Rect(25, 50, 200, 65), "MouseX" + MousePos.x);
        GUI.Label(new Rect(25, 75, 200, 90), "MouseY" + MousePos.y);
        GUI.Label(new Rect(25, 100, 200, 115), "OBJ_XPOS" + m_MyObject.transform.position.x);
        GUI.Label(new Rect(25, 125, 200, 140), "OBJ_YPOS" + m_MyObject.transform.position.y);
    }
}