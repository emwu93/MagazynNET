USE [magazyn]
GO

/****** Object:  StoredProcedure [dbo].[wys_zamowienia]    Script Date: 2017-01-21 23:29:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[wys_zamowienia]
as
select z.id_zam, z.data_zam,k.nazwa_firmy,k.imie, k.nazwisko ,k.miejscowosc ,k.adres,pr.nazwa,pr.cena_za_szt,z.ilosc,pr.cena_za_szt*z.ilosc 
from Zamowienia z
inner join Produkty pr
on pr.id=z.id_prod
inner join Klienci k
on k.id=z.id_klient;
GO


