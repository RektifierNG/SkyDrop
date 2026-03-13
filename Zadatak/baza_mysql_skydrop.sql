CREATE DATABASE SkyDrop;
USE SkyDrop;

SET names utf8mb4;

CREATE TABLE Dron(
	DronId int AUTO_INCREMENT NOT NULL,
	Model nvarchar(50) NOT NULL,
	CONSTRAINT PK_Dron PRIMARY KEY (DronId)
);

CREATE TABLE Korisnik(
	KorisnikId int AUTO_INCREMENT NOT NULL,
	Ime nvarchar(50) NOT NULL,
	Prezime nvarchar(50) NOT NULL,
	Email nvarchar(50) NOT NULL,
	DatumRodjenja date NULL,
	CONSTRAINT PK_Korisnik PRIMARY KEY (KorisnikId)
);

CREATE TABLE Narudzba(
	NarudzbaId int AUTO_INCREMENT NOT NULL,
	KorisnikId int NOT NULL,
	Naziv nvarchar(100) NOT NULL,
	DatumNarudzbe datetime NOT NULL,
	CONSTRAINT PK_Narudzba PRIMARY KEY (NarudzbaId)
);

CREATE TABLE Paket(
	PaketId int AUTO_INCREMENT NOT NULL,
	NarudzbaId int NOT NULL,
	Naziv nvarchar(100) NOT NULL,
	TezinaKg int NOT NULL,
	TezinaG int NOT NULL,
	CONSTRAINT PK_Paket PRIMARY KEY (PaketId)
);

CREATE TABLE Ruta(
	RutaId int AUTO_INCREMENT NOT NULL,
	DronId int NOT NULL,
	Naziv nvarchar(100) NOT NULL,
	PlaniranPolazak datetime NOT NULL,
	PlaniranPovratak datetime NOT NULL,
	CONSTRAINT PK_Ruta PRIMARY KEY (RutaId)
);

CREATE TABLE RutaPaket(
	RutaPaketId int AUTO_INCREMENT NOT NULL,
	RutaId int NOT NULL,
	PaketId int NOT NULL,
	Redoslijed int NOT NULL,
	CONSTRAINT PK_RutaPaket PRIMARY KEY (RutaPaketId)
);

INSERT Dron (DronId, Model) VALUES (1, N'DJI Matrice 350');
INSERT Dron (DronId, Model) VALUES (2, N'DJI FlyCart 30');
INSERT Dron (DronId, Model) VALUES (3, N'Wingcopter 198');
INSERT Dron (DronId, Model) VALUES (4, N'Zipline P2');
INSERT Dron (DronId, Model) VALUES (5, N'EHang 216-S');
INSERT Dron (DronId, Model) VALUES (6, N'Volocopter VoloDrone');
INSERT Dron (DronId, Model) VALUES (7, N'Flytrex F100');

INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (1, N'Mario', N'Tomić', N'mtomic@test.com', CAST(N'1995-11-17' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (2, N'Lucija', N'Šimić', N'luce@test.com', CAST(N'1983-01-12' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (3, N'Katarina', N'Babić', N'kate@test.com', CAST(N'2003-10-05' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (4, N'Ivan', N'Horvat', N'ihorvat@test.com', CAST(N'1978-06-23' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (5, N'Ana', N'Kovačević', N'ana.k@test.com', CAST(N'2001-03-09' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (6, N'Petar', N'Novak', N'pnovak@test.com', CAST(N'1990-12-30' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (7, N'Maja', N'Jurić', N'maja.j@test.com', CAST(N'1965-08-14' AS Date));
INSERT Korisnik (KorisnikId, Ime, Prezime, Email, DatumRodjenja) VALUES (8, N'Tomislav', N'Marić', N'tmaric@test.com', CAST(N'1952-04-02' AS Date));

INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (1, 1, N'Ugovor za potpis', CAST(N'2025-01-10 09:15:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (2, 1, N'Rezervni dijelovi', CAST(N'2025-01-12 14:30:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (3, 2, N'Medicinski uzorak', CAST(N'2025-01-10 10:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (4, 2, N'Lijekovi - hitna dostava', CAST(N'2025-01-15 08:20:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (5, 3, N'Školske knjige', CAST(N'2025-01-20 11:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (6, 3, N'IT oprema', CAST(N'2025-01-22 16:45:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (7, 4, N'Alat za radionicu', CAST(N'2025-02-01 07:30:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (8, 4, N'Zaštitna oprema', CAST(N'2025-02-01 07:45:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (9, 5, N'Kozmetika', CAST(N'2025-02-05 13:10:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (10, 5, N'Cvijeće za rođendan', CAST(N'2025-02-14 09:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (11, 6, N'Laboratorijski pribor', CAST(N'2025-02-10 10:30:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (12, 6, N'Elektroničke komponente', CAST(N'2025-02-18 15:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (13, 7, N'Knjige - beletristika', CAST(N'2025-03-01 12:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (14, 7, N'Vitamini i dodaci', CAST(N'2025-03-05 08:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (15, 8, N'Poštanski paket', CAST(N'2025-03-10 09:30:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (16, 1, N'Hrana - ručak dostava', CAST(N'2025-03-12 11:45:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (17, 2, N'Strojni dio za servis', CAST(N'2025-03-15 14:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (18, 3, N'Sportska oprema', CAST(N'2025-03-18 10:15:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (19, 4, N'Senzori za projekt', CAST(N'2025-03-20 16:00:00' AS datetime));
INSERT Narudzba (NarudzbaId, KorisnikId, Naziv, DatumNarudzbe) VALUES (20, 5, N'Odjeća - online narudžba', CAST(N'2025-03-22 18:30:00' AS datetime));

INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (1, 1, N'Dokument - ugovor', 0, 120);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (2, 2, N'Kutija rezervnih dijelova', 1, 200);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (3, 3, N'Medicinski uzorak', 0, 450);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (4, 4, N'Lijekovi paket', 0, 800);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (5, 5, N'Školske knjige', 2, 0);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (6, 6, N'Laptop i oprema', 2, 500);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (7, 7, N'Set alata', 4, 200);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (8, 8, N'Zaštitna oprema', 2, 400);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (9, 9, N'Kozmetički set', 0, 300);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (10, 10, N'Buket cvijeća', 0, 600);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (11, 11, N'Laboratorijski pribor', 2, 100);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (12, 12, N'Elektroničke ploče', 0, 350);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (13, 13, N'Paket knjiga', 1, 500);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (14, 14, N'Vitamini i dodaci', 0, 250);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (15, 15, N'Poštanski paket', 0, 950);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (16, 16, N'Kutija s hranom', 0, 800);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (17, 17, N'Strojni dio', 7, 500);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (18, 18, N'Sportski rekviziti', 3, 200);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (19, 19, N'Kutija senzora', 0, 250);
INSERT Paket (PaketId, NarudzbaId, Naziv, TezinaKg, TezinaG) VALUES (20, 20, N'Paket odjeće', 0, 500);

INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (1, 1, N'Jutarnja dostava - centar', CAST(N'2025-01-10 10:00:00' AS datetime), CAST(N'2025-01-10 10:45:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (2, 2, N'Hitna medicinska', CAST(N'2025-01-15 08:30:00' AS datetime), CAST(N'2025-01-15 09:00:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (3, 3, N'Školska dostava', CAST(N'2025-01-22 17:00:00' AS datetime), CAST(N'2025-01-22 18:00:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (4, 4, N'Industrijska zona - teški teret', CAST(N'2025-02-01 08:00:00' AS datetime), CAST(N'2025-02-01 09:30:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (5, 5, N'Valentinovo ekspres', CAST(N'2025-02-14 09:15:00' AS datetime), CAST(N'2025-02-14 10:00:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (6, 1, N'Laboratorij i elektronika', CAST(N'2025-02-18 15:30:00' AS datetime), CAST(N'2025-02-18 16:30:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (7, 6, N'Proljetna dostava', CAST(N'2025-03-05 08:30:00' AS datetime), CAST(N'2025-03-05 09:45:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (8, 7, N'Ručak ekspres', CAST(N'2025-03-12 12:00:00' AS datetime), CAST(N'2025-03-12 12:30:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (9, 2, N'Teški teret - servis', CAST(N'2025-03-15 14:30:00' AS datetime), CAST(N'2025-03-15 16:00:00' AS datetime));
INSERT Ruta (RutaId, DronId, Naziv, PlaniranPolazak, PlaniranPovratak) VALUES (10, 3, N'Popodnevna runda', CAST(N'2025-03-22 19:00:00' AS datetime), CAST(N'2025-03-22 20:00:00' AS datetime));

INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (1, 1, 1, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (2, 1, 2, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (3, 1, 3, 3);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (4, 2, 4, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (5, 3, 5, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (6, 3, 6, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (7, 4, 7, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (8, 4, 8, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (9, 5, 9, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (10, 5, 10, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (11, 6, 11, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (12, 6, 12, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (13, 7, 13, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (14, 7, 14, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (15, 7, 15, 3);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (16, 8, 16, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (17, 9, 17, 1);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (18, 9, 18, 2);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (19, 9, 19, 3);
INSERT RutaPaket (RutaPaketId, RutaId, PaketId, Redoslijed) VALUES (20, 10, 20, 1);

ALTER TABLE Narudzba ADD CONSTRAINT FK_Narudzba_Korisnik FOREIGN KEY(KorisnikId)
REFERENCES Korisnik (KorisnikId);

ALTER TABLE Paket ADD CONSTRAINT FK_Paket_Narudzba FOREIGN KEY(NarudzbaId)
REFERENCES Narudzba (NarudzbaId);

ALTER TABLE Ruta ADD CONSTRAINT FK_Ruta_Dron FOREIGN KEY(DronId)
REFERENCES Dron (DronId);

ALTER TABLE RutaPaket ADD CONSTRAINT FK_RutaPaket_Ruta FOREIGN KEY(RutaId)
REFERENCES Ruta (RutaId);

ALTER TABLE RutaPaket ADD CONSTRAINT FK_RutaPaket_Paket FOREIGN KEY(PaketId)
REFERENCES Paket (PaketId);
