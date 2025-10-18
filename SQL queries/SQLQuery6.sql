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

-- Sadece 1997 Yılındaki Siparişlerin Listelenmesi

select * from Orders where Year(OrderDate) = 1997

select * from Orders where Month(OrderDate) = 7
-- Len KArakter Uzulugunu Verir
select ProductName,LEN(ProductName)  karaktersayısı from Products


select FirstName + ' ' + LastName from Employees

-- Replicate : Belirtilen Sayı Adedince Karakter Ekler 

-- Len : Metnin Uzunlugunu/Karakter Sayısını Verir

-- Concat : Birden Fazla Veriyi Yan Yana Birleştirme İşlemi Yapar 

-- Substring : Bir Verinin Belirli Bir Başlangıç Degerinden İtibaren Belirli Bir Sayı Kadar Karakterlerini Verir. 


select CONCAT(SUBSTRING(FirstName,1,1),REPLICATE('*',Len(FirstName) - 1),
' ',Substring(LastName,1,1),REPLICATE('*',LEN(LastName) - 1))
from Employees


-- Subquery(Alt Sorgu) : Bir Sorgunun Sonucunun Başka Bir Sorgunun Sonucundan Dönen Degere göre Çalışması.
-- Subquery İki Yere Yazılır select ve from arasına birde where koşulundan sonra.

select * from Categories
select * from Products where CategoryID = (select CategoryID from Categories where CategoryName = 'Seafood')

select
ProductID,
ProductName,
SupplierID,
(select CategoryName from Categories where CategoryID = Products.CategoryID),
QuantityPerUnit,
UnitPrice,
UnitsOnOrder,
ReorderLevel,
Discontinued
from Products


select
OrderID,
(select ProductName from Products where ProductID = [Order Details].ProductID),
UnitPrice,
Quantity,
Discount
from [Order Details]
group by OrderID,ProductID,UnitPrice,Quantity,Discount

select
OrderID,
UnitPrice,
Quantity,
Discount
from [Order Details]
group by OrderID,UnitPrice,Quantity,Discount




