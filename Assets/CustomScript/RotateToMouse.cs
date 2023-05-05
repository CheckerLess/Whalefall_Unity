using UnityEngine;
using System.Collections;

public class RotateToMouse : MonoBehaviour
{
    //Use these to get the GameObject's positions
    Vector2 m_MyFirstVector;
    Vector2 m_MySecondVector;
    Vector3 MousePos;
    float m_Angle;

    //You must assign to these two GameObjects in the Inspector
    public GameObject m_MyObject;

    private void Start()
    {
        m_MyFirstVector = Vector2.zero;
        m_MySecondVector = Vector2.zero;
        MousePos = Vector3.zero;
        m_Angle = 0.0f;
    }

    void Update()
    {
        //Fetch the first GameObject's position
        m_MyFirstVector = new Vector2(m_MyObject.transform.position.x, m_MyObject.transform.position.y);

        //Fetch the second GameObject's position
        MousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        m_MySecondVector = new Vector2(MousePos.x, MousePos.y);

        //Find the angle for the two Vectors
        m_Angle = Vector2.Angle(m_MyFirstVector, m_MySecondVector);
        

        //update the position
        transform.rotation = Quaternion.Euler(0, 0, m_Angle);
    }

    void OnGUI()
    {
        //Output the angle found above
        GUI.Label(new Rect(25, 25, 200, 40), "Angle Between Objects" + m_Angle);
        GUI.Label(new Rect(25, 50, 200, 65), "MouseX" + MousePos.x);
        GUI.Label(new Rect(25, 75, 200, 90), "MouseY" + MousePos.y);
    }
}