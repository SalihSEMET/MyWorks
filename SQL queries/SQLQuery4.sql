--DDl(Data Definition Language)

--Create -- Oluşturma
-- Alter -- Güncelleme
-- Drop -- kaldırma

use master 
create database OkulDb

use OkulDb
create table Ogrenciler(
Id int Primary key Identity(1,1),
Ad nvarchar(50) not null,
Soyad nvarchar(50) not null,
DogumTarihi Date null);


-- Tablo Adı Güncelleme

exec sp_rename 'Ogrenciler','OgrenciListesi'
-- Tabloyu Güncelleyerek Yeni Bir Kolon Ekleme
alter table OgrenciListesi 
add Email nvarchar(100) null

--Var Olan Bir Tablo İçerisindeki var Olan Bir kolonu Güncelleme

alter table OgrenciListesi
alter column Email nvarchar(200) null

--Var Olan Bir Tablo İçerisinden Kolonu Kaldırma
alter table OgrenciListesi
drop column Email

--Var Olan Bir Tabloyu Kaldırma 
drop table OgrenciListesi 

use master 
drop database OkulDB

-- İlişki Türleri

-- Bire Bir --
-- Bire Çok --
-- Çoka Çok --
