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

