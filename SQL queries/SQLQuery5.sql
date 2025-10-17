use Northwind

--select Country from Customers group by Country

select Country,City from Customers group by Country,City

-- Agreate Functions : Bütün Sql uygulamalarında kullanabilicemiz ortak Fonksiyonlardır. Yardımcı Araçlardır.
-- Count : Sayısını Verir
-- Sum   : Kolonun Toplamını Verir
-- Max   : Kolon İçerisindeki En Büyük degeri Verir.
-- Min   : Kolon İçerisindeki En Küçük degeri Verir.
-- Avg   : Kolon İçerisindeki Degerlerin Ortalamasını Verir.
-------------------------

select Country,City,Count(City) from Customers group by Country,City



