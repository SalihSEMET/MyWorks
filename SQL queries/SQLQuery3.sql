-- CRUD(Create, Read, Update, Delate) --

-- DML (Data Manipulation Language)

-- Veri Listeleme Komutu --
-- Select[Kolon Adı] from [Tablo Adı]  = Verileri Listeler --
-- select [Books Name],[Author Name],[Page Number] from Book_Table 
-- select * from Book_Table

-- Veri Ekleme Komutu
-- insert into [Tablo Adı] ([Kolon Adları]) values ([Kolon Adları Sırasıyla Eklenmek İstenen Veriler])

insert Book_Table ([Id],[Books Name],[Author Name],[Page Number]) values 
(1,'Sefiller','Victor Hugo',500),(2,'Aşk I Memnu','Halit Ziya Uşaklıgil',392)

select * from Book_Table

-- Veri Güncelleme 

-- Update [Tablo Adı] set [Kolon Adı] = Yeni Deger
-- Where Koşul Belirtir O Sorguya Göre Koşul Çalıştırabılmemizi Saglayan Komut
Update Book_Table set [Books Name] = 'Kitap Adı' where [Books Name] = 'Don Kişot'
-- Çoklu için Update TabloADı set KolonAdı = 'Yeni Veri', kolonadı = 'Yeni Veri' Dİye Gidebiliriz.
select * from Book_Table

-- Veri Silme Komutu

-- Delete from [Tablo Adı]
-- Delete Book_Table
-- Delete fro [Tablo Adı] where [ID] 
