select P.ProductID, P.ProductName, P.ProductDesc, P.Price,C.CategoryID,C.CategoryName from Product P inner join Category C
on P.CategoryID = C.CategoryID


Create proc UpdateProduct
@ProductID int,
@ProductName nvarchar(50),
@ProductDesc nvarchar(500),
@Price decimal(6,2),
@CategoryID int
as
Update Product
set
ProductName = @ProductName,
ProductDesc = @ProductDesc,
Price = @Price,
CategoryID = @CategoryID
where ProductID = @ProductID
