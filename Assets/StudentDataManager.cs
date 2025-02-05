using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentDataManager : MonoBehaviour
{

    //This for student data
    public InputField Name;
    public InputField Age;
    public InputField Student_Number;
    public InputField Section;

    //This for searching it up
    public InputField Search;

    public void SaveStudentData()
    {
        string StudentName = Name.text;
        int Age, Student_Number;
        string SectionName = Section.text;
    }

    public void LoadStudentData()
    {

    }
}
