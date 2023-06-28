create database projects
use projects
select * from customer
--========================================================================================--Customer--====================================================================================
--Customer
create table customer
(
	customer_id int primary key,
	customer_name nvarchar(50),
	address nvarchar(50),
	phone nvarchar(50),
	email nvarchar(50),
)
--------------------------------------------------------------------------------------
CREATE PROCEDURE CUSTOMER_Filter
(
	@keyword int	
)
	AS 
		BEGIN
				SELECT * FROM customers where  customer_id=@keyword
		END
execute CUSTOMER_Filter 1
--------------------------------------------------------------------------------------
CREATE PROCEDURE CUSTOMER_ADD
(
	@CUSTOMER_ID INT,
	@CUSTOMER_NAME NVARCHAR(50),
	@ADDRESS NVARCHAR(50),
	@PHONE NVARCHAR(50),
	@EMAIL NVARCHAR(50)
)
	AS 
		BEGIN
				INSERT INTO Customers VALUES (@CUSTOMER_ID,@CUSTOMER_NAME,@ADDRESS,@PHONE,@EMAIL)
		END
--EXECUTE SUPPLIERS_ADD @CUSTOMER_ID,@CUSTOMER_NAME,@ADDRESS,@PHONE,@EMAIL
------------------------------------------------------------------------------------
CREATE PROCEDURE CUSTOMER_DELETE
(
	@CUSTOMER_ID INT
)
	AS 
		BEGIN
			DELETE FROM CustomerS WHERE customer_id=@CUSTOMER_ID
		END
-------------------------------------------------------------------------------------------
CREATE PROCEDURE CUSTOMER_UPDATE
(
	@CUSTOMER_ID INT,
	@CUSTOMER_NAME NVARCHAR(50),
	@ADDRESS NVARCHAR(50),
	@PHONE NVARCHAR(50),
	@EMAIL NVARCHAR(50)
)
	AS 
		BEGIN
			UPDATE Customers SET CUSTOMER_NAME=@CUSTOMER_NAME,ADDRESS=@ADDRESS,PHONE=@PHONE,EMAIL=@EMAIL WHERE  CUSTOMER_ID=@CUSTOMER_ID
		END
EXECUTE CUSTOMER_UPDATE 2,'RAO','WW','2131231','2312@GMAILSD' 

-------------------------------------------------------------------------------------------
CREATE PROCEDURE CUSTOMER_VIEW 
	AS 
		BEGIN
			SELECT * FROM customerS
		END
EXECUTE CUSTOMER_VIEW
--------------------------------------------------------------------------------------------

--==============================================================================================--Supplier=====================================================================================
--Supplier
create table supplier
(
	supplier_id int primary key,
	name nvarchar(50),
	address nvarchar(50),
	phone nvarchar(50),
	email nvarchar(50),
)
-------------------------------------------------------------------------------------------
create PROCEDURE supplier_Filter
(
	@keyword int	
)
	AS 
		BEGIN
			SELECT * FROM suppliers where  supplier_id=@keyword
		END
execute supplier_Filter 1
-------------------------------------------------------------------------------------------
CREATE PROCEDURE SUPPLIERS_ADD
(
	@SUPPLIER_ID INT ,
	@NAME NVARCHAR(50),
	@ADDRESS NVARCHAR(50),
	@PHONE NVARCHAR(50),
	@EMAIL NVARCHAR(50)
)
	AS 
		BEGIN
			INSERT INTO SUPPLIERS VALUES (@SUPPLIER_ID,@NAME,@ADDRESS,@PHONE,@EMAIL)
		END
EXECUTE SUPPLIERS_ADD @SUPPLIER_ID,@NAME,@ADDRESS,@PHONE,@EMAIL 
-------------------------------------------------------------------------------------------
CREATE PROCEDURE SUPPLIERS_UPDATE
(
	@SUPPLIER_ID INT ,
	@NAME NVARCHAR(50),
	@ADDRESS NVARCHAR(50),
	@PHONE NVARCHAR(50),
	@EMAIL NVARCHAR(50)
)
	AS 
		BEGIN
		UPDATE  SUPPLIERS SET NAME=@NAME,ADDRESS=@ADDRESS,PHONE=@PHONE,EMAIL=@EMAIL WHERE SUPPLIER_ID=@SUPPLIER_ID
		END
-------------------------------------------------------------------------------------------
CREATE PROCEDURE SUPPLIERS_DELETE
(
	@SUPPLIER_ID INT 
)
AS 
	BEGIN
		DELETE FROM SUPPLIERS WHERE SUPPLIER_ID=@SUPPLIER_ID
	END
-------------------------------------------------------------------------------------------
CREATE PROCEDURE SUPPLIERS_VIEWS
	AS 
		BEGIN
			SELECT * FROM SUPPLIERS
		END
-- -------------------------------------------------------------------------------------------
--Category
--==============================================================================================----Category--======================================================================================
create table category
(
	category_id int primary key,
	category_name nvarchar(50),
	description nvarchar(50)
)
-------------------------------------------------------------------------------------------
CREATE PROCEDURE category_ADD
(
	@CATEGORY_ID INT ,
	@CATEGORY_NAME NVARCHAR(50),
	@DESCRIPTION NVARCHAR(50)
)
	AS 
		BEGIN
			INSERT INTO CATEGORYS VALUES (@CATEGORY_ID,@CATEGORY_NAME,@DESCRIPTION)
		END
EXECUTE category_ADD @CATEGORY_ID,@CATEGORY_NAME,@DESCRIPTION 
-------------------------------------------------------------------------------------------
CREATE PROCEDURE category_FILTER
(
	@keyword INT 
)
	AS 
		BEGIN
			SELECT * FROM CATEGORYS WHERE  category_id=@KEYWORD
		END
CREATE PROCEDURE category_UPDATE
(
	@CATEGORY_ID INT ,
	@CATEGORY_NAME NVARCHAR(50),
	@DESCRIPTION NVARCHAR(50)
)
	AS 
		BEGIN
			UPDATE  CATEGORYS SET @CATEGORY_NAME=@CATEGORY_NAME,DESCRIPTION=@DESCRIPTION WHERE category_id=@CATEGORY_ID
		END
EXECUTE category_UPDATE @CATEGORY_ID,@CATEGORY_NAME,@DESCRIPTION 
-------------------------------------------------------------------------------------------
create PROCEDURE category_DELETE
(
	@CATEGORY_ID INT 
)
	AS 
		BEGIN
			DELETE FROM CATEGORYS WHERE category_id=@CATEGORY_ID
		END
EXECUTE category_DELETE @CATEGORY_ID 
-------------------------------------------------------------------------------------------
CREATE PROCEDURE category_VIEW
	AS 
		BEGIN
			SELECT *  FROM CATEGORYS 
		END
EXECUTE category_VIEW 
-------------------------------------------------------------------------------------------
--====================================================================Payment===========================================

create table payment
(
	bill_number int primary key,
	payment_type nvarchar(50),
	total_amount int,
)
---------------------------------------------------------------------------------------------
create PROCEDURE payment_Filter
(
	@keyword int	
)
	AS 
		BEGIN
			SELECT * FROM payments where  bill_number=@keyword
		END
---------------------------------------------------------------------------------------------
create procedure add_payment
(
	@bill_number int,
	@payment_type nvarchar(50),
	@total_amount int
)
as
	begin
		insert into payments values(@bill_number,@payment_type,@total_amount);
	end
---------------------------------------------------------------------------------------------
create procedure delete_payment
(
	@bill_number int
)
as
	begin
		delete from payments where bill_number= @bill_number
	end
---------------------------------------------------------------------------------------------
alter procedure Update_payment
(
	@bill_number int,
	@payment_type nvarchar(50),
	@total_amount int
)
as
	begin
		update  payments set payment_type=@payment_type,total_amount=@total_amount where bill_number=@bill_number
	end
execute Update_payment 2,'card',2311
---------------------------------------------------------------------------------------------
create procedure view_payment
as
	begin
		SELECT * FROM PAYMENTS
	end
---------------------------------------------------------------------------------------------
--===============================================================================================--Order--==================================================================================

--Order

create table orders
(
	order_id int primary key,
	date_of_order date,
	customer_id int foreign key references customer(customer_id), 
	bill_number int foreign key references payment(bill_number),
)
CREATE TRIGGER CHECK_DATE ON orders
INSTEAD OF INSERT
	AS
		
		BEGIN
			
			IF (select date_of_order from inserted)<GETDATE()
				BEGIN
						PRINT'DATE ERROR'
				END
			ELSE
				BEGIN	
					INSERT INTO ORDERS SELECT * FROM inserted
				END
		END

---------------------------------------------------------------------------------------------------------------
create PROCEDURE orders_Filter
(
	@keyword int	
)
	AS 
		BEGIN
			SELECT * FROM orders where  order_id=@keyword
		END
execute supplier_Filter 1
---------------------------------------------------------------------------------------------------------------
create PROCEDURE orders_VIEW
	AS 
		BEGIN
			SELECT *  FROM orderss 
		END
EXECUTE orders_VIEW 
-----------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE orders_DELETE @order_id INT 
	AS 
		BEGIN
			DELETE  FROM orders WHERE  order_id=@order_id
		END
EXECUTE orders_DELETE @order_id
---------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ORDERS_ADD
(
	@ORDER_ID INT ,
	@DATE_OF_ORDER DATE,
	@CUSTOMER_ID INT,
	@BILL_NUMBER INT
)
	AS 
		BEGIN
			INSERT INTO ORDERS  VALUES (@ORDER_ID,@DATE_OF_ORDER,@CUSTOMER_ID,@BILL_NUMBER)
		END
EXECUTE ORDERS_ADD @ORDER_ID,@DATE_OF_ORDER, @CUSTOMER_ID,@BILL_NUMBER
-------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ORDERS_UPDATE
(
	@ORDER_ID INT ,
	@DATE_OF_ORDER DATE,
	@CUSTOMER_ID INT,
	@BILL_NUMBER INT
)
AS 
	BEGIN
		UPDATE  ORDERS SET DATE_OF_ORDER=@DATE_OF_ORDER,CUSTOMER_ID=@CUSTOMER_ID,BILL_NUMBER=@BILL_NUMBER where ORDER_ID=@ORDER_ID
	END

--===============================================================--product--===================================================
--product 

create table product
(
	product_id int primary key,
	product_name nvarchar(50),
	product_unit nvarchar(50),
	product_price nvarchar(50),
	supplier_id int foreign key references supplier(supplier_id),
	category_id int foreign key references category(category_id),
)
-----------------------------------------------------------------------------------table for trigger
create table product_copy
(
	product_id int ,
	product_name nvarchar(50),
	product_unit nvarchar(50),
	product_price nvarchar(50),
	supplier_id int foreign key references supplier(supplier_id),
	category_id int foreign key references category(category_id),
	operate nvarchar(50),
	history date
)
-----------------------------------------------------------------------------------
CREATE PROCEDURE productS_ADD
(
	@PRODUCT_ID INT ,
	@PRODUCT_NAME NVARCHAR(50),
	@PRODUCT_UNIT NVARCHAR(50),
	@PRODUCT_PRICE NVARCHAR(50),
	@SUPPLIER_ID INT,
	@CATEGORY_ID INT
)
	AS 
		BEGIN
			INSERT INTO Products VALUES (@PRODUCT_ID,@PRODUCT_NAME,@PRODUCT_UNIT,@PRODUCT_PRICE ,@SUPPLIER_ID ,@CATEGORY_ID)
		END
EXECUTE productS_ADD @PRODUCT_ID,@PRODUCT_NAME,@PRODUCT_UNIT,@PRODUCT_PRICE ,@SUPPLIER_ID ,@CATEGORY_ID
---------------------------------------------------------------------------------------------------
CREATE PROCEDURE productS_UPDATE
(
	@PRODUCT_ID INT ,
	@PRODUCT_NAME NVARCHAR(50),
	@PRODUCT_UNIT INT,
	@PRODUCT_PRICE INT,
	@SUPPLIER_ID INT,
	@CATEGORY_ID INT
)
	AS 
		BEGIN
			UPDATE Products SET PRODUCT_NAME=@PRODUCT_NAME,PRODUCT_UNIT=@PRODUCT_UNIT,PRODUCT_PRICE=@PRODUCT_PRICE ,SUPPLIER_ID=@SUPPLIER_ID ,CATEGORY_ID=@CATEGORY_ID WHERE  PRODUCT_ID=@PRODUCT_ID
		END
EXECUTE productS_UPDATE 5,'MEEZAN',300,300,1,1
--------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE products_view
	AS 
		BEGIN
			select * from Products 
		END
EXECUTE products_view
--------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE products_DELETE @PRODUCT_ID INT
	AS 
		BEGIN
			DELETE from Products where product_id=@PRODUCT_ID 
		END
EXECUTE products_DELETE 1


create PROCEDURE products_SEARCH 
(	
	@PRODUCT_ID int
)
	AS 
		BEGIN
			SELECT * from Products where product_id=@PRODUCT_ID
		END
EXECUTE products_SEARCH 6
-----------------------------------------------------------------------TRIGGER------------------------------------------
CREATE TRIGGER HistoryProduct on Product
after insert,delete,update
as
begin
	if exists(select * from inserted) and exists(select * from deleted)
		begin
			insert into product_copy select *,'update',GETDATE() from inserted 
		end
	else if exists(select * from inserted)
		begin
			insert into product_copy select *,'insert',GETDATE() from inserted 
		end
	else
		begin
			 insert into product_copy select *,'delete',GETDATE() from deleted 
		end
end
SELECT * FROM product_copy
insert into products(product_id,product_name,product_unit,product_price) values(8,'shampoo',200,200) 
delete  from Product

--===================================================================================--Order_detail--=================================================================================

--Order_detail
create table order_detail
(
	order_detail_id int primary key,
	unit_price int,
	size int,
	quantity int,
	product_id int foreign key references product(product_id),
	order_id int foreign key references orders(order_id)
)
CREATE PROCEDURE orderdetail_Filter
(
	@keyword int	
)
	AS 
		BEGIN
			SELECT * FROM orderdetail where  order_detail_id=@keyword
		END
------------------------------------------------------------
create PROCEDURE orderdetail_DELETE
(
	@order_detail_id INT
)
	AS 
		BEGIN
			DELETE from OrderDetail where order_detail_id=@order_detail_id 
		END
EXECUTE orderdetail_DELETE  2 
-------------------------------------------------------------------
create PROCEDURE orderdetail_VIEW
	AS 
		BEGIN
			SELECT * FROM OrderDetail
		END
EXECUTE orderdetail_VIEW 
---------------------------------------------------------------
CREATE PROCEDURE orderdetail_ADD
(
	@order_detail_id INT,
	@UNIT_PRICE INT,
	@SIZE INT,
	@QUNANTITY INT,
	@PRODUCT_ID INT,
	@ORDER_ID INT
)
	AS 
		BEGIN
			insert into OrderDetail VALUES(@order_detail_id,@UNIT_PRICE ,@SIZE,@QUNANTITY,@PRODUCT_ID, @ORDER_ID )
		END
execute orderdetail_ADD 5,1,1,1,4,1 
--------------------------------------------------------------------------------------
create PROCEDURE orderdetails_UPDATE
(
	@order_detail_id INT,
	@UNIT_PRICE INT,
	@SIZE INT,
	@QUNANTITY INT,
	@PRODUCT_ID INT,
	@ORDER_ID INT
)
	AS 
		BEGIN
			UPDATE  OrderDetail SET UNIT_PRICE=@UNIT_PRICE,size=@size,quantity=@QUNANTITY,product_id=@PRODUCT_ID,order_id=@ORDER_ID  where order_detail_id=@order_detail_id 
		END
---------------------------------------------------------------------------------------------------------
select * from customer
select * from orders
select * from supplier
select * from product
select * from category
select * from order_detail
select * from payment

insert into customer values(1,'Aneel','Behns colony karachi',03004567815,'aneel12@gmail.com'),
							(2,'Raheel','Machaer colony karachi',03004524515,'rahee05@gmail.com'),
							(3,'taimoor','Shantinagar sindhi para karachi',03004567815,'taimoorMM@gmail.com')

insert into orders values()


insert into supplier values(1,'ali','islamabad',03194648752,'ali1@gmail.com'),(456,'mubashir','karachi',03115648752,'mubashir2@gmail.com'),
							(457,'mubeen','lahore',03015600752,'mubeen42@gmail.com'),
							(458,'ali','islamabad',03194648752,'ali1@gmail.com')
insert into CATEGORYS values(1,'oil','unit')
							





-- ==============================================================================Create User========================================
CREATE LOGIN ANASAli WITH PASSWORD='123'
CREATE LOGIN HASANAHMED WITH PASSWORD='123'
CREATE LOGIN TAIMOORMANZOOR WITH PASSWORD='123'
--------------------------------------------------
CREATE USER ANASAli FOR LOGIN ANASAli
CREATE USER HASANAHMED FOR LOGIN HASANAHMED
CREATE USER TAIMOORMANZOOR FOR LOGIN TAIMOORMANZOOR
-- ===================================================Create role==================================================================
ALTER ROLE [DB_OWNER] ADD MEMBER TAIMOORMANZOOR
CREATE ROLE  CustomerServer AUTHORIZATION ANASALI
CREATE ROLE  Employee AUTHORIZATION HASANAHMED
-- =================================================GRANT/DENY/REVOKE=============================================================
DENY DELETE ON CUSTOMER  TO HASANAHMED
DENY DELETE ON CATEGORY   TO HASANAHMED
DENY DELETE ON ORDER_DETAIL TO HASANAHMED
DENY DELETE ON PAYMENT TO HASANAHMED
DENY DELETE ON PRODUCT TO HASANAHMED
DENY DELETE ON Supplier   TO HASANAHMED
-----------------------------------------------------
GRANT SELECT ON CUSTOMER  TO HASANAHMED
GRANT SELECT ON CATEGORY   TO HASANAHMED
GRANT SELECT ON ORDER_DETAIL TO HASANAHMED
GRANT SELECT ON PAYMENT TO HASANAHMED
GRANT SELECT ON PRODUCT TO HASANAHMED
GRANT SELECT  ON Supplier   TO HASANAHMED
-----------------------------------------------------
GRANT SELECT,INSERT,UPDATE ON CUSTOMER  TO ANASALI
GRANT SELECT,INSERT,UPDATE ON CATEGORY   TO ANASALI
GRANT SELECT,INSERT,UPDATE ON ORDER_DETAIL TO ANASALI
GRANT SELECT,INSERT,UPDATE ON PAYMENT TO ANASALI
GRANT SELECT,INSERT,UPDATE ON PRODUCT TO ANASALI
GRANT SELECT,INSERT,UPDATE   ON Supplier   TO ANASALI
-----------------------------------------------------
DENY CREATE TABLE TO ANASALI,HASANAHMED
DENY DELETE   TO ANASALI
--
USE projects
-- ===================================================VIEWS============
CREATE VIEW PRODUCT_SUPPLIER  AS SELECT PRODUCT.PRODUCT_ID, COUNT(*) AS SUPPLIERS FROM PRODUCT INNER JOIN SUPPLIER ON SUPPLIER.SUPPLIER_ID =PRODUCT.SUPPLIER_ID GROUP BY PRODUCT.PRODUCT_ID

CREATE VIEW PRODUCT_category  AS SELECT PRODUCT.PRODUCT_ID, COUNT(*) AS Categorys FROM PRODUCT INNER JOIN category ON category.category_id =PRODUCT.category_id GROUP BY PRODUCT.PRODUCT_ID

CREATE VIEW CUSTOMER_DISCOUNT AS SELECT * FROM ORDERS WHERE order_id IN (SELECT order_id FROM order_detail)

--  1st view							
create view CustomerS as SELECT *  FROM CUSTOMER
--  2nd view
create view SUPPLIERS as SELECT *  FROM SUPPLIER
-- 3rd View
create view OrderDetail as select * from order_detail
-- 4th View
CREATE VIEW Payments As select * from payment
-- 5TH
CREATE VIEW CATEGORYS AS SELECT * FROM category
-- 6th 
create view Products as select * from product
-- 7th
create view orderss as select * from orders
-- ==============================================================FUNCTION============================================================
CREATE FUNCTION RECORD_DATE
(
	@DATE DATE
)
RETURNS INT
			AS
				BEGIN
					RETURN (SELECT COUNT(*) AS [TOTAL_ORDER] FROM ORDERS WHERE date_of_order=@DATE)
				END
SELECT DBO.RECORD_DATE ('2022-01-05')
