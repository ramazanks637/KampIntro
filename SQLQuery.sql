--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

-- case insensitive -> büyük küçük harf duyarsız
select * from Products where  CategoryID = 1 or CategoryID =3

select * from Products where  CategoryID = 1 and UnitPrice>=10


select * from Products where CategoryID =1 order by UnitPrice desc -- ascending asc -> artan --descending desc ->azalan

select count(*) Adet from Products -- bütün product tablosunda kaç data var ?
select count(*) Adet from Products where CategoryID =2 -- 2 numaralı kategoride kaç ürün var ?

select CategoryID,count(*) Adet from Products group by CategoryID

select CategoryID,count(*) Adet from Products group by CategoryID having count(*)>10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID


Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null








