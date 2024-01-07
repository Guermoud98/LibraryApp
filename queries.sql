CREATE DATABASE libraryApp;
use libraryApp;
SELECT * FROM dbo.__EFMigrationsHistory;
SELECT * FROM Adherents;
SELECT * FROM Livres;
SELECT * FROM Reservations;
UPDATE Livres SET Disponible = 'Oui' WHERE IdLivre = 3;
DELETE FROM Livres WHERE idLivre = 8;

USE reservationTaxi;
SELECT * FROM client;