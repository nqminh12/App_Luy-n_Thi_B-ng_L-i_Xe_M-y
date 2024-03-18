drop database [Winapp_Final_Project]
create database [Winapp_Final_Project]
use [Winapp_Final_Project]
CREATE TABLE [User] (
	User_Id INT NOT NULL IDENTITY(1,1) ,
    [Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Fullname] [nvarchar](50) NULL,
	[Phonenumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
    [User_Role] INT NOT NULL,
    PRIMARY KEY (User_Id)
);

CREATE TABLE [License] (
	License_Id INT NOT NULL IDENTITY(1,1) ,
    [License_Name] [nvarchar](50) NULL,
    PRIMARY KEY (License_Id)
);

Create Table [Set](
	Set_Id INT NOT NULL IDENTITY(1,1) ,
	[Set_Number] INT NULL,
    [Set_Name] [nvarchar](50) NULL,
    PRIMARY KEY (Set_Id)
)

CREATE TABLE [Topic] (
	Topic_Id INT NOT NULL IDENTITY(1,1) ,
    [Topic_Name] [nvarchar](50) NULL,
    PRIMARY KEY (Topic_Id)
);


CREATE TABLE [Question] (
	Question_Id INT NOT NULL IDENTITY(1,1),
    [Question_Description] [nvarchar](max) NULL,
	[Question_Image] [nvarchar](max) NULL,
	License_Id int null FOREIGN KEY REFERENCES License(License_Id) ON DELETE CASCADE,
	Topic_Id int null FOREIGN KEY REFERENCES Topic(Topic_Id) ON DELETE CASCADE,
	Set_Id int null FOREIGN KEY REFERENCES [Set](Set_Id) ON DELETE CASCADE,
    PRIMARY KEY (Question_Id),
);

ALTER TABLE [Question]
  ADD [Question_Explain] [nvarchar](max);


CREATE TABLE [Answer] (
	Answer_Id INT NOT NULL IDENTITY(1,1) ,
    [Answer_Description] [nvarchar](max) NULL,
	[Answer_Image] [nvarchar](max) NULL,
	[Answer_Type] INT NOT NULL,
	[Question_Id] int null FOREIGN KEY REFERENCES Question(Question_Id) ON DELETE CASCADE,
    PRIMARY KEY (Answer_Id)
);

CREATE TABLE [History] (
	History_Id INT NOT NULL IDENTITY(1,1) ,
	[History_Date] datetime,
	[History_Time] time,
    User_Id int null FOREIGN KEY REFERENCES [User](User_Id) ON DELETE CASCADE,
    PRIMARY KEY (History_Id)
);

CREATE TABLE [History_Detail] (
    History_Detail_Id INT NOT NULL IDENTITY(1,1) ,
    History_Id INT NULL FOREIGN KEY REFERENCES History(History_Id) ON DELETE CASCADE,
    Question_Id INT NULL FOREIGN KEY REFERENCES Question(Question_Id) ON DELETE NO ACTION,
    Answer_Id INT NULL FOREIGN KEY REFERENCES Answer(Answer_Id) ON DELETE NO ACTION,
    PRIMARY KEY (History_Detail_Id)
);

CREATE TABLE [Traffic_Sign] (
	Traffic_Sign_Id INT NOT NULL IDENTITY(1,1) ,
    [Traffic_Sign_Name] [nvarchar](50) NULL,
	[Traffic_Sign_Image] [nvarchar](max) NULL,
    PRIMARY KEY (Traffic_Sign_Id)
);


ALTER TABLE [History]
    ADD License_Id INT NULL

ALTER TABLE [History]
    ADD CONSTRAINT FK_History_License FOREIGN KEY (License_Id) REFERENCES License(License_Id) ON DELETE CASCADE;

ALTER TABLE [History]
    ADD Set_Id INT NULL

ALTER TABLE [History]
    ADD CONSTRAINT FK_History_Set FOREIGN KEY (Set_Id) REFERENCES [Set](Set_Id) ON DELETE CASCADE;
