

create proc KategoriEkle
@KategoriAd varchar(50)
as
insert into Kategori values(@KategoriAd)

exec KategoriEkle 'Kategori'

select * from kategori


create proc KategoriSil
@KategoriId int
as
delete from kategori where KategoriId=@KategoriId

exec KategoriSil 1

select * from kategori


create proc KitapEkle
@KitapAd varchar(50),
@KategoriId int
as
insert into Kitap values(@KitapAd,@KategoriId)

exec KitapEkle 'Kitap',2

select * from Kitap

create proc KitapSil
@KitapId int
as
delete from Kitap where KitapId=@KitapId

exec KitapSil 2
