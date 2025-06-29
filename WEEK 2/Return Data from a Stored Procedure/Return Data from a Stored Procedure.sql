use DN40week2;

CREATE PROCEDURE sp_CountEmpDept
    @DeptID INT
AS
BEGIN
    SELECT 
        COUNT(*) AS TotalEmployees
    FROM 
        Employees
    WHERE 
        DepartmentID = @DeptID;
END;

EXEC sp_CountEmpDept @DeptID = 3;
