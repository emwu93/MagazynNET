USE [magazyn]
GO

/****** Object:  StoredProcedure [dbo].[dodaj_zamowienie]    Script Date: 2017-01-21 23:28:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[dodaj_zamowienie] (@nr_zamowienia int, @adres varchar(100), @nazwa_prod varchar(50),@ilosc int)
as
DECLARE
@id_klient int,
@id_prod int,
@imie_klienta varchar(50),
@nazwisko_klienta varchar(50)
SET @imie_klienta=(select imie from Klienci where @adres=adres)
SET @nazwisko_klienta=(select nazwisko from Klienci where @adres=adres)
SET @id_klient= (select id from Klienci where imie=@imie_klienta AND nazwisko=@nazwisko_klienta)
SET @id_prod=(select id from Produkty where nazwa=@nazwa_prod)

insert into Zamowienia(id_klient,id_prod,id_zam,ilosc) values (@id_klient,@id_prod,@nr_zamowienia,@ilosc)
GO


