Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class BusinessClass
    Dim MySqlConn As New MySqlConnection
    Public Function getConnection() As String

        Dim strcon As String = "true"

        Try
            MySqlConn.ConnectionString = "server=192.168.1.20; user id=monwabisi; password=littlepig123; database=applicant;"

            MySqlConn.Open()


            MySqlConn.Close()
        Catch ex As Exception
            strcon = ex.Message.ToString()
        End Try
        Return strcon

    End Function
    'all IDs from all tables


    Public Function Addapplicant(ByVal id As String, ByVal system_position As Integer, ByVal pword As String, ByVal email As String,
                                 ByVal disabilityType As String,
                                 ByVal race As Integer, ByVal maritalStatus As Integer, ByVal gender As Integer,
                                  ByVal nationality As Integer, ByVal disability As Integer, surname As String,
                                 ByVal FirstName As String, ByVal Middlename As String,
                                 ByVal contact As String, ByVal altcontact As String, ByVal criminalR As Integer, ByVal skill As String, ByVal dependencies As Integer,
                                 ByVal city As Integer,
                                  ByVal Addressline1 As String, ByVal Addressline2 As String, ByVal Addressline3 As String, ByVal code As Integer,
                                 ByVal qualification As Integer, ByVal university As Integer, ByVal qualificationStatus As Integer,
                                  ByVal FOS As String, ByVal refcontact As String, ByVal refname As String,
                                 ByVal refemail As String, ByVal refrelationship As String, ByVal jobname As String, ByVal companyname As String,
                                 ByVal duties As String, ByVal startdate As Date, ByVal enddate As Date, ByVal license As Integer, ByVal licenseStatus As Integer) As String
        ' ByVal restriction As Integer,
        Dim sql As String
        Dim applicantStatus As Integer = 1
        Dim cmd As MySqlCommand
        Dim result As String
        startdate = DateTime.Now.ToString("yyyy-MM-dd")
        enddate = DateTime.Now.ToString("yyyy-MM-dd")
        Try
            'Inserting data to table login

            sql = "INSERT INTO system_login (Login_ID,Position_ID,Password,Email) Values( '" & id & "'," & CStr(system_position) & ",'" & pword & "','" & email & "')"
            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            'result = "true"





            'Inserting data to table disability
            sql = "INSERT INTO applicant_disability_type (Personal_Details_ID,Disability_Type,Disability_ID) Values( '" & id & "','" & disabilityType & "'," & CStr(disability) & ")"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' result = "true"



            'inserting data to table applicant
            sql = "INSERT INTO applicant_personal_details (Personal_Details_ID,Race_ID,Marital_Status_ID,Gender_ID,Nationality_ID,Surname,First_Name,Middle_Name,Contact_Number,Alt_Contact_Number,Criminal_Record,Skills,Application_Status,Number_Of_Dependencies) Values( '" & id & "'," & CStr(race) & "," & CStr(maritalStatus) & "," & CStr(gender) & "," & CStr(nationality) & ",'" & surname & "','" & FirstName & "','" & Middlename & "','" & contact & "','" & altcontact & "'," & CStr(criminalR) & ",'" & skill & "'," & CStr(applicantStatus) & "," & CStr(dependencies) & ")"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            '  result = "true"





            'Inserting data to table address
            sql = "INSERT INTO applicant_address (Personal_Details_ID,Province_Municipality_City_ID,Address_Line_1,Address_Line_2,Address_Line_3,Postal_Code) Values( '" & id & "'," & CStr(city) & ",'" & Addressline1 & "','" & Addressline2 & "','" & Addressline3 & "'," & CStr(code) & ")"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' result = "true"



            'Inserting data to table qualification

            'Inserting data to table field of study
            sql = "INSERT INTO applicant_person_qualification_university_field_of_study (Personal_Details_ID,Qualification_ID,University_ID,Qualification_Status_ID,Field_Of_Study) Values( '" & id & "'," & CStr(qualification) & "," & CStr(university) & "," & CStr(qualificationStatus) & ",'" & FOS & "')"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            'result = "true"




            'Inserting data to table reference
            sql = "INSERT INTO applicant_reference (Contact_Number,Reference_Name,Email_Address,Relationship,Personal_Details_ID) Values( '" & refcontact & "','" & refname & "','" & refemail & "','" & refrelationship & "','" & id & "')"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' result = "true"


            'Inserting data to table experience
            sql = "INSERT INTO applicant_experience (Job_Name,Company_Name,Duties,Start_Date,End_Date,Personal_Details_ID) Values( '" & jobname & "','" & companyname & "','" & duties & "'," & "'" & startdate & "'," & "'" & enddate & "'" & ",'" & id & "')"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            '  result = "true"

            'result = "true"
            ' MySqlConn.Open()
            'Inserting data to table vehicle restriction
            sql = "INSERT INTO applicant_drivers_license (Personal_Details_ID,Drivers_License_Code_ID,Drivers_License_Status_ID) Values( '" & id & "'," & CStr(license) & "," & CStr(licenseStatus) & ")"
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = "Add applicant" + ex.Message.ToString()
        End Try
        Return result
    End Function


    Public Function updateapplicant(ByVal id As String, ByVal system_position As Integer, ByVal pword As String, ByVal email As String,
                                   ByVal disabilityType As String, ByVal race As Integer, ByVal maritalStatus As Integer, ByVal gender As Integer,
                                 ByVal nationality As Integer, ByVal disability As Integer, surname As String,
                                ByVal FirstName As String, ByVal Middlename As String,
                                ByVal contact As String, ByVal altcontact As String, ByVal criminalR As Integer, ByVal skill As String, ByVal dependencies As Integer,
                                ByVal city As Integer,
                                 ByVal Addressline1 As String, ByVal Addressline2 As String, ByVal Addressline3 As String, ByVal code As Integer,
                                ByVal qualification As Integer, ByVal university As Integer, ByVal qualificationStatus As Integer,
                                 ByVal FOS As String, ByVal refcontact As String, ByVal refname As String,
                                ByVal refemail As String, ByVal refrelationship As String, ByVal jobname As String, ByVal companyname As String,
                                ByVal duties As String, ByVal startdate As Date, ByVal enddate As Date, ByVal license As Integer, ByVal licensestatus As Integer) As String

        ' ByVal restriction As Integer,ByVal disabilityType As String,
        Dim sql As String
        Dim applicantStatus As Integer = 1
        Dim cmd As MySqlCommand
        Dim result As String
        Try
            'Inserting data to table login

            sql = "UPDATE system_login SET Login_ID= '" & id & "', Position_ID = " & system_position & ",Password='" & pword & "', Email='" & email & "'where Login_ID='" & id & "'"

            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            'result = "true"

            'Inserting data to table disability
            sql = "UPDATE applicant_disability_type SET Personal_Details_ID='" & id & "',Disability_ID=" & CStr(disability) & ", Disability_Type='" & disabilityType & "' WHERE Personal_Details_ID = '" & id & "'"
            '   MsgBox(" disability" + sql)
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            '' result = "true"
            'MsgBox("table applicant" + sql)

            'inserting data to table applicant
            sql = "UPDATE applicant_personal_details Set Personal_Details_ID= '" & id & "',Race_ID =" & CStr(race) & " ,Marital_Status_ID=" & CStr(maritalStatus) & " ,Gender_ID =" & CStr(gender) & " ,Nationality_ID =" & CStr(nationality) & ",Surname='" & surname & "',First_Name='" & FirstName & "',Middle_Name='" & Middlename & "',Contact_Number='" & contact & "',Alt_Contact_Number='" & altcontact & "',Criminal_Record=" & CStr(criminalR) & ",Skills='" & skill & "',Application_Status=" & CStr(applicantStatus) & ",Number_Of_Dependencies=" & CStr(dependencies) & " WHERE Personal_Details_ID = '" & id & "' "

            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            '  result = "True"

            'Inserting data to table address      
            sql = "UPDATE applicant_address  SET Personal_Details_ID='" & id & "',Province_Municipality_City_ID=" & CStr(city) & ",Address_Line_1='" & Addressline1 & "',Address_Line_2='" & Addressline2 & "',Address_Line_3='" & Addressline3 & "',Postal_Code=" & CStr(code) & " WHERE Personal_Details_ID = '" & id & "'"

            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' result = "True"

            'Inserting data to table field of study                             
            sql = "UPDATE applicant_person_qualification_university_field_of_study SET Personal_Details_ID='" & id & "',Qualification_ID=" & CStr(qualification) & ",University_ID =" & CStr(university) & ",Qualification_Status_ID=" & CStr(qualificationStatus) & ",Field_Of_Study='" & FOS & "' WHERE Personal_Details_ID = '" & id & "'"

            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            'result = "True"

            'Inserting data to table reference                      
            sql = "UPDATE applicant_reference  SET Contact_Number='" & refcontact & "',Reference_Name='" & refname & "',Email_Address='" & refemail & "',Relationship='" & refrelationship & "' WHERE  Personal_Details_ID = '" & id & "'"

            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' result = "True"

            'Inserting data to table experience
            sql = "UPDATE applicant_experience SET Job_Name='" & jobname & "' ,Company_Name='" & companyname & "',Duties='" & duties & "',Start_Date= " & "'" & startdate & "'" & ",End_Date=" & "'" & enddate & "'" & "  WHERE Personal_Details_ID = '" & id & "' "

            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            'result="true"

            sql = "UPDATE applicant_drivers_license SET Drivers_License_Code_ID=" & CStr(license) & " , Drivers_License_Status_ID=" & CStr(licensestatus) & ""

            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            '  result = "true"

            result = "true"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        Catch ex As Exception
            result = "update applicant" + ex.Message.ToString()
        End Try
        Return result
    End Function


    Public Function GetAllApplicantDetailsByIDS(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim Position As String = "Applicant"
        Try
            sql = "SELECT system_login.Login_ID,system_login.Password,system_login.Email,system_login.Position_ID,applicant_university.University_Name,applicant_university.University_ID,applicant_nationality.Nationality,applicant_nationality.Nationality_ID,applicant_marital_status.marital_Status,applicant_marital_status.marital_Status_ID,applicant_gender.Gender,applicant_gender.Gender_ID,        applicant_drivers_license.Drivers_License_ID, applicant_drivers_license_status.Drivers_License_Status_ID,applicant_drivers_license_status.Drivers_License_Status,  applicant_drivers_license_code.Drivers_License_Code_ID,applicant_drivers_license_code.Drivers_License_Code, applicant_race.Race,applicant_race.Race_ID,applicant_disability.Disability_ID,applicant_disability.Disability,applicant_disability_type.Disability_Type,applicant_reference.Contact_Number,applicant_reference.Reference_Name,applicant_reference.Email_Address,applicant_reference.Relationship,applicant_experience.Job_Name, applicant_experience.Company_Name,applicant_experience.Duties, applicant_experience.Start_Date, applicant_experience.End_Date,applicant_province_municipality_city.City_Name,applicant_province_municipality_city.Province_Municipality_City_ID,applicant_address.Address_Line_1,applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number, applicant_personal_details.Criminal_Record,applicant_personal_details.Skills,applicant_personal_details.Application_Status, applicant_personal_details.Number_Of_Dependencies,applicant_qualification.Qualification_Name,applicant_qualification.Qualification_ID,applicant_qualification_status.Qualification_Status,applicant_qualification_status.Qualification_Status_ID, applicant_person_qualification_university_field_of_study.Field_Of_Study,system_position.Position,system_position.Position_ID,applicant_province_municipality.Municipality_Name,applicant_province_municipality.Municipality_Province_ID,applicant_province.Province_Name,applicant_province.Province_ID
 From system_login,applicant_disability_type,applicant_university,applicant_nationality,applicant_marital_status,applicant_gender,applicant_drivers_license,applicant_drivers_license_status,applicant_drivers_license_code,applicant_race,applicant_disability,applicant_reference,applicant_experience,applicant_province_municipality_city,applicant_address,applicant_personal_details,applicant_qualification,applicant_qualification_status,applicant_person_qualification_university_field_of_study,system_position,applicant_province_municipality, applicant_province
Where  system_position.Position_ID=system_login.Position_ID And applicant_university.University_ID = applicant_person_qualification_university_field_of_study. University_ID And applicant_qualification.Qualification_ID =  applicant_person_qualification_university_field_of_study.Qualification_ID And applicant_qualification_status. Qualification_Status_ID =  applicant_person_qualification_university_field_of_study.Qualification_Status_ID And applicant_personal_details. Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID And applicant_nationality.Nationality_ID = applicant_personal_details.Nationality_ID And applicant_marital_status.Marital_Status_ID=applicant_personal_details.Marital_Status_ID And applicant_gender.Gender_ID =applicant_personal_details.Gender_ID  And applicant_drivers_license_code.Drivers_License_Code_ID = applicant_drivers_license.Drivers_License_Code_ID and applicant_drivers_license_status.Drivers_License_Status_ID = applicant_drivers_license.Drivers_License_Status_ID And applicant_personal_details.Personal_Details_ID = applicant_drivers_license.Personal_Details_ID   And applicant_race.Race_ID = applicant_personal_details.Race_ID And applicant_disability.Disability_ID=applicant_disability_type. Disability_ID and applicant_personal_details.Personal_Details_ID=applicant_disability_type.Personal_Details_ID And system_login.Login_ID = applicant_personal_details.Personal_Details_ID And system_login.Login_ID = applicant_reference.Personal_Details_ID  And system_login.Login_ID =applicant_experience.Personal_Details_ID And system_login.Login_ID =applicant_address.Personal_Details_ID And applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID And applicant_province.Province_ID = applicant_province_municipality.Province_ID And applicant_province_municipality.Municipality_Province_ID = applicant_province_municipality_city.Municipality_Province_ID And system_login.Login_ID ='" & id & "' "

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("get all applicants" + " " + ex.Message)
        End Try

        Return ds
    End Function
    'rejected all applicants
    Public Function GetAllRejectedApplicantDetailsByIDS(ByVal id As String, ByVal applicationStatus As Integer) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "SELECT system_login.Login_ID,system_login.Email,system_login.Position_ID,applicant_nationality.Nationality,applicant_nationality.Nationality_ID,applicant_gender.Gender,applicant_gender.Gender_ID,applicant_race.Race,applicant_race.Race_ID,applicant_disability.Disability_ID,applicant_disability.Disability,applicant_disability.Disability_Type,applicant_province_municipality_city.Province_Municipality_City_ID,applicant_address.Address_Line_1,applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number,applicant_personal_details.Application_Status,applicant_qualification.Qualification_Name,applicant_qualification.Qualification_ID,applicant_qualification_status.Qualification_Status,applicant_qualification_status.Qualification_Status_ID, applicant_person_qualification_university_field_of_study.Field_Of_Study,system_position.Position,system_position.Position_ID,applicant_province_municipality.Municipality_Name,applicant_province_municipality.Municipality_Province_ID,applicant_province.Province_Name,applicant_province.Province_ID
 From system_login,applicant_nationality,applicant_gender,applicant_race,applicant_disability,applicant_province_municipality_city,applicant_address,applicant_personal_details,applicant_qualification,applicant_qualification_status,applicant_person_qualification_university_field_of_study,system_position,applicant_province_municipality, applicant_province
Where system_position.Position_ID=system_login.Position_ID And applicant_person_qualification_university_field_of_study. University_ID And applicant_qualification.Qualification_ID =  applicant_person_qualification_university_field_of_study.Qualification_ID And applicant_qualification_status. Qualification_Status_ID =  applicant_person_qualification_university_field_of_study.Qualification_Status_ID And applicant_personal_details. Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID And applicant_nationality.Nationality_ID = applicant_personal_details.Nationality_ID And applicant_gender.Gender_ID =applicant_personal_details.Gender_ID  And applicant_race.Race_ID = applicant_personal_details.Race_ID And applicant_disability.Disability_ID=applicant_personal_details. Disability_ID And system_login.Login_ID = applicant_personal_details.Personal_Details_ID And  system_login.Login_ID =applicant_address.Personal_Details_ID And applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID And applicant_province.Province_ID = applicant_province_municipality.Province_ID And applicant_province_municipality.Municipality_Province_ID = applicant_province_municipality_city.Municipality_Province_ID And applicant_personal_details.Application_Status=" & CStr(applicationStatus) & " and applicant_personal_details='" & id & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Get all rejected applicants" + " " + ex.Message)
        End Try

        Return ds
    End Function
    ' all details for datagrid
    ' iqala apha le form for populating the form for all details for datagrid 
    Public Function GetAllApplicantsDetailsOnTheDatabase() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        'Dim Position As Integer = 1
        Dim Application_Status As Integer = 1
        Try

            sql = "Select distinct  system_login.Login_ID,system_login.Password,system_login.Email,system_position.Position, applicant_nationality.Nationality,applicant_marital_status.Marital_Status,applicant_gender.Gender,applicant_race.Race, applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number, applicant_personal_details.Criminal_Record,applicant_personal_details.Skills,applicant_personal_details.Application_Status, applicant_personal_details.Number_Of_Dependencies,
applicant_qualification_status.Qualification_Status,applicant_university.University_Name,applicant_qualification.Qualification_Name,applicant_person_qualification_university_field_of_study.Field_Of_Study,applicant_province_municipality_city.City_Name,applicant_address.Address_Line_1, applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,applicant_experience.Job_Name, applicant_experience.Company_Name, applicant_experience.Duties, applicant_experience.Start_Date,
applicant_experience.End_Date,applicant_reference.Contact_Number, applicant_reference.Reference_Name, applicant_reference.Email_Address, applicant_reference.Relationship
 
FROM system_login,system_position,applicant_personal_details,applicant_nationality,applicant_marital_status,applicant_gender, applicant_race,
applicant_qualification_status, applicant_university,applicant_qualification,applicant_person_qualification_university_field_of_study,applicant_province_municipality_city,applicant_address,applicant_experience,applicant_reference

WHERE system_position.Position_ID = system_login.Position_ID and
applicant_nationality.Nationality_ID = applicant_personal_details.Nationality_ID And
applicant_marital_status.Marital_Status_ID = applicant_personal_details.Marital_Status_ID And
applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
applicant_race.Race_ID = applicant_personal_details.Race_ID And

applicant_university.University_ID = applicant_person_qualification_university_field_of_study.University_ID And
applicant_qualification.Qualification_ID = applicant_person_qualification_university_field_of_study.Qualification_ID And
applicant_qualification_status.Qualification_Status_ID = applicant_person_qualification_university_field_of_study.Qualification_Status_ID And
applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID and
applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
applicant_personal_details.Personal_Details_ID = applicant_experience.Personal_Details_ID And 
applicant_personal_details.Personal_Details_ID = applicant_reference.Personal_Details_ID And
applicant_personal_details.Application_Status = " & CStr(Application_Status) & " and
system_login.Position_ID = 1 And system_login.Position_ID Is Not NULL"
            ',applicant_drivers_license_code,applicant_drivers_license_status,applicant_drivers_license
            ' applicant_drivers_license_code.Drivers_License_Code, applicant_drivers_license_status.Drivers_License_Status,
            '            applicant_drivers_license_code.Drivers_License_Code_ID = applicant_drivers_license.Drivers_License_Code_ID And
            'applicant_drivers_license_status.Drivers_License_Status_ID = applicant_drivers_license.Drivers_License_Status_ID And
            'applicant_personal_details.Personal_Details_ID = applicant_drivers_license.Personal_Details_ID And

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")

            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Get all applicants" + " " + ex.Message)
        End Try

        Return ds
    End Function
    'getting all applicant by id nume selected from combobox
    Public Function getAllApplicantByIDNumber(ByRef id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        'Dim Position As Integer = 1
        Dim Application_Status As String = "Applicant"
        Try

            sql = "select system_Position.Position, applicant_personal_details.Personal_Details_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from  system_Position,system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address
            where  applicant_race.Race_ID=applicant_personal_details.Race_ID AND
            system_login.Login_ID= applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID= applicant_address.Personal_Details_ID AND
            applicant_gender.Gender_ID= applicant_personal_details.Gender_ID AND
            applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID AND
            applicant_personal_details.Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID AND
            system_position.Position='" & Application_Status & " 'And
            applicant_personal_details.Personal_Details_ID='" & id & "'"

            ',applicant_drivers_license_code,applicant_drivers_license_status,applicant_drivers_license
            ' applicant_drivers_license_code.Drivers_License_Code, applicant_drivers_license_status.Drivers_License_Status,
            '            applicant_drivers_license_code.Drivers_License_Code_ID = applicant_drivers_license.Drivers_License_Code_ID And
            'applicant_drivers_license_status.Drivers_License_Status_ID = applicant_drivers_license.Drivers_License_Status_ID And
            'applicant_personal_details.Personal_Details_ID = applicant_drivers_license.Personal_Details_ID And

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")

            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Get all employees" + " " + ex.Message)
        End Try

        Return ds
    End Function

    'not on use
    'update shortlist to shortist the candidates
    Public Function UpdateToShortlist1(ByVal Applicant_id As String) As String
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Dim status As String = "Shortlisted"
        Try

            sql = "Update applicant_personal_details set  Application_Status ='" & status & "' where ID_number='" + Applicant_id + "'"
            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            'cmd.Parameters.Add(New MySqlParameter("@status", status))
            cmd.Parameters.Add(New MySqlParameter("@id", Applicant_id))
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If


        Catch ex As Exception
            result = "AddInterview" & ex.Message.ToString()
        End Try
        Return result
    End Function

    Public Function GetAllApplicantDetails() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim Position As String = "Applicant"
        Try
            '            sql = "SELECT system_login.Login_ID,system_login.Password,system_login.Email,system_login.Position_ID,applicant_university.University_Name,applicant_university.University_ID,applicant_nationality.Nationality,applicant_nationality.Nationality_ID,applicant_marital_status.marital_Status,applicant_marital_status.marital_Status_ID,applicant_gender.Gender,applicant_gender.Gender_ID,applicant_drivers_license.Drivers_License_Code,applicant_drivers_license.Drivers_License_ID,applicant_race.Race,applicant_race.Race_ID,applicant_disability.Disability_ID,applicant_disability.Disability,applicant_disability.Disability_Type,applicant_reference.Contact_Number,applicant_reference.Reference_Name,applicant_reference.Email_Address,applicant_reference.Relationship,applicant_experience.Job_Name, applicant_experience.Company_Name,applicant_experience.Duties, applicant_experience.Start_Date, applicant_experience.End_Date,applicant_province_municipality_city.City_Name,applicant_province_municipality_city.Province_Municipality_City_ID,applicant_address.Address_Line_1,applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number, applicant_personal_details.Criminal_Record,applicant_personal_details.Skills,applicant_personal_details.Application_Status, applicant_personal_details.Number_Of_Dependencies,applicant_qualification.Qualification_Name,applicant_qualification.Qualification_ID,applicant_qualification_status.Qualification_Status,applicant_qualification_status.Qualification_Status_ID, applicant_person_qualification_university_field_of_study.Field_Of_Study,system_position.Position,system_position.Position_ID,applicant_province_municipality.Municipality_Name,applicant_province_municipality.Municipality_Province_ID,applicant_province.Province_Name,applicant_province.Province_ID
            ' From system_login,applicant_university,applicant_nationality,applicant_marital_status,applicant_gender,applicant_drivers_license,applicant_race,applicant_disability,applicant_reference,applicant_experience,applicant_province_municipality_city,applicant_address,applicant_personal_details,applicant_qualification,applicant_qualification_status,applicant_person_qualification_university_field_of_study,system_position,applicant_province_municipality, applicant_province
            'Where  system_position.Position_ID=system_login.Position_ID And applicant_university.University_ID = applicant_person_qualification_university_field_of_study. University_ID And applicant_qualification.Qualification_ID =  applicant_person_qualification_university_field_of_study.Qualification_ID And applicant_qualification_status. Qualification_Status_ID =  applicant_person_qualification_university_field_of_study.Qualification_Status_ID And applicant_personal_details. Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID And applicant_nationality.Nationality_ID = applicant_personal_details.Nationality_ID And applicant_marital_status.Marital_Status_ID=applicant_personal_details.Marital_Status_ID And applicant_gender.Gender_ID =applicant_personal_details.Gender_ID  And applicant_drivers_license.Drivers_License_ID= applicant_personal_details.Drivers_License_ID And applicant_race.Race_ID = applicant_personal_details.Race_ID And applicant_disability.Disability_ID=applicant_personal_details. Disability_ID And system_login.Login_ID = applicant_personal_details.Personal_Details_ID And system_login.Login_ID = applicant_reference.Personal_Details_ID  And system_login.Login_ID =applicant_experience.Personal_Details_ID And system_login.Login_ID =applicant_address.Personal_Details_ID And applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID And applicant_province.Province_ID = applicant_province_municipality.Province_ID And applicant_province_municipality.Municipality_Province_ID = applicant_province_municipality_city.Municipality_Province_ID And system_position.Position ='" & Position & "' "
            sql = "select * from system_login,system_position where system_position.Position_ID = system_login.Position_ID And system_position.Position='" & Position & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("get all applicants" + " " + ex.Message)
        End Try

        Return ds
    End Function
    'they start here  Functions for loading all information about the applicant in the database 
    '//////////////////////////////
    Function getAllinfoOnPersonal_Details() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_personal_details"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Function getAllinfoOnPersonal_loginDetails() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from system_login"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Function getAllinfoOnPersonal_Address() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_address"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Function getAllinfoOnPersonal_Reference() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_reference"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Function getAllinfoOnPersonal_Experience() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_experience"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Function getAllinfoOnPersonal_() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_address"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    'they end here all the functions for loading all applicants in the database










    '    Public Function GetAllApplicantDetailsOnDatabase(ByVal id As String) As DataSet
    '        Dim sql As String
    '        Dim ds As New DataSet
    '        Dim da As MySqlDataAdapter

    '        Try
    '            sql = "SELECT system_login.Login_ID,system_login.Password,system_login.Email,system_login.Position_ID,applicant_university.University_Name,applicant_university.University_ID,applicant_nationality.Nationality,applicant_nationality.Nationality_ID,applicant_marital_status.marital_Status,applicant_marital_status.marital_Status_ID,applicant_gender.Gender,applicant_gender.Gender_ID,applicant_drivers_license.Drivers_License_Code,applicant_drivers_license.Drivers_License_ID,applicant_race.Race,applicant_race.Race_ID,applicant_disability.Disability_ID,applicant_disability.Disability,applicant_disability.Disability_Type,applicant_reference.Contact_Number,applicant_reference.Reference_Name,applicant_reference.Email_Address,applicant_reference.Relationship,applicant_experience.Job_Name, applicant_experience.Company_Name,applicant_experience.Duties, applicant_experience.Start_Date, applicant_experience.End_Date,applicant_province_municipality_city.City_Name,applicant_province_municipality_city.Province_Municipality_City_ID,applicant_address.Address_Line_1,applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number, applicant_personal_details.Criminal_Record,applicant_personal_details.Skills,applicant_personal_details.Application_Status, applicant_personal_details.Number_Of_Dependencies,applicant_qualification.Qualification_Name,applicant_qualification.Qualification_ID,applicant_qualification_status.Qualification_Status,applicant_qualification_status.Qualification_Status_ID, applicant_person_qualification_university_field_of_study.Field_Of_Study,system_position.Position,system_position.Position_ID,applicant_province_municipality.Municipality_Name,applicant_province_municipality.Municipality_Province_ID,applicant_province.Province_Name,applicant_province.Province_ID
    ' From system_login,applicant_university,applicant_nationality,applicant_marital_status,applicant_gender,applicant_drivers_license,applicant_race,applicant_disability,applicant_reference,applicant_experience,applicant_province_municipality_city,applicant_address,applicant_personal_details,applicant_qualification,applicant_qualification_status,applicant_person_qualification_university_field_of_study,system_position,applicant_province_municipality, applicant_province
    'Where  system_position.Position_ID=system_login.Position_ID And applicant_university.University_ID = applicant_person_qualification_university_field_of_study. University_ID And applicant_qualification.Qualification_ID =  applicant_person_qualification_university_field_of_study.Qualification_ID And applicant_qualification_status. Qualification_Status_ID =  applicant_person_qualification_university_field_of_study.Qualification_Status_ID And applicant_personal_details. Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID And applicant_nationality.Nationality_ID = applicant_personal_details.Nationality_ID And applicant_marital_status.Marital_Status_ID=applicant_personal_details.Marital_Status_ID And applicant_gender.Gender_ID =applicant_personal_details.Gender_ID  And applicant_drivers_license.Drivers_License_ID= applicant_personal_details.Drivers_License_ID And applicant_race.Race_ID = applicant_personal_details.Race_ID And applicant_disability.Disability_ID=applicant_personal_details. Disability_ID And system_login.Login_ID = applicant_personal_details.Personal_Details_ID And system_login.Login_ID = applicant_reference.Personal_Details_ID  And system_login.Login_ID =applicant_experience.Personal_Details_ID And system_login.Login_ID =applicant_address.Personal_Details_ID And applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID And applicant_province.Province_ID = applicant_province_municipality.Province_ID And applicant_province_municipality.Municipality_Province_ID = applicant_province_municipality_city.Municipality_Province_ID And system_login.Login_ID = '" & id & "'"

    '            da = New MySqlDataAdapter(sql, MySqlConn)
    '            da.Fill(ds, "system_login")
    '            MySqlConn.Open()

    '            MySqlConn.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("get all employees" + " " + ex.Message)
    '        End Try

    '        Return ds
    'End Function





    '"SELECT system_login.Login_ID,system_login.Password,system_login.Email,
    'applicant_university.University_Name,
    'applicant_nationality.Nationality,
    'applicant_marital_status.marital_Status,
    'applicant_gender.Gender,
    'applicant_drivers_license.Drivers_License_Code,applicant_race.Race,
    'applicant_disability.Disability,applicant_disability.Disability_Type,
    'applicant_reference.Contact_Number,applicant_reference.Reference_Name,applicant_reference.Email_Address,applicant_reference.Relationship,
    'applicant_experience.Job_Name, applicant_experience.Company_Name,applicant_experience.Duties, applicant_experience.Start_Date, applicant_experience.End_Date,
    'applicant_province_municipality_city.City_Name,
    'applicant_address.Address_Line_1,applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,
    'applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, 
    'applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number, applicant_personal_details.Criminal_Record,
    'applicant_personal_details.Skills,applicant_personal_details.Application_Status, applicant_personal_details.Number_Of_Dependencies,
    'applicant_qualification.Qualification_Name,applicant_qualification_status.Qualification_Status, 
    'applicant_person_qualification_university_field_of_study.Field_Of_Study,system_position.Position,
    'applicant_province_municipality.Municipality_Name, applicant_province.Province_Name
    ' From
    'system_login,applicant_university,applicant_nationality,applicant_marital_status,applicant_gender,applicant_drivers_license,
    'applicant_race,applicant_disability,applicant_reference,applicant_experience,applicant_province_municipality_city,applicant_address
    'applicant_personal_details,applicant_qualification,applicant_qualification_status,applicant_person_qualification_university_field_of_study,system_position,
    'applicant_province_municipality, applicant_province
    'Where  system_position. Position_ID=system_login.Position_ID  And
    '(applicant_university.University_ID = applicant_person_qualification_university_field_of_study. University_ID) And
    '(applicant_qualification.Qualification_ID =  applicant_person_qualification_university_field_of_study.Qualification_ID) And
    '(applicant_qualification_status. Qualification_Status_ID =  applicant_person_qualification_university_field_of_study.Qualification_Status_ID) And
    '(applicant_personal_details. Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID)And
    '(applicant_nationality.Nationality_ID = applicant_personal_details.Nationality_ID) And
    '( applicant_marital_status.Marital_Status_ID=applicant_personal_details.Marital_Status_ID) And
    '(applicant_gender.Gender_ID =applicant_personal_details.Gender_ID ) And
    '( applicant_drivers_license.Drivers_License_ID= applicant_personal_details.Drivers_License_ID ) And
    '( applicant_race.Race_ID = applicant_personal_details.Race_ID) And
    '( applicant_disability.Disability_ID=applicant_personal_details. Disability_ID) And
    '( system_login.Login_ID = applicant_personal_details.Personal_Details_ID )And
    '( system_login.Login_ID = applicant_reference.Personal_Details_ID ) And
    '( system_login.Login_ID =applicant_experience.Personal_Details_ID  ) And
    '( system_login.Login_ID =applicant_address.Personal_Details_ID ) And
    '(applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID) And
    '(applicant_province.Province_ID = applicant_province_municipality.Province_ID) And
    '(applicant_province_municipality.Municipality_Province_ID = applicant_province_municipality_city.Municipality_Province_ID)And
    '( system_login.Login_ID ='" & 9910230772083 & "') "




    'fill qualification statuses
    Public Function getAllqualificationStatus() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_qualification_status "

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function
    'testing a function
    Public Function Num(ByVal value As String) As Integer
        Dim returnVal As String = String.Empty
        Dim collection As MatchCollection = Regex.Matches(value, "^\d+")
        For Each m As Match In collection
            returnVal += m.ToString()
        Next
        Return Convert.ToInt32(returnVal)
    End Function


    'start hereee monwa sutrday >.>.................../////////////////////////////////////
    Public Function applicantbyidss(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_personal_details where Personal_Details_ID= '" & id & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds

    End Function
    Public Function AddressOfApplicantbyid(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_address where Personal_Details_ID = '" & id & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function
    Public Function qualificationFOSById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_person_qualification_university_field_of_study where Personal_Details_ID = '" & id & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function
    Public Function referenceByIds(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select * from applicant_reference where Personal_Details_ID = '" & id & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Public Function experience(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select Job_Name , Company_Name,Duties from applicant_experience where Personal_Details_ID = '" & id & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")

            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function
    'END HERE TODAY SUTRDAY MONWAI.........////////////////////////;;;;'''''''''''''


    Public Function detailsById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select FirstName,Surname, ShortlistPoints from applicant_personal_details where ID_number = '" & id & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "dtApplicantDetails")
            MySqlConn.Open()

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function
    Public Function AddInterview(ByVal Inteviewer As String, ByVal IDNumber As String, ByVal LastName As String, ByVal FirstName As String, ByVal FitPoints As Integer, ByVal ScrumPoints As Integer, ByVal interviewPoints As Integer, ByVal PresentationPoints As Integer, ByVal Shortlist As Integer, ByVal TotalScore As Integer, ByVal PercentageScore As Integer) As String
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Try

            sql = "INSERT INTO Interviewing (Inteviewer,IDNumber, LastName, FirstName,FitPoints,ScrumPoints,interviewPoints,PresentationPoints,Shortlist,TotalScore,PercentageScore) 
                    Values('" & Inteviewer & "','" & IDNumber & "' , '" & LastName & "','" & FirstName & "', " + CStr(FitPoints) + " , " + CStr(ScrumPoints) + " , " + CStr(interviewPoints) + " ," + CStr(PresentationPoints) + ", " + CStr(Shortlist) + ", " + CStr(TotalScore) + "," + CStr(PercentageScore) + " )"
            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.Parameters.Add(New MySqlParameter("@Inteviewer", Inteviewer))
            cmd.Parameters.Add(New MySqlParameter("@IDNumber", IDNumber))
            cmd.Parameters.Add(New MySqlParameter("@LastName", LastName))
            cmd.Parameters.Add(New MySqlParameter("@FirstName", FirstName))
            cmd.Parameters.Add(New MySqlParameter("@FitPoints", FitPoints))
            cmd.Parameters.Add(New MySqlParameter("@ScrumPoints", ScrumPoints))
            cmd.Parameters.Add(New MySqlParameter("@interviewPoints", interviewPoints))
            cmd.Parameters.Add(New MySqlParameter("@PresentationPoints", PresentationPoints))
            cmd.Parameters.Add(New MySqlParameter("@Shortlist", Shortlist))
            cmd.Parameters.Add(New MySqlParameter("@TotalScore", TotalScore))
            cmd.Parameters.Add(New MySqlParameter("@PercentageScore", PercentageScore))
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If


        Catch ex As Exception
            result = "AddInterview" & ex.Message.ToString()
        End Try
        Return result
    End Function

    Public Function GetallApplicant() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim Position As String = "Applicant"
        Try
            ' sql = "select applicant_personal_details.FirstName,applicant_personal_details.Surname,applicant_personal_details.MiddleName,applicant_personal_details.Email,applicant_personal_details.ContactNum,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.ShortListPoints,applicant_personal_details.CriminalRecord,applicant_personal_details.AltContactNumber,applicant_race.Race,applicant_address.City,applicant_person_qualification_university_field_of_study.Feild_Of_Study  from applicant_personal_details
            'inner join applicant_race on applicant_personal_details.ID_number=applicant_race.ID_Number
            'inner join applicant_address on applicant_personal_details.ID_number=applicant_address.ID_Number
            'inner join applicant_person_qualification_university_field_of_study on applicant_personal_details.ID_number=applicant_person_qualification_university_field_of_study.ID_Number
            'where ID_number='" & a & "'"
            sql = "Select system_login.Login_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_position.Position,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            system_position.Position_ID=system_login.Position_ID and
            system_position.Position = '" & Position & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get all applicant" & " " & ex.Message)
        End Try

        Return ds
    End Function


    'select province name (for load kwi combobox)
    Public Function getAllProvinces() As DataSet
        Dim sql As String
        Dim ds8 As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_province"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds8, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all provinces" + " " + ex.Message)
        End Try

        Return ds8
    End Function


    Public Function getAllManicipalitytest(ByVal provinces As String) As DataSet
        Dim sql As String
        Dim dsMunicipalityName As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select DISTINCT applicant_province_municipality.Municipality_Name,applicant_province.Province_ID from applicant_province_municipality,applicant_province where  
applicant_province.Province_ID =applicant_province_municipality.Province_ID and applicant_province.Province_Name = '" + provinces + "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsMunicipalityName, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all municipality" + " " + ex.Message)
        End Try

        Return dsMunicipalityName
    End Function


    Public Function getAllCitiesBasedOnMunicipality(ByVal Provinces As String, ByVal MUNICIPALITY As String) As DataSet
        Dim sql As String
        Dim dscityName As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select applicant_province.Province_ID, applicant_province_municipality.Municipality_Province_ID,applicant_province_municipality_city.City_Name,applicant_province_municipality_city.Province_Municipality_City_ID from applicant_province, applicant_province_municipality,applicant_province_municipality_city where
applicant_province.Province_ID=applicant_province_municipality.Province_ID and
applicant_province_municipality.Municipality_Province_ID=applicant_province_municipality_city.Municipality_Province_ID and
applicant_province.Province_Name='" + Provinces + "' and
applicant_province_municipality.Municipality_Name='" + MUNICIPALITY + "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dscityName, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all cities " + " " + ex.Message)
        End Try

        Return dscityName
    End Function



    'select qualification name (for load kwi combobox)
    Public Function getAllqualifications() As DataSet
        Dim sql As String
        Dim dsqualificationName As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_qualification "
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsqualificationName, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all qualification names" + " " + ex.Message)
        End Try

        Return dsqualificationName
    End Function
    Public Function getAllgender() As DataSet
        Dim sql As String
        Dim dsgender As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select Gender,Gender_ID from applicant_gender"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsgender, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all genders" + " " + ex.Message)
        End Try

        Return dsgender
    End Function

    'select qualification status (for load kwi combobox)
    Public Function getqualificationstatus() As DataSet
        Dim sql As String
        Dim dsqualificationstatus As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_qualification_status"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsqualificationstatus, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all qualification statuses" + " " + ex.Message)
        End Try

        Return dsqualificationstatus
    End Function

    'select institution name (for load kwi combobox)
    Public Function getAllUniversity() As DataSet
        Dim sql As String
        Dim dsuniversity As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_university"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsuniversity, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all institutions" + " " + ex.Message)
        End Try

        Return dsuniversity
    End Function
    'select field of study (for load kwi combobox)
    Public Function getAllFieldOfStudy() As DataSet
        Dim sql As String
        Dim dsfieldofstudy As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_person_qualification_university_field_of_study"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsfieldofstudy, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all field of study" + " " + ex.Message)
        End Try

        Return dsfieldofstudy
    End Function
    'select marital status (for load kwi combobox)
    Public Function getAllMarital() As DataSet
        Dim sql As String
        Dim dsmarital As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_marital_status"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsmarital, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all marital status" + " " + ex.Message)
        End Try

        Return dsmarital
    End Function
    'select nationality (for load kwi combobox)
    Public Function getAllNationality() As DataSet
        Dim sql As String
        Dim dsnationality As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_nationality"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dsnationality, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all nationality" + " " + ex.Message)
        End Try

        Return dsnationality
    End Function
    'select drivers license and vehichle restriction (for load kwi combobox)
    Public Function getAllLicense() As DataSet
        Dim sql As String
        Dim dslicense As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_drivers_license_code"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dslicense, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all License code" + " " + ex.Message)
        End Try

        Return dslicense
    End Function
    'select drivers license and vehichle restriction (for load kwi combobox)
    Public Function getAllStatus() As DataSet
        Dim sql As String
        Dim dslicense As New DataSet
        Dim da As MySqlDataAdapter

        Try
            sql = "select * from applicant_drivers_license_status"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(dslicense, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If
            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get all restrictions " + " " + ex.Message)
        End Try

        Return dslicense
    End Function

    'shortlist counting

    Public Function GetApplicantDetailsById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select applicant_personal_details.ID_number,applicant_personal_details.FirstName,applicant_personal_details.Surname,applicant_personal_details.MiddleName,applicant_personal_details.Email,applicant_personal_details.ContactNum,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.ShortListPoints,applicant_personal_details.CriminalRecord,applicant_personal_details.AltContactNumber,applicant_race.Race,applicant_address.City,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Feild_Of_Study,applicant_qualification.Qualification_Name from applicant_personal_details,applicant_gender,applicant_race,applicant_address,applicant_person_qualification_university_field_of_study ,applicant_qualification
            where  applicant_personal_details.ID_number=applicant_race.ID_Number AND
            applicant_personal_details.ID_number= applicant_address.ID_Number AND
            applicant_personal_details.ID_number=applicant_gender.ID_Number AND
            applicant_personal_details.ID_number=applicant_person_qualification_university_field_of_study.ID_Number AND
            applicant_qualification.Qualification_ID=applicant_person_qualification_university_field_of_study.Qualification_ID AND
            applicant_personal_details.ID_number='" + id + "'"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
        Catch ex As Exception
            MessageBox.Show("Get Qualification,Race And Gender" + " " + ex.Message)
        End Try

        Return ds
    End Function

    Public Function GetAllEmployeeID() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select Login_ID from system_login"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get ID Of Applicant" + " " + ex.Message)
        End Try

        Return ds
    End Function


    Public Function GetApplicantRace() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select *  FROM applicant_race"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get race Of Applicant" + " " + ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetAllposition() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select *  FROM system_position"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get system_positions" + " " + ex.Message)
        End Try

        Return ds
    End Function

    Public Function GetApplicantByGender(ByVal gender As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim position As String = "Applicant"
        Try
            sql = "Select system_login.Login_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_position.Position,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            system_position.Position_ID=system_login.Position_ID and
            system_position.Position = '" & position & "' and
            applicant_gender.Gender ='" & gender & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by gender" & " " & ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetApplicantByFieldOfStudy(ByVal study As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim position As String = "Applicant"
        Try
            sql = "Select system_login.Login_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_position.Position,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            system_position.Position_ID=system_login.Position_ID and
            system_position.Position = '" & position & "' and
            applicant_person_qualification_university_field_of_study.Field_Of_Study ='" & study & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by field of study" & " " & ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetApplicantByRace(ByVal race As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim position As String = "Applicant"
        Try
            sql = "Select system_login.Login_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_position.Position,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            system_position.Position_ID=system_login.Position_ID and
            system_position.Position = '" & position & "' and
            applicant_race.Race ='" & race & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by race" & " " & ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetApplicantByCity(ByVal city As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim position As String = "Applicant"
        Try
            sql = "Select system_login.Login_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_position.Position,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            system_position.Position_ID=system_login.Position_ID and
            system_position.Position = '" & position & "' and
           applicant_province_municipality_city.City_Name='" & city & "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" & " " & ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetAllInfoOfRejected() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As Integer = 0
        Dim applicant As String = "Applicant"
        Try
            sql = "select applicant_personal_details.Personal_Details_ID,system_position.Position,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID=applicant_personal_details.Race_ID AND
            system_login.Login_ID= applicant_personal_details.Personal_Details_ID And
            system_position.Position_ID=system_login.Position_ID and
            applicant_personal_details.Personal_Details_ID= applicant_address.Personal_Details_ID AND
            applicant_gender.Gender_ID= applicant_personal_details.Gender_ID AND
            applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID AND
            applicant_personal_details.Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID AND
            applicant_personal_details.Application_Status=" & CStr(status) & " and
            system_position.Position ='" & applicant & "'"



            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" & " " & ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetAllInfoOfApproved() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As String = "Approved"
        Try
            sql = "select applicant_personal_details.ID_number,applicant_personal_details.FirstName,applicant_personal_details.Surname,applicant_personal_details.MiddleName,applicant_personal_details.Email,applicant_personal_details.ContactNum,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.ShortListPoints,applicant_personal_details.CriminalRecord,applicant_personal_details.AltContactNumber,applicant_race.Race,applicant_address.City,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Feild_Of_Study  from applicant_personal_details,applicant_gender,applicant_race,applicant_address,applicant_person_qualification_university_field_of_study
            where  applicant_personal_details.ID_number=applicant_race.ID_Number AND
            applicant_personal_details.ID_number= applicant_address.ID_Number AND
            applicant_personal_details.ID_number=applicant_gender.ID_Number AND
            applicant_personal_details.ID_number=applicant_person_qualification_university_field_of_study.ID_Number AND
            applicant_personal_details.Application_Status='" + status + "'"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" + " " + ex.Message)
        End Try

        Return ds
    End Function

    ' get all the rejected applicants details
    Public Function GetRejectedDetailsById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As Integer = 0
        Try
            sql = "select applicant_personal_details.Personal_Details_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address
            where  applicant_race.Race_ID=applicant_personal_details.Race_ID AND
            system_login.Login_ID= applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID= applicant_address.Personal_Details_ID AND
            applicant_gender.Gender_ID= applicant_personal_details.Gender_ID AND
            applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID AND
            applicant_personal_details.Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID AND
            applicant_personal_details.Application_Status=" & CStr(status) & " And
            applicant_personal_details.Personal_Details_ID ='" & id & "'"



            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" & " " & ex.Message)
        End Try

        Return ds
    End Function
    Public Function GetShortlistedDetailsById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As Integer = 1
        Try
            sql = "select applicant_personal_details.Personal_Details_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address
            where  applicant_race.Race_ID=applicant_personal_details.Race_ID AND
            system_login.Login_ID= applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID= applicant_address.Personal_Details_ID AND
            applicant_gender.Gender_ID= applicant_personal_details.Gender_ID AND
            applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID AND
            applicant_personal_details.Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID AND
            applicant_personal_details.Application_Status=" & CStr(status) & " and
            applicant_personal_details.Personal_Details_ID ='" & id & "'"



            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" & " " & ex.Message)
        End Try

        Return ds
    End Function

    ' get all the approved applicants details using an id
    Public Function GetApprovedDetailsById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As String = "Approved"
        Try
            sql = "select applicant_personal_details.ID_number,applicant_personal_details.FirstName,applicant_personal_details.Surname,applicant_personal_details.MiddleName,applicant_personal_details.Email,applicant_personal_details.ContactNum,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.ShortListPoints,applicant_personal_details.CriminalRecord,applicant_personal_details.AltContactNumber,applicant_race.Race,applicant_address.City,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Feild_Of_Study  from applicant_personal_details,applicant_gender,applicant_race,applicant_address,applicant_person_qualification_university_field_of_study
            where  applicant_personal_details.ID_number=applicant_race.ID_Number AND
            applicant_personal_details.ID_number= applicant_address.ID_Number AND
            applicant_personal_details.ID_number=applicant_gender.ID_Number AND
            applicant_personal_details.ID_number=applicant_person_qualification_university_field_of_study.ID_Number AND
            applicant_personal_details.Application_Status='" + status + "'AND
            applicant_personal_details.ID_number='" + id + "'"



            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" + " " + ex.Message)
        End Try

        Return ds
    End Function

    ' get all the shortlisted applicants details using an id
    Public Function GetShortlistDetailsById(ByVal id As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As Integer = 1
        Try
            sql = "select applicant_personal_details.Personal_Details_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address
            where  applicant_race.Race_ID=applicant_personal_details.Race_ID AND
            system_login.Login_ID= applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID= applicant_address.Personal_Details_ID AND
            applicant_gender.Gender_ID= applicant_personal_details.Gender_ID AND
            applicant_province_municipality_city.Province_Municipality_City_ID= applicant_address.Province_Municipality_City_ID AND
            applicant_personal_details.Personal_Details_ID=applicant_person_qualification_university_field_of_study.Personal_Details_ID AND
            applicant_personal_details.Application_Status=" & CStr(status) & " and
            applicant_personal_details.Personal_Details_ID='" & id & "'"






            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" & " " & ex.Message)
        End Try

        Return ds
    End Function

    ' get all the shortlisted applicants details
    Public Function GetAllInfoOfShortlisted() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim status As Integer = 1
        Dim applicant As String = "Applicant"
        Try
            sql = "Select applicant_personal_details.Personal_Details_ID,system_position.Position,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            system_position.Position_ID = system_login.Position_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            applicant_personal_details.Application_Status = " & CStr(status) & " And
            system_position.Position ='" & applicant & "'"




            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("get applicant by city" & " " & ex.Message)
        End Try

        Return ds
    End Function

    'get all positions
    Public Function Getpositions() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try

            sql = "SELECT DISTINCT Position FROM system_position"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Worker")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Get positions" + " " + ex.Message)
        End Try
        Return ds
    End Function

    Public Function GetLogin(ByVal username As String) As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try

            sql = "Select DISTINCT system_position.Position,Password,Login_ID FROM system_login,system_position Where (system_position.Position_ID=system_login.Position_ID) And (Login_ID= '" & username & "')"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Worker")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("get login details" + " " + ex.Message)
        End Try
        Return ds
    End Function




    Public Function GetApprovedid() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim status As String = "Approved"
        Try

            sql = "SELECT ID_number,FirstName FROM applicant_personal_details  where Application_Status='" + status + "'"
            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("approved applicant ID's" + " " + ex.Message)
        End Try
        Return ds
    End Function
    Public Function GetShortlistedid() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim status As Integer = 1
        Try

            sql = "SELECT Personal_Details_ID, First_Name FROM applicant_personal_details  where Application_Status=" & CStr(status) & ""
            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("shortlisted applicant ID's" & " " & ex.Message)
        End Try
        Return ds
    End Function
    ' get all the rejected ID's 
    Public Function GetRejectedid() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim status As Integer = 0
        Try

            sql = "SELECT Personal_Details_ID,First_Name FROM applicant_personal_details  where Application_Status=" & CStr(status) & ""
            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("rejected applicant ID's" & " " & ex.Message)
        End Try
        Return ds
    End Function
    ' get id for shortlisted candidates
    Public Function GetShortlistedById(ByVal shortlisted As String) As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try

            sql = "SELECT ID_number FROM applicant_personal_details where Application_Status='" + shortlisted + "'"
            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("getall name,surname" + " " + ex.Message)
        End Try
        Return ds
    End Function


    'update shortlist to shortist the candidates
    Public Function UpdateToShortlist(ByVal Applicant_id As String) As String
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Dim status As Integer = 1
        Try

            sql = "Update applicant_personal_details set  Application_Status =" & CStr(status) & " where Personal_Details_ID ='" & Applicant_id & "'"
            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            'cmd.Parameters.Add(New MySqlParameter("@status", status))
            cmd.Parameters.Add(New MySqlParameter("@id", Applicant_id))
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If


        Catch ex As Exception
            result = "AddInterview" & ex.Message.ToString()
        End Try
        Return result
    End Function
    'update candidate from  shortlist "status" to rejected "status"
    Public Function UpdateToReject(ByVal Applicant_id As String) As String
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Dim status As Integer = 0
        Try

            sql = "Update applicant_personal_details set  Application_Status =" & CStr(status) & " where Personal_Details_ID ='" & Applicant_id & "'"
            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            ' cmd.Parameters.Add(New MySqlParameter("@Status", status))
            cmd.Parameters.Add(New MySqlParameter("@id", Applicant_id))
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"

            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If


        Catch ex As Exception
            result = "AddInterview" & ex.Message.ToString()
        End Try
        Return result
    End Function
    'upadate Approved function  (fom shortlisted to approved or frrom rejected to approved)
    Public Function UpdateToApprove(ByVal Applicant_id As String) As String
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Dim status As String = "Approved"
        Try

            sql = "Update applicant_personal_details set Application_Status = '" + status + "' where ID_number ='" + Applicant_id + "'"
            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            ' cmd.Parameters.Add(New MySqlParameter("@status", status))
            cmd.Parameters.Add(New MySqlParameter("@id", Applicant_id))
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If


        Catch ex As Exception
            result = "AddInterview" & ex.Message.ToString()
        End Try
        Return result
    End Function
    'function for filtering
    Public Function Getfiltering(ByVal gender As String, ByVal race As String, ByVal location As String, ByVal field As String) As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Dim position As String = "Applicant"
        Try


            sql = "Select applicant_personal_details.Personal_Details_ID,system_login.Login_ID,applicant_personal_details.First_Name,applicant_personal_details.Surname,applicant_personal_details.Middle_Name,system_position.Position,system_login.Email,applicant_personal_details.Contact_Number,applicant_personal_details.Skills,applicant_personal_details.Application_Status,applicant_personal_details.Criminal_Record,applicant_personal_details.Alt_Contact_Number,applicant_race.Race,applicant_province_municipality_city.City_Name,applicant_gender.Gender,applicant_person_qualification_university_field_of_study.Field_Of_Study  from system_login, applicant_personal_details,applicant_gender,applicant_race,applicant_province_municipality_city,applicant_person_qualification_university_field_of_study,applicant_address,system_position
            where  applicant_race.Race_ID = applicant_personal_details.Race_ID And
            system_login.Login_ID = applicant_personal_details.Personal_Details_ID And
            applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And
            applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And
            applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
            applicant_personal_details.Personal_Details_ID = applicant_person_qualification_university_field_of_study.Personal_Details_ID And
            system_position.Position_ID = system_login.Position_ID And
            system_position.Position = '" & position & "' And
            applicant_gender.Gender ='" & gender & "' AND
            applicant_race.Race ='" & race & "' AND
            applicant_province_municipality_city.City_Name ='" & location & "' AND
            applicant_person_qualification_university_field_of_study.Field_Of_Study ='" & field & "'"

            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("getall name,surname" & " " & ex.Message)
        End Try
        Return ds
    End Function

    'update employee information system_position As String,
    Public Function UpdateEmployees(ByVal id As String, ByVal name As String, ByVal surname As String, ByVal phonenumber As String, ByVal email As String, ByVal uname As String, ByVal pword As String, ByVal system_position As String, ByVal add1 As String, ByVal add2 As String, ByVal add3 As String, ByVal province As String, ByVal Municipality As String, ByVal city As String, ByVal postalcode As Integer, ByVal gender As String, ByVal race As String) As String
        Dim sql As String
        'Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Try
            ' sql = "update  Worker set  LastName='" + name + "', FirstName='" + surname + "', Gender='" + gender + "', Race='" + race + "',system_position='" + system_position + "',Username='" + uname + "',Passwords='" + pword + "',PhoneNumber='" + phonenumber + "',Email='" + email + "',Street='" + street + "', Province='" + province + "',Municipality='" + Municipality + "',City='" + city + "',PostalCode=" + CStr(postalcode) + ", Streets='" + streets + "',Provinces='" + province2 + "', Municipalitys='" + Municipalitys + "',Citys='" + citys + "',PostalCodes=" + CStr(postalcodes) + " where IDNumber='" + id + "'"
            sql = "update  worker_details set  LastName='" + name + "', FisrtName='" + surname + "', PhoneNumber='" + phonenumber + "',Email='" + email + "' where Worker_ID='" + id + "'"

            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            MessageBox.Show("workdetails2...." + sql)

            cmd.ExecuteNonQuery()
            result = "true"



            sql = "update  worker_login set Username='" + uname + "', Password='" + pword + "', Position='" + system_position + "' where Worker_ID = '" + id + "'"

            MessageBox.Show("login...." + sql)
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.ExecuteNonQuery()
            result = "true"

            sql = "update  worker_address set Address_Line_1='" + add1 + "', Address_Line_2 ='" + add2 + "',Address_Line_3='" + add3 + "', Province='" + province + "',Municipality='" + Municipality + "',City='" + city + "',Postal_Code=" + CStr(postalcode) + " where Worker_ID='" + id + "'"

            MessageBox.Show("address...." + sql)
            cmd = New MySqlCommand(sql, MySqlConn)

            cmd.ExecuteNonQuery()
            result = "true"

            sql = "update  worker_gender set  Gender='" + gender + "' where Worker_ID='" + id + "'"

            MessageBox.Show("gender...." + sql)
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.ExecuteNonQuery()
            result = "true"
            sql = "update  worker_race set Race='" + race + "' where Worker_ID = '" + id + "'"

            MessageBox.Show("login...." + sql)
            cmd = New MySqlCommand(sql, MySqlConn)
            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If


        Catch ex As Exception

            result = "Update employee" + ex.Message.ToString()
        End Try
        Return result
    End Function

    'function ezingasebenziyo but xexo connector on database
    'additional function for connecting to asavela

    Public Function GetApplicantcity() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select City_Name FROM  applicant_province_municipality_city"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get the city " & " " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetApplicantfield() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select Field_Of_Study  FROM  applicant_person_qualification_university_field_of_study"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get the field of study " & " " & ex.Message)
        End Try

        Return ds

    End Function

    Public Function GetApplicantGender() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Try
            sql = "select *  FROM applicant_gender"
            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "Datas")
            If MySqlConn.State = ConnectionState.Closed Then
                MySqlConn.Open()
            End If

            If MySqlConn.State = ConnectionState.Open Then
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Get gender Of Applicant" & " " & ex.Message)
        End Try

        Return ds

    End Function
    Public Function UpdateApplicantsShortlist(ByVal id As String, ByVal shortlist As String) As String
        Dim sql As String
        'Dim ds As New DataSet
        Dim cmd As MySqlCommand
        Dim result As String
        Try

            sql = "update  applicant_personal_details set  ShortListPoints='" + shortlist + "' where ID_Number='" + id + "'"

            cmd = New MySqlCommand(sql, MySqlConn)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If


            cmd.ExecuteNonQuery()
            result = "true"
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If

        Catch ex As Exception

            result = "Update employee" + ex.Message.ToString()
        End Try
        Return result
    End Function
    'get all employees
    Public Function GetAllEmployees() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try

            sql = "Select DISTINCT system_login.Login_ID,system_login.Email,system_position.Position,applicant_gender.Gender, applicant_personal_details.Surname,applicant_personal_details.First_Name,applicant_personal_details.Middle_Name, applicant_personal_details.Contact_Number,applicant_personal_details.Alt_Contact_number,applicant_address.Address_Line_1, applicant_address.Address_Line_2, applicant_address.Address_Line_3, applicant_address.Postal_Code,applicant_province_municipality_city.City_Name FROM system_login,system_position,applicant_personal_details,applicant_gender,applicant_province_municipality_city,applicant_address 
WHERE system_position.Position_ID = system_login.Position_ID and 
applicant_gender.Gender_ID = applicant_personal_details.Gender_ID And 
system_login.Login_ID= applicant_personal_details.Personal_Details_ID and
applicant_province_municipality_city.Province_Municipality_City_ID = applicant_address.Province_Municipality_City_ID And
applicant_personal_details.Personal_Details_ID = applicant_address.Personal_Details_ID And 
system_login.Position_ID = 2"

            da = New MySqlDataAdapter(sql, MySqlConn)
            da.Fill(ds, "system_login")

            MySqlConn.Open()



            MySqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function
    Public Function GetApplicantPersonalId() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try

            sql = "SELECT distinct Login_ID FROM system_login "
            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "system_login")
            MySqlConn.Open()
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function

    Public Function GetApplicantPersonalName() As DataSet
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim sql As String
        Try

            sql = "SELECT distinct system_login.Login_ID,applicant_personal_details.Personal_Details_ID,applicant_personal_details.First_Name FROM system_login,applicant_personal_details where system_login.Login_ID=applicant_personal_details.Personal_Details_ID "
            da = New MySqlDataAdapter(sql, MySqlConn)

            da.Fill(ds, "system_login")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Return ds
    End Function




End Class
