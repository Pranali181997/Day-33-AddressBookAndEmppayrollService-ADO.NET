
ALTER PROCEDURE SP_AdDData
    @EmployeeName VARCHAR(50),
    @PhoneNumber VARCHAR(50),
    @Address VARCHAR(50),
    @Department VARCHAR(50),
    @Gender CHAR(1),
	@BasicPay FLOAT,
	@Deduction FLOAT,
	@TaxablePay FLOAT,
	@Tax FLOAT,
	@NetPay FLOAT,
	@StartDate DATETIME,
	@City varchar(50),
	@Country varchar(50)
AS
BEGIN   
   insert into Payroll_Service values( @EmployeeName,@PhoneNumber,@Address,@Department,@Gender,@BasicPay,@Deduction,@TaxablePay,@Tax,@NetPay,@StartDate,@City,@Country);
    
END
