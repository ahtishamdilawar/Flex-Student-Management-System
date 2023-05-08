#pragma once
#define CLASS_DECLSPEC __declspec(dllexport)

#include<iostream>
#include<string>


using namespace std;

class CLASS_DECLSPEC Login
{
	string userName;
	string password;
public:
	Login(string = "", string = "");
	void setUserName(string);
	void setPassword(string);
	string getUserName();
	string getPassword();

};
class CLASS_DECLSPEC Person : public Login
{
private:
	string firstName;
	string lastName;
	string DepName;
	char gender;
	string contactNo;
	string address;
	string qualification;
	string RegDate;
public:
	Person(string = "", string = "",string = "", string = "", string = "", char = NULL, string = "", string = "", string = "");
	virtual ~Person()=0;
		
	//getters and setters

	void setFirstName(string);
	void setLastName(string);
	void setDepName(string);
	void setGender(char);
	void setContactNo(string);
	void setAddress(string);
	void setQualification(string);
	char getGender();
	string getFirstName();
	string getLastName();	
	string getDepName();
	string getContactNo();
	string getAddress();
	string getQualification();
	string getRegDate();
	void setRegDate(string);
};

//////ATENDANCE CLASS////////
class CLASS_DECLSPEC Attendance
{
private:
	string date;
	string status;
public:
	string getDate();
	void setDate(string);
	string getStatus();
	void setStatus(string);
};


/////////////STUDENT CLASS////////////////


class CLASS_DECLSPEC Student : public Person
{

private:
	static int studentCount;
	string rollNo;
	string bloodGroup;
	
	bool FeeStatus;
	string marks;
	
public:
	Attendance* attendance;
	Student(string = "", string = "", string = "", string = "", string = "", char = NULL, string = "", string = "", string = "", string = "", string = "", string = "", bool = false,string="",string="");
	void setBloodGroup(string);
	string getBloodGroup();
	void setRollNo(string);
	
	string getRollNo();
	void setMarks(string);
	string getMarks();
	
	void setFeeStatus(bool);
	string getFeeStatus();

	//Student();
	////methods to view attendance, marks, grade, registered courses
	//virtual void viewAttendance();
	//virtual void viewMarks();
	//virtual void viewGrade();
	//virtual void viewFeeStatus();
	//virtual void viewRegisteredCourses();
	/*int signIntoSystem(fstream&);*/
//	getters and setters

};

///////////////TEACHER CLASS////////////////

class CLASS_DECLSPEC Teacher : public Person
{

	string department;
	string TID;
	string salary;
	string course;
public:
	Teacher(string = "", string = "", string = "", string = "", string = "", char = NULL, string = "", string = "", string = "",string="");
	void setCourse(string);
	string getCourse();
	void setTID(string);
	string getTID();
	void setSalary(string);
	string getSalary();


};

/// //////////////ADMINISTRATOR CLASS///////////

class CLASS_DECLSPEC Administrator : public Person
{

public:
	Administrator();
	
	
};

