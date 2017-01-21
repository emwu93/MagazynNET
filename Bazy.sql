create database magazyn
GO

use magazyn
GO


create table Produkty(
id int PRIMARY KEY IDENTITY,
nazwa varchar(200),
producent varchar(100),
ilosc int,
kraj_pochodzenia varchar(50),
cena_za_szt int NOT NULL,
zamowiona_ilosc int,
)
GO

create table Klienci(
id int PRIMARY KEY IDENTITY,
nazwa_firmy varchar(100), 
imie varchar(20) NOT NULL,
nazwisko varchar(50) NOT NULL,
telefon varchar(15) NOT NULL,
miejscowosc varchar(50) NOT NULL,
kraj varchar(50) NOT NULL,
adres varchar(200) NOT NULL,
)
GO

create table Zamowienia(
id_zam int NOT NULL,
id_klient int FOREIGN KEY REFERENCES Klienci(id),
id_prod int FOREIGN KEY REFERENCES Produkty(id),
ilosc int NOT NULL,
data_zam date,
)
GO

insert into Produkty(nazwa,producent,kraj_pochodzenia,ilosc,zamowiona_ilosc,cena_za_szt) values
('TOMATO pomidor','TomaTos ES','Hiszpania',20,0,10),
('Ser zolty','KEK PL','Polska',60,0,5),
('Mango','MangoPL', 'Polska',10,0,8)

GO
insert into Klienci(nazwa_firmy,imie,nazwisko,telefon,miejscowosc,kraj,adres) values
('BigMoM','Ted','Tedsky','681934879','Luksemburg','Luksemburg','TedskyStreet 67/90'),
('','Tomasz','Tomaszewski','505606202','Polska','Lodz','ul.Zwirki 50')

insert into Zamowienia(id_klient,id_prod,ilosc,id_zam) values
(1,1,3,1),
(2,3,2,2)

alter procedure wys_zamowienia
as
select z.id_zam, z.data_zam,k.nazwa_firmy,k.imie, k.nazwisko ,k.miejscowosc ,k.adres,pr.nazwa,pr.cena_za_szt,z.ilosc,pr.cena_za_szt*z.ilosc 
from Zamowienia z
inner join Produkty pr
on pr.id=z.id_prod
inner join Klienci k
on k.id=z.id_klient;

exec wys_zamowienia

ALTER FUNCTION czy_jest_klient (@imie_klienta varchar(50), @nazw_klienta varchar(50), @miejscowosc varchar(50)) returns int
AS
BEGIN
DECLARE
	@wynik as int,
	@tmp as int
	SET @tmp=(select id from Klienci where imie=@imie_klienta AND nazwisko=@nazw_klienta AND miejscowosc=@miejscowosc)

	if @tmp=0
		SET @wynik=0
	else
		SET @wynik=@tmp
return @wynik
END

alter procedure dodaj_zamowienie (@nr_zamowienia int, @nazwa_firmy varchar(50), @imie_klienta varchar(20), @nazwisko_klienta varchar(100), @adres varchar(100), @nazwa_prod varchar(50),
@ilosc int)
as
DECLARE
@id_klient int,
@id_prod int
SET @id_klient= (select id from Klienci where imie=@imie_klienta AND nazwisko=@nazwisko_klienta)
SET @id_prod=(select id from Produkty where nazwa=@nazwa_prod)

insert into Zamowienia(id_klient,id_prod,id_zam,ilosc) values (@id_klient,@id_prod,@nr_zamowienia,@ilosc)


exec dodaj_zamowienie 2,'Sommer','Mateusz','Wierzbicki','Zapole 35a','Myd³o',2