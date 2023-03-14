use ExamDB;

/*======================================================
	==================== Mahmoud ===============
========================================================*/

						/* Exam */

/* Select */
Create Proc Get_Exams
as
	select * from Exams;

Get_Exams
/* Insert */
Create Proc Add_Exams @Ex_Name varchar(20) , @Ex_Marks int , @crsID int
as
	insert into Exams Values(@Ex_Name , @Ex_Marks , @crsID);

Add_Exams "oop_3" , 25 , 1;
/* Update */

Create Proc Add_Exams @Ex_Name varchar(20) , @Ex_Marks int , @crsID int
as
	insert into Exams Values(@Ex_Name , @Ex_Marks , @crsID);

Add_Exams "oop_3" , 25 , 1;

/* Delete */

Create Proc DeleteExams @Ex_ID int
as
	delete from Exams where Ex_Id = @Ex_ID;
	select 'Record deleted';

DeleteExams 7;