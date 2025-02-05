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

    public Text resultText;

    public void SaveStudentData()
    {
        string StudentName = Name.text;
        int age, student_Number;
        string SectionName = Section.text;
        if (!string.IsNullOrEmpty(StudentName)
            && int.TryParse(Age.text, out age)
            && int.TryParse(Student_Number.text, out student_Number)
            && !string.IsNullOrEmpty(SectionName))
        {
            //playerprefs
            PlayerPrefs.SetInt(StudentName + "Age", age);
            PlayerPrefs.SetInt(StudentName + "Student Number", student_Number);
            PlayerPrefs.SetString(StudentName + "Student Section", SectionName);
            PlayerPrefs.Save();
            Debug.Log("Student Data Saved: " + StudentName);

        }
        else
        {
            Debug.Log("Invalid Input");
        }



    }

    public void LoadStudentData()
    {
        string StudentSearch = Search.text;
        if (PlayerPrefs.HasKey(StudentSearch + "Age"))
        {
            int LoadAge = PlayerPrefs.GetInt(StudentSearch + "Age");
            int LoadStudentNumber = PlayerPrefs.GetInt(StudentSearch + "Student Number");
            string LoadSection = PlayerPrefs.GetString(StudentSearch + "Student Section");
            resultText.text = $"Name:  {StudentSearch}\nAge: {LoadAge}\nSN {LoadStudentNumber}\nSection: {LoadSection}m";
        }
        else
        {
            resultText.text = "Student Not Found";
        }
    }
}
