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

Create Proc Update_Exam @Ex_id int , @Ex_Marks int 
as
	update Exams 
	set Ex_Marks = @Ex_Marks where Ex_Id=@Ex_id

Update_Exam 6 , 25 ;

/* Delete */

Create Proc DeleteExams @Ex_ID int
as
	delete from Exams where Ex_Id = @Ex_ID;
	select 'Record deleted';

DeleteExams 7;



						/* Questions */

/* Select */
Create Proc Get_Question
as
	select * from Questions;

Get_Question
/* Insert */
Create Proc Add_Question @Qtitle varchar(20) , @type varchar(20) , @AnsTitle varchar(20) , @AnsID int , @Qmark int
as
	insert into Questions Values(@Qtitle  , @type  , @AnsTitle , @AnsID  , @Qmark);

Add_Question "what is Angular ?" , "mcq" , "front end framework" , 2 , 10;
/* Update */

alter Proc Update_Question @Q_id int ,  @ColName varchar(20)  ,@ColValue varchar(50)
as
	
	if(@ColName = 'Q_Mark')
		declare @x int = CAST(@ColValue	 AS int) 
	execute ('update Questions set '+@ColName + ' = '+ '''' + @ColValue + '''' + ' where Q_Id ='+@Q_id)

Update_Question 1 , 'AnsTitle' , 'ay7aga' ;

/* Delete */

alter Proc DeleteQuestions @Q_ID int
as
	delete from Questions where Q_Id = @Q_ID;
	select 'Record deleted';

DeleteQuestions 2;


						/* Choices */

/* Select */
Create Proc Get_Choices
as
	select * from Choices;

Get_Choices
/* Insert */
Create Proc Add_Choice @CHtitle varchar(20) , @QID int
as
	insert into Choices Values(@CHtitle  , @QID  );

Add_Choice "backend framework" ,1;
/* Update */

alter Proc Update_Choice @C_id int ,  @CHttitle varchar(20) 
as
	update Choices set Ch_Title =@CHttitle
	where Ch_ID =@C_id

Update_Choice 3 , 'updated Choice' ;

/* Delete */

alter Proc DeleteChoice @CH_ID int
as
	if EXISTS(select * from Choices where Ch_Id=@CH_ID)
		delete from Choices where Ch_Id = @CH_ID;
	ELSE
		select 'record not found'
	

DeleteChoice 3;





						/* Exam_Question */

Get_Exams
Get_Question

/* Select */
Create Proc Get_Exams_Questions
as
	select * from Exam_Question;

Get_Exams_Questions
/* Insert */
Create Proc Add_Exams_Questions @Ex_id int , @QuestID int
as
	insert into Exam_Question Values(@Ex_id  , @QuestID  );

Add_Exams_Questions 5 ,3;
/* Update */

alter Proc Update_Exam_Question @Ex_id int , @QesID int
as
	update Exam_Question set Ex_ID =@Ex_id
	where Ques_ID =@QesID 

Update_Exam_Question  6 ,1;

/* Delete */

create Proc DeleteExam_Question  @Ex_ID int , @Q_ID int
as
	if EXISTS(select * from Exam_Question where Ques_ID=@Q_ID)
		delete from Exam_Question where Ques_ID = @Q_ID and Ex_ID=@Ex_ID ;
	ELSE
		select 'record not found'
	

DeleteExam_Question @EX_ID=5, @Q_ID=3;



				/* Student_Exams */


insert into departments("DeptNames") Values('SD');
select * from departments;
insert into students Values('mahmoud' , 'hesham' , '37 address 320' , '1997/11/20' , 25,5,'SD')

select * from students
Get_Exams

Get_Question

/* Select */
Create Proc Get_Student_Exams
as
	select * from Student_Exams;

Get_Student_Exams
/* Insert */
Create Proc Add_Student_Exams @st_ID int , @Ex_id int , @grade int
as
	insert into Student_Exams Values(@st_ID  , @Ex_id , @grade  );

Add_Student_Exams 1 ,5,48;
/* Update */

alter Proc Update_Student_Exams  @st_id int , @Ex_id int  , @grade int
as
	if(@grade <= (select Ex_Marks from Exams where Ex_Id=@Ex_id))
		update Student_Exams set Grade =@grade
		where  St_ID = @st_id and Ex_ID=@EX_ID 
	else
		select 'Grade is incorrect';

Update_Student_Exams  @st_id=1 , @Ex_id=5 , @grade=47;

/* Delete */

create Proc DeleteStudent_Exams  @st_id int , @EX_ID int
as
	if EXISTS(select * from Student_Exams where St_ID = @st_id and Ex_ID=@EX_ID )
		delete from Student_Exams where St_ID = @st_id and Ex_ID=@EX_ID ;
	ELSE
		select 'record not found'
	

DeleteStudent_Exams @st_id=1, @EX_ID=5;