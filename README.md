นางสาวจารุวรรณ เค้าเหลือง รหัส 683450184-0

## Class Diagram

```mermaid
classDiagram

class Person {
    -string Name
    +ShowInfo()
}

class Student {
    -string StudentID
    -double Score
    +ShowInfo()
}

class Teacher {
    +ShowInfo()
}

class Course {
    -string CourseName
    -string CourseID
    -Teacher Instructor
    -List~Student~ students
    +AddStudent(Student s)
    +ShowStudents()
    +ShowStatistics()
}

class Grade {
    +GetGrade(double score) string
}

class SystemManager {
    -List~Course~ courses
    +Run()
    +AddCourse()
    +AddStudent()
    +ShowData()
}

Person <|-- Student
Person <|-- Teacher
Course --> Student
Course --> Teacher
SystemManager --> Course
Student --> Grade
