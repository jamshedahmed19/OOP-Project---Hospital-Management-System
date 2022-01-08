CREATE DATABASE HOSPITAL_MANAGEMENT_SYSTEM;

CREATE TABLE DOCTORS(
ID INT IDENTITY(1,1) NOT NULL,
DOC_ID AS('DID'+RIGHT('-000000'+CAST(ID AS VARCHAR(7)),7))PERSISTED,
DOC_NAME VARCHAR(50) NOT NULL,
DOC_DEP_ID int  NOT NULL foreign key references Department(ID),
DOC_TEL VARCHAR(15) NOT NULL UNIQUE,
DOC_EMAIL VARCHAR(255) NOT NULL UNIQUE,
DOC_PASS nVARCHAR(50) NOT NULL,
DOC_GENDER VARCHAR(7) NOT NULL,
DOC_ADDRESS VARCHAR(100) NOT NULL,
DOC_Role_ID int  NOT NULL foreign key references DoctorRoles(ID),
PricePerAppointment int not null,
PRIMARY KEY (ID)
)

alter table DOCTORS
add PricePerAppointment int not null;

drop table DOCTORS


create table Availability(
availabilityId int ,
slotstart datetime not null,
slotend datetime not null,
slotdocid int foreign key references DOCTORS(ID)
)

drop table Availability


drop table timeSlots

select * from DOCTORS

drop table DOCTORS

Create table Department
(
ID INT primary key IDENTITY(1,1) ,
DepartmentName nvarchar(50)
)

create table DoctorRoles
(
ID INT primary key IDENTITY(1,1) ,
Rolename nvarchar(50)
)
SELECT * FROM DoctorRoles where Rolename = 'Surgeon';
Select * from DOCTORS
Select * from Department
SELECT Doctors.ID,Doctors.DOC_ID,Doctors.DOC_NAME,Department.DepartmentName,Doctors.DOC_TEL,Doctors.DOC_EMAIL,Doctors.DOC_PASS,Doctors.DOC_GENDER,Doctors.DOC_ADDRESS,DoctorRoles.Rolename from Doctors inner join Department on Department.ID = Doctors.DOC_DEP_ID inner join DoctorRoles on DoctorRoles.ID = Doctors.DOC_Role_ID


insert into DoctorRoles values('Surgeon')
insert into DoctorRoles values('Physiotherapist')
insert into Department values('ONCOLOGY')
insert into Department values('OPD')

CREATE TABLE EMPLOYEE(
ID INT IDENTITY(1,1) NOT NULL,
EMP_ID AS('EID'+RIGHT('-000000'+CAST(ID AS VARCHAR(10)),10))PERSISTED,
EMP_NAME VARCHAR(50) NOT NULL,
EMP_GENDER VARCHAR(7) NOT NULL,
EMP_PASS nVARCHAR(50) NOT NULL,
DepartmentID int  NOT NULL foreign key references Department(ID),
EMP_TEL VARCHAR(15) NOT NULL UNIQUE,
EMP_EMAIL VARCHAR(255) NOT NULL UNIQUE,
EMP_ADDRESS VARCHAR(100) NOT NULL,
RoleID int  NOT NULL foreign key references EmployeeRoles(ID),
PRIMARY KEY (ID),
)

select EMPLOYEE.ID,EMPLOYEE.EMP_ID,EMPLOYEE.EMP_NAME,EMPLOYEE.EMP_GENDER,EMPLOYEE.EMP_PASS,Department.DepartmentName,EMPLOYEE.EMP_TEL,EMPLOYEE.EMP_EMAIL,EMPLOYEE.EMP_ADDRESS,EmployeeRoles.RoleName from Employee inner join Department on EMPLOYEE.DepartmentID = Department.ID inner join EmployeeRoles on EMPLOYEE.RoleID = EmployeeRoles.ID

create table EmployeeRoles(
ID INT primary key IDENTITY(1,1),
RoleName nvarchar(50)
)

select * from EMPLOYEE

insert into EmployeeRoles values('Admin')
insert into EmployeeRoles values('User')



CREATE TABLE ROOM(
ID INT IDENTITY(1,1) NOT NULL primary key,
ROOM_NO VARCHAR(10) NOT NULL UNIQUE,
FLOOR_NO VARCHAR(1) NOT NULL,
ROOM_STATUS VARCHAR(10) NOT NULL,
ROOM_TYPE VARCHAR(10) NOT NULL,
PRICE_PER_DAY INT NOT NULL,
)



select * from ROOM
drop table ROOM




CREATE TABLE PATIENTS(
ID INT IDENTITY(1,1) NOT NULL,
PAT_ID AS('PID'+RIGHT('-000000'+CAST(ID AS VARCHAR(7)),7))PERSISTED,
PAT_NAME VARCHAR(50) NOT NULL,
PAT_TEL VARCHAR(15) NOT NULL UNIQUE,
PAT_EMAIL NVARCHAR(255) NOT NULL UNIQUE,
PAT_GENDER VARCHAR(7) NOT NULL,
PAT_ADDRESS VARCHAR(100) NOT NULL,
Createdby INT FOREIGN KEY REFERENCES Employee(ID),
PAT_DATE date not null,
PRIMARY KEY (ID),
)

drop table PATIENTS

CREATE TABLE INPATIENT(
ID INT IDENTITY(1,1) ,
INPAT_ID AS('IPID'+RIGHT('-000000'+CAST(ID AS VARCHAR(10)),10))PERSISTED,
DATE_OF_AD DATE NOT NULL,
DATE_OF_DIS DATE NOT NULL,
PAT_CODE INT FOREIGN KEY REFERENCES PATIENTS(ID),
ROOM_CODE INT FOREIGN KEY REFERENCES ROOM(ID),
TotalAmount int not null,
PRIMARY KEY (ID),
)

drop table INPATIENT

SELECT INPATIENT.ID, PATIENTS.ID, PAT_NAME, PAT_TEL, DATE_OF_AD, DATE_OF_DIS, ROOM_CODE , ROOM_TYPE FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE


CREATE TABLE DIAGNOSES(
ID INT IDENTITY(1,1) NOT NULL,
DIAG_NO AS('DNO'+RIGHT('-000000'+CAST(ID AS VARCHAR(10)),10))PERSISTED,
DIAG_DETAILS TEXT NOT NULL,
DIAG_REMARK TEXT NOT NULL,
DIAG_DATE DATE NOT NULL,
DIAG_AMOUNT INT NOT NULL,
DIAG_OTHER TEXT,
PAT_CODE INT FOREIGN KEY REFERENCES PATIENTS(ID),
PRIMARY KEY (ID),
)

CREATE TABLE BILL(
ID INT IDENTITY(1,1) NOT NULL,
BILL_ID AS('BNO'+RIGHT('-000000'+CAST(ID AS VARCHAR(20)),20))PERSISTED,
PAT_TYPE VARCHAR(50),
ROOM_CHARGE INT NOT NULL,
DOC_CHARGE INT NOT NULL,
OPR_CHARGE INT,
NURSING_CHARGES INT,
SERVICE_CHARGE INT,
STAY_DAYS INT,
INSURANCE INT,
HEALTH_CARD VARCHAR(50),
PAT_CODE INT FOREIGN KEY REFERENCES PATIENTS(ID),
PRIMARY KEY (ID),
)





CREATE TABLE ROOM(
ID INT IDENTITY(1,1) NOT NULL,
ROOM_NO VARCHAR(10) NOT NULL UNIQUE,
FLOOR_NO VARCHAR(1) NOT NULL,
ROOM_STATUS VARCHAR(10) NOT NULL,
ROOM_TYPE VARCHAR(10) NOT NULL,
PRICE_PER_HOUR INT NOT NULL,
)



ALTER TABLE ROOM
ADD CONSTRAINT PF_ROOM_ID
PRIMARY KEY(ID)

ALTER TABLE EMPLOYEE ADD EMP_DESIG VARCHAR(20);
ALTER TABLE EMPLOYEE ADD EMP_DESIG VARCHAR(20);


ALTER TABLE ROOM ADD PRICE_PER_HOUR VARCHAR(10)
ALTER TABLE ROOM ALTER COLUMN ROOM_STATUS VARCHAR(15)

ALTER TABLE ROOM
ADD UNIQUE (ROOM_NO);

ALTER TABLE ROOM
ADD UNIQUE (ROOM_TYPE);

ALTER TABLE ROOM
DROP COLUMN ROOM_TYPE;

ALTER TABLE PATIENTS
DROP COLUMN PAT_PASS;

ALTER TABLE INPATIENT
DROP COLUMN ROOM_NO;

INSERT INTO DOCTORS VALUES('Jamshed','03492896282','jamsheda4ahmed786@gmail.com','12345678','Male','Karachi','Surgeon');
INSERT INTO ROOM VALUES(203,'2','Not Available','Private','1000');
INSERT INTO ROOM VALUES(2,'Free','Private','123','G','500');
INSERT INTO ROOM VALUES(3,'Free','Ward','123','G','500');
INSERT INTO INPATIENT VALUES(1,'Free','Ward','123','G','500');
INSERT INTO ROOM VALUES('Free','Ward','123','G','500');
INSERT INTO ROOM VALUES(1,'Free','Ward','123','G','500');
INSERT INTO EMPLOYEE VALUES('Jamshed', 'jamshed19', 'jam19hms', 'Admin', 03492896282, 'jamshedahmed489@gmail.com', 'Male', 'Karachi', 'Admin');
INSERT INTO EMPLOYEE VALUES('Asfand', 'asfand21', 'asfand21hms', 'Doctor', 03332178032, 'asfandtariq21@gmail.com', 'Male', 'Karachi', 'Doctor');
INSERT INTO APPOINTMENT VALUES('11-29-2020', '4:39 PM', 3, 9);

SELECT * FROM EMPLOYEE	
select * from doctors
select * from patients
select * from bill
select * from inpatient
select * from APPOINTMENT
select * from outpatient
select * from room
select * from diagnoses
SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON PAT_NAME LIKE '%u%'
SELECT PAT_ID, PAT_NAME, DOC_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS, DOC_DESIG, DOC_DEPART FROM PATIENTS INNER JOIN DOCTORS ON PAT_TEL '%%'
SELECT PAT_NAME, DOC_NAME, CHECKUP_DATE FROM APPOINTMENT INNER JOIN PATIENTS ON PATIENTS.ID = 3 INNER JOIN DOCTORS ON DOCTORS.ID = PATIENTS.DOC_CODE
SELECT PATIENTS.ID, PAT_NAME, DATE_OF_AD, DATE_OF_DIS,DOC_NAME, ROOM.ROOM_NO, ROOM_TYPE FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE 
INNER JOIN DOCTORS ON DOCTORS.ID = DOC_CODE 
INNER JOIN ROOM ON ROOM.ID = ROOM_CODE


SELECT PAT_ID, PAT_NAME, PAT_GENDER, PAT_TEL, PAT_EMAIL, PAT_ADDRESS FROM PATIENTS INNER JOIN APPOINTMENT ON APPOINTMENT.PAT_CODE =PATIENTS.ID  where DOC_CODE = 2025

SELECT * FROM ROOM WHERE  ID not in (SELECT ROOM_CODE FROM INPATIENT INNER JOIN PATIENTS ON PATIENTS.ID = PAT_CODE INNER JOIN ROOM ON ROOM.ID = ROOM_CODE where DATE_OF_DIS >= '2020-11-08' )
select * from inpatient

select * from DOCTORS

select * from Availability

exec createAvailability 1,'08:00:00','16:00:00',19

select * from timeSlots
drop table timeSlots
insert into timeSlots values(1,'08:00','08:00',11,1)

UPDATE timeSlots SET dateoftimeslot = '2021-12-31',isavailable = 0 where dateoftimeslot<'2022-01-02'
create table timeSlots(
id int primary key identity(1,1),
availabilityId int ,
slotstart time not null,
slotend time not null,
slotdocid int foreign key references DOCTORS(ID),
isavailable int,
dateoftimeslot date,
)

CREATE TABLE APPOINTMENT
(
ID INT IDENTITY(1,1) NOT NULL,
AID AS('AID'+RIGHT('-000000'+CAST(ID AS VARCHAR(20)),20))PERSISTED,
CHECKUP_DATE DATE NOT NULL,
Slot_ID int foreign key references timeSlots(id),
PAT_CODE INT FOREIGN KEY REFERENCES PATIENTS(ID),
DOC_CODE INT FOREIGN KEY REFERENCES DOCTORS(ID),
PRIMARY KEY (ID),
)

delete from APPOINTMENT where AID = 'AID-0000002'
delete from timeSlots where slotdocid = 20


select AID,DOC_NAME,PAT_NAME,CHECKUP_DATE,slotstart,slotend from APPOINTMENT 
inner join timeSlots on APPOINTMENT.Slot_ID = timeSlots.id 
inner join PATIENTS on APPOINTMENT.PAT_CODE = PATIENTS.ID 
inner join DOCTORS on DOCTORS.ID = APPOINTMENT.DOC_CODE
select id,Concat(slotstart,' ' ,slotend) as slotdec from timeSlots

select * from PATIENTS


select * from timeSlots

DELETE FROM timeSlots WHERE slotdocid = 1024

SELECT Distinct Doctors.ID,Doctors.DOC_ID,Doctors.DOC_NAME,Department.DepartmentName,Doctors.DOC_TEL,Doctors.DOC_EMAIL,Doctors.DOC_PASS,Doctors.DOC_GENDER,Doctors.DOC_ADDRESS,DoctorRoles.Rolename,DOCTORS.PricePerAppointment,timeSlots.slotstart,timeSlots.slotend from Doctors 
left join Department on Department.ID = Doctors.DOC_DEP_ID 
left join DoctorRoles on DoctorRoles.ID = Doctors.DOC_Role_ID 
left join timeSlots on DOctors.ID = timeSlots.slotdocid


select slotstart as Start_Timings,slotend as End_Timings,CHECKUP_DATE,PATIENTS.PAT_NAME,DOCTORS.DOC_NAME from APPOINTMENT inner join timeSlots on timeSlots.id =Slot_ID
inner join DOCTORS on DOCTORS.ID = DOC_CODE
inner join PATIENTS on PATIENTS.ID =PAT_CODE
where APPOINTMENT.DOC_CODE = 2023 


SELECT Doctors.ID,Doctors.DOC_ID,Doctors.DOC_NAME,Department.DepartmentName,Doctors.DOC_TEL,Doctors.DOC_EMAIL,Doctors.DOC_PASS,Doctors.DOC_GENDER,Doctors.DOC_ADDRESS,DoctorRoles.Rolename,DOCTORS.PricePerAppointment from Doctors 
inner join Department on Department.ID = Doctors.DOC_DEP_ID
inner join DoctorRoles on DoctorRoles.ID = Doctors.DOC_Role_ID WHERE Doctors.DOC_ID = 'DID0002025'
--and APPOINTMENT.CHECKUP_DATE = ''



