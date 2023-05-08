#include "flex.h"


Login::Login(string userName,string password)
{
	this->userName = userName;
	this->password = password;
}
void Login::setUserName(string userName)
{
	this->userName = userName;
}
void Login::setPassword(string password)
{
	this->password = password;
}
string Login::getUserName()
{
	return userName;
}
string Login::getPassword()
{
	return password;
}

string Attendance::getDate()
{
	return date;
}
void Attendance::setDate(string date)
{
	this->date = date;
}
string Attendance::getStatus()
{
	return status;
}
void Attendance::setStatus(string status)
{
	this->status = status;
}

Person::Person(string username, string password, string firstName, string lastName, string DepName, char gender, string contactNo, string adress, string qualification) :Login(username, password)
{
	this->firstName = firstName;
	this->lastName = lastName;
	this->DepName= DepName;
	this->gender = gender;
	this->contactNo = contactNo;
	this->address = adress;
	this->qualification = qualification;
}

Person::~Person()
{
}
string Person::getAddress()
{
	return address;
}

void Person::setAddress(string address)
{
	this->address = address;
}

string Person::getContactNo()
{
	return contactNo;
}

void Person::setContactNo(string contactNo)
{
	this->contactNo = contactNo;
}

string Person::getDepName()
{
	return DepName;
}

void Person::setDepName(string DepName)
{
	this->DepName = DepName;
}

string Person::getFirstName()
{
	return firstName;
}

void Person::setFirstName(string firstName)
{
	this->firstName = firstName;
}

string Person::getLastName()
{
	return lastName;
}

void Person::setLastName(string lastName)
{
	this->lastName = lastName;
}

string Person::getQualification()
{
	return qualification;
}

void Person::setQualification(string qualification)
{
	this->qualification = qualification;
}

char Person::getGender()
{
	return gender;
}

void Person::setGender(char gender)
{
	this->gender = gender;
}

static int count = 0;

Student::Student(string username, string password, string firstName, string lastName, string DepName, char gender, string contactNo, string adress, string qualification, string rollNo, string bloodGroup, string section, bool FeeStatus,string marks,string RegDate) :Person(username, password, firstName, lastName, DepName, gender, contactNo, adress, qualification)
{
	this->rollNo = rollNo;
	this->bloodGroup = bloodGroup;
	//this->section = section;
	this->FeeStatus = FeeStatus;
	this->marks = marks;
	
}

string Student::getMarks()
{
	return marks;
}
void Student::setMarks(string marks)
{
	this->marks = marks;
}
string Person::getRegDate()
{
	return RegDate;
}
void Person::setRegDate(string RegDate)
{
	this->RegDate = RegDate;
}
string Student::getRollNo()
{
	return rollNo;
}

void Student::setRollNo(string rollNo)
{
	this->rollNo = rollNo;
}

string Student::getBloodGroup()
{
	return bloodGroup;
}

void Student::setBloodGroup(string bloodGroup)
{
	this->bloodGroup = bloodGroup;
}

string Student::getFeeStatus()
{
	if (FeeStatus == 1)
		return "Paid";
	else
		return "Not Paid";
}

void Student::setFeeStatus(bool FeeStatus)
{
	this->FeeStatus = FeeStatus;
}

Teacher::Teacher(string username, string password, string firstName, string lastName, string DepName, char gender, string contactNo, string adress, string qualification, string TID) :Person(username, password, firstName, lastName, DepName, gender, contactNo, adress, qualification)
{
	this->TID= TID;
}

string Teacher::getTID()
{
	return TID;
}

void Teacher::setTID(string TID)
{
	this->TID = TID;
}

void Teacher::setSalary(string salary)
{
	this->salary = salary;
}

string Teacher::getSalary()
{
	return salary;
}
string Teacher:: getCourse()
{
	return course;
}
void Teacher::setCourse(string course)
{
	this->course = course;
}
Administrator::Administrator() :Person()
{


}

