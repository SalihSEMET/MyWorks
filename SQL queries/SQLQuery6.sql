select ProductName,
UnitPrice,
UnitsInStock
from Products group by ProductName,UnitPrice,UnitsInStock

select
Max(UnitPrice)
from Products

select
Min(UnitPrice)
from Products

select
AVG(UnitPrice)
from Products

select
SUM(UnitPrice)
from Products

select * from Products where UnitPrice >= 50 order by UnitPrice

select * from Products where CategoryID = 5

select CategoryID,Count(*) from Products group by CategoryID

select * from Customers where Country = 'Germany'


--Top : İlk Sıradan itibaren içerisine verdigimiz sayı adedince veri gösterir.
select Top(5)* from Products Order by UnitPrice desc

select * from  Employees

select FirstName,LastName,City from Employees

-- Ülkelere Göre Müşteri Sayısı Bulma 

select Country,COUNT(*) MusteriSayısı
from Customers group by Country order by MusteriSayısı desc