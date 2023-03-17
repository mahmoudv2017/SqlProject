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
alter Proc Add_Exams @Ex_Name varchar(20) , @Ex_Marks int , @crsID int , @x int output
as
	begin try

		insert into Exams Values(@Ex_Name , @Ex_Marks , @crsID);
		set @x = SCOPE_IDENTITY()
		select 'New Exam Inserted';
	end try
	begin catch
		select 'Wrong Course ID';
	end catch

declare @x int;
exec Add_Exams "oop_3" , 25 , 1;
select @x
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
alter Proc Add_Question @Qtitle varchar(20) , @type varchar(20) , @AnsTitle varchar(20) , @crsID int , @AnsID int , @Qmark int
as
	insert into Questions Values(@Qtitle  , @type  , @AnsTitle , @AnsID , @crsID , @Qmark);

Add_Question @Qtitle='what is Angular ?' , @type='mcq' , 
@AnsTitle='front end framework' ,
@AnsID= 2 ,
@crsID=1 ,
@Qmark= 10;

/* Update */

create Proc Update_Question @Q_id int ,  @ColName varchar(20)  ,@ColValue varchar(50)
as
	
	if(@ColName = 'Q_Mark')
		declare @x int = CAST(@ColValue	 AS int) 
	execute ('update Questions set '+@ColName + ' = '+ '''' + @ColValue + '''' + ' where Q_Id ='+@Q_id)

Update_Question 1 , 'AnsTitle' , 'ay7aga' ;

/* Delete */

create Proc DeleteQuestions @Q_ID int
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
	insert into Exam OUTPUT Inserted. Values(@Ex_id  , @QuestID  );

Add_Exams_Questions 6 ,3;
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


/******************Stored Procedure For Courses*************/
Create Procedure coursesproc
(  
   @Id INTEGER, 
   @Title VARCHAR(max) = NULL, 
   @ActionType nvarchar(20) = ''  
)  
	AS  
		BEGIN  
			IF @ActionType = 'Insert'  
			BEGIN  
				Insert into [dbo].[courses](Id, Title) values( @Id, @Title)  
			END  
			IF @ActionType = 'Select'  
			BEGIN  
				Select * from [dbo].[courses] 
			END  
			IF @ActionType = 'Update'  
			BEGIN  
				UPDATE [dbo].[courses]SET  
					Title = @Title
				WHERE Id = @Id  
			END  
			IF @ActionType = 'Delete'  
			BEGIN  
				Delete from [dbo].[courses] Where Id = @Id
			END  
		END

--Insert In Courses Table
EXEC coursesproc 
 @Id = 7,
 @Title = 'Database',
 @ActionType = 'Insert'

 --Update In Courses Table
 EXEC coursesproc 
  @Id = 1,
 @Title = 'Database22',
 @ActionType = 'Update'

 --Delete In Courses Table
 EXEC coursesproc 
 @Id = 1,
 @ActionType = 'Delete'

 --Select In Courses Table
 EXEC coursesproc 
 @Id=1,
 @ActionType = 'Select'

/******************Stored Procedure For departments******************/

Create Procedure departmentsproc
(  
   @Id INTEGER, 
    @DeptName nvarchar(50), 
   @ActionType nvarchar(20) = ''  
)  
AS  
BEGIN  
	IF @ActionType = 'Insert'  
	BEGIN  
		Insert into [dbo].[departments](Id,DeptNames) values( @Id, @DeptName)  
	END  
	IF @ActionType = 'Select'  
	BEGIN  
		Select * from [dbo].[departments] 
	END  
	IF @ActionType = 'Update'  
	BEGIN  
		UPDATE [dbo].[departments]SET  
			DeptNames = @DeptName
		WHERE Id = @Id  
	END  
	IF @ActionType = 'Delete'  
	BEGIN  
		Delete from [dbo].[departments] Where Id = @Id
	END  
END

--Insert In Departments Table
EXEC departmentsproc 
 @Id = 6,
 @DeptName='CS',
 @ActionType = 'Insert'

 --Update In Departments Table
 EXEC departmentsproc
  @Id = 3,
 @DeptName='IS',
 @ActionType = 'Update'

 --Delete In Departments Table
 EXEC departmentsproc 
 @Id = 3,
  @DeptName='',
 @ActionType = 'Delete'

 --Select In Departments Table
 EXEC departmentsproc 
 @Id=0,
 @DeptName='',
 @ActionType = 'Select'
 

 /******************Stored Procedure For dept_Crs******************/
 Create Procedure dept_Crsproc
(  
   @ID INTEGER, 
   @CrsID INTEGER,  
   @DeptID INTEGER, 
   @departmentsId INTEGER, 
   @Ins_CourseId INTEGER,
   @ActionType nvarchar(20) = ''
)  
AS  
BEGIN  
	
	IF @ActionType = 'Select'  
	BEGIN  
		Select * from [dbo].[dept_Crs]
	END  

	IF @ActionType = 'Insert'  
	BEGIN  
		try	
			insert into dept_Crs values(@CrsID ,@departmentsId )
		catch
			select 'invalid Course or department ID'
	END 

	IF @ActionType = 'Update'  
	BEGIN  
		try	
			insert into dept_Crs values(@CrsID ,@departmentsId )
		catch
			select 'invalid Course or department ID'
	END 

	IF @ActionType = 'Delete'  
	BEGIN  
		try	
			delete from dept_Crs where courseID=@CrsID and departmentsId= @departmentsId
		catch
			select 'invalid Course or department ID'
	END 

	
END

 --Select In Departments Table
 EXEC dept_Crsproc 
 @Id = 0,
 @CrsID=0,
 @departmentsId=3,
 @DeptID=0,
 @Ins_CourseId=6,
 @ActionType = 'Select'

 select *from departments


 /******************************* Exam Generation **********************/
 use ExamDB
 alter proc Exam_Generation @Ex_Name varchar(20) ,  @crsID int , @Ex_Marks int
	as
			--//create an exam
			--//retrieve the randomized questions
			--//add it to Exam_Question_Crs table

			
			Begin transaction Exam
			declare @x int
			exec Add_Exams @Ex_Name , @Ex_Marks ,  @crsID, @x output
			insert into Exam_Question_Crs
			select @x as Ex_ID , Q_id,CrsID   from Questions where CrsID = @crsID order by newID()
			Commit transaction

Exam_Generation @Ex_Name='OOP_4' , @crsID=2 , @Ex_Marks=100
Get_Exams
select * from Exam_Question_Crs	order by Ex_ID	 
alter proc test
as
	declare @t as int 
	return @t
declare @x int;
exec @x =  test
select @x;


