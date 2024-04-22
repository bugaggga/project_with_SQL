

IF EXISTS(SELECT * FROM sys.triggers WHERE NAME = N'Training_AlterTableSecurity' AND parent_class_desc = N'DATABASE')
BEGIN 
	DROP TRIGGER Training_AlterTableSecurity
	ON DATABASE
END
GO

CREATE TRIGGER Training_AlterTableSecurity
ON DATABASE
FOR ALTER_TABLE
AS
BEGIN
	PRINT '��� ������� ���������� � ������ �������������� ���� ������ ��� ��������� �������''Tr_AlterTableSecurity'' to alter the table!'
	ROLLBACK TRANSACTION
END
GO