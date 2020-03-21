using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TSControl : MonoBehaviour
{
    public Button student1;
    public Button student2;
    public Button student3;

    public Button teacher1;
    public Button teacher2;
    public Button teacher3;

    public Slider score;

    void OnStart()
    {
        student1.onClick.AddListener(StudentClick);
        student2.onClick.AddListener(StudentClick);
        student3.onClick.AddListener(StudentClick);

        teacher1.onClick.AddListener(TeacherClick);
        teacher2.onClick.AddListener(TeacherClick);
        teacher3.onClick.AddListener(TeacherClick);

        Debug.Log("Starting slide script" + score.value);
    }

    void StudentClick()
    {
        score.value += 0.1f;
        Debug.Log("Raising slider score" + score.value);
    } 

    
    void TeacherClick()
    {
        score.value -= 0.1f;
        Debug.Log("Lowering slider score" + score.value);
    } 
}
